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
        private List<int> listClickButtons { get; set; } = new List<int>();
        private List<int> listRandomNumbers { get; set; } = new List<int>();
        private List<int> listClickMistakesButtons { get; set; } = new List<int>();

        private Button[] arrAllButtons { get; set; } = new Button[25];

        private Random rnd = new Random();
        private ClassLibraryMBNGBT cl = new ClassLibraryMBNGBT();
        private DispatcherTimer dispatcherTimer = new DispatcherTimer();

        public static byte Stage { get; set; } = 1;
        public static int[] ArrAllStageSecond { get; private set; } = new int[5];
        public static int AllowableTime { get; private set; } = 0;

        private int Second { get; set; } = 0;
        private byte CounterButtonClick { get; set; } = 0;
        private byte secondForBrushNullButtons { get; set; } = 0;
        private bool DoorForChangeColorButtonBackground { get; set; } = false;
        private int IndexButton { get; set; } = 0;

        public WalterSchulteTestTablePage()
        {
            if (Stage == 1)
                ArrAllStageSecond = new int[5];

            AllowableTime = 0;
            InitializeComponent();
            ChangeContentButtonRandom();
            startStage.Content = $"{Stage}/5";
            dispatcherTimer.Tick += new EventHandler(LabelTimer);
            dispatcherTimer.Start();
        }

        private void Button_Exit_The_Test(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new WalterSchulteTestRulePage());
            dispatcherTimer.Stop();
        }

        private void LabelTimer(object sender, EventArgs e)
        {
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            if (Second == 300)
            {
                AllowableTime = 300;
                NavigationService.Navigate(new WalterSchulteTestResultPage());
                dispatcherTimer.Stop();
            }

            if (Second < 10)
                timer.Content = $"0{Second++}";
            else
                timer.Content = $"{Second++}";


            if (secondForBrushNullButtons == 2 && DoorForChangeColorButtonBackground)
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
            DoorForChangeColorButtonBackground = false;
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
                if (listRandomNumbers.Count == 0 || !cl.SerchMatchingNumberInArr(listRandomNumbers.ToArray(), temp))
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
            IndexButton = GetButtonIndex(((Button)sender).Name);

            if (CounterButtonClick + 1 == Convert.ToByte(arrAllButtons[IndexButton].Content))
            {
                CounterButtonClick++;
                BrushingButtonsColorDefult(listClickMistakesButtons.ToArray());
                listClickButtons.Add(IndexButton + 1);
            }
            else
            if (CounterButtonClick != Convert.ToByte(arrAllButtons[IndexButton].Content))
            {
                arrAllButtons[IndexButton].Background = Brushes.Red;
                arrAllButtons[IndexButton].Foreground = Brushes.Red;
                listClickMistakesButtons.Add(IndexButton + 1);
                secondForBrushNullButtons = 0;
                DoorForChangeColorButtonBackground = true;
            }
            if (CounterButtonClick == 25)
            {
                ArrAllStageSecond[Stage - 1] = Second;
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
            IndexButton = GetButtonIndex(((Button)sender).Name);
            if (arrAllButtons[IndexButton].Background == Brushes.Red)
                arrAllButtons[IndexButton].Foreground = Brushes.Red;
        }

        private void Button1_MouseLeave(object sender, MouseEventArgs e)
        {
            IndexButton = GetButtonIndex(((Button)sender).Name);
            if (arrAllButtons[IndexButton].Background == Brushes.Red)
                arrAllButtons[IndexButton].Foreground = Brushes.Black;
        }
    }
}