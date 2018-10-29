using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Threading;

namespace M.B.N.G.B.T.WalterSchulteTest
{
    /// <summary>
    /// Логика взаимодействия для WalterSchulteTestTablePage.xaml
    /// </summary>
    public partial class WalterSchulteTestTablePage : Page
    {
        private List<int> listClickButtons = new List<int>();
        private List<int> listRandomNumbers = new List<int>();
        private List<int> listClickMistakesButtons = new List<int>();

        private Button[] arrAllButtons = new Button[25];

        private Random rnd = new Random();
        private ClassLibraryMBNGBT cl = new ClassLibraryMBNGBT();
        private DispatcherTimer dispatcherTimer = new DispatcherTimer();

        private static int[] arrAllStageSecond = new int[5];
        private static int allowableTime = 0;

        public static byte Stage { get; set; } = 1;
        public static int[] ArrAllStageSecond { get { return arrAllStageSecond; } }
        public static int AllowableTime { get { return allowableTime; } }

        private int second = 0;
        private byte counterButtonClick = 0;
        private byte secondForBrushNullButtons = 0;
        private bool doorForChangeColorButtonBackground = false;
        private int indexButton = 0;

        public WalterSchulteTestTablePage()
        {
            if (Stage == 1)
                arrAllStageSecond = new int[5];

            allowableTime = 0;
            InitializeComponent();
            ChangeContentButtonRandom();
            startStage.Content = $"{Stage}/5";
            dispatcherTimer.Tick += new EventHandler(LabelTimer);
            dispatcherTimer.Start();
        }

        private void Button_Exit_The_Test(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
            dispatcherTimer.Stop();
        }

        private void LabelTimer(object sender, EventArgs e)
        {
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            if (second == 300)
            {
                allowableTime = 300;
                NavigationService.Navigate(new WalterSchulteTestResultPage());
                dispatcherTimer.Stop();
            }

            if (second < 10)
                timer.Content = $"0{second++}";
            else
                timer.Content = $"{second++}";


            if (secondForBrushNullButtons == 2 && doorForChangeColorButtonBackground)
                BrushingButtonsColorDefult(listClickMistakesButtons.ToArray());
            secondForBrushNullButtons++;
        }

        private void BrushingButtonsColorDefult(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arrAllButtons[(arr[i] - 1)].Foreground = Brushes.Black;
                arrAllButtons[(arr[i] - 1)].Background = Brushes.White;
            }
            secondForBrushNullButtons = 0;
            doorForChangeColorButtonBackground = false;
        }

        private void ChangeContentButtonRandom()
        {
            arrAllButtons = new[] {button1 , button2 , button3 , button4 , button5 , button6 , button7 , button8 , button9 , button10,
                                   button11 , button12 , button13 , button14 , button15 , button16 , button17 , button18 , button19 , button20,
                                   button21 , button22 , button23 , button24 , button25 };
            int temp = 0;
            for (int i = 0; i < 25; i++)
            {
                temp = rnd.Next(1, 26);
                if (listRandomNumbers.Count == 0 || !cl.SearchMatchingNumberInArr(listRandomNumbers.ToArray(), temp))
                {
                    listRandomNumbers.Add(temp);
                    arrAllButtons[i].Content = temp;
                }
                else
                    i--;
            }
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            indexButton = GetButtonIndex(((Button)sender).Name);

            if (counterButtonClick + 1 == Convert.ToByte(arrAllButtons[indexButton].Content))
            {
                counterButtonClick++;
                BrushingButtonsColorDefult(listClickMistakesButtons.ToArray());
                listClickButtons.Add(indexButton + 1);
                LabelSearchNumber.Content = $"--> {(counterButtonClick + 1)}";
            }
            else
            if (counterButtonClick != Convert.ToByte(arrAllButtons[indexButton].Content))
            {
                arrAllButtons[indexButton].Background = Brushes.Red;
                arrAllButtons[indexButton].Foreground = Brushes.Red;
                listClickMistakesButtons.Add(indexButton + 1);
                secondForBrushNullButtons = 0;
                doorForChangeColorButtonBackground = true;
            }
            if (counterButtonClick == 25)
            {
                arrAllStageSecond[Stage - 1] = second;
                Stage++;
                dispatcherTimer.Stop();
                if (Stage != 6)
                    NavigationService.Navigate(new WalterSchulteTestTablePage());
                else
                    NavigationService.Navigate(new WalterSchulteTestResultPage());
            }
        }

        private int GetButtonIndex(string buttonName)
        {
            for (int i = 0; i < arrAllButtons.Length; i++)
                if (buttonName == arrAllButtons[i].Name)
                    return i;
            return -1;
        }

        private void Button1_MouseEnter(object sender, MouseEventArgs e)
        {
            indexButton = GetButtonIndex(((Button)sender).Name);
            if (arrAllButtons[indexButton].Background == Brushes.Red)
                arrAllButtons[indexButton].Foreground = Brushes.Red;
        }

        private void Button1_MouseLeave(object sender, MouseEventArgs e)
        {
            indexButton = GetButtonIndex(((Button)sender).Name);
            if (arrAllButtons[indexButton].Background == Brushes.Red)
                arrAllButtons[indexButton].Foreground = Brushes.Black;
        }
    }
}