using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
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

        private byte Second { get; set; } = 0;
        private byte CounterButtonClick { get; set; } = 0;
        private byte secondForBrushNullButtons { get; set; } = 0;
        private bool IsEnabledButtons { get; set; } = true;
        private bool DoorForChangeColorButtonBackground { get; set; } = false;
        private int IndexButton { get; set; } = 0;

        public WalterSchulteTestTablePage()
        {
            if (Stage == 1)
                ArrAllStageSecond = new int[5];

            InitializeComponent();
            ChangeContentButtonRandom();
            startStage.Content = $"{Stage}/5";
            dispatcherTimer.Tick += new EventHandler(LabelTimer);
            dispatcherTimer.Start();
        }
        private void Button_Exit_The_Test_View_Result(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new WalterSchulteTestResultPage());
        }

        private void LabelTimer(object sender, EventArgs e)
        {
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            if (Second == 300)
            {
                NavigationService.Navigate(new WalterSchulteTestResultPage());
                dispatcherTimer.Stop();
            }

            if (Second < 10)
                timer.Content = $"0{Second++}";
            else
                timer.Content = $"{Second++}";


            if (secondForBrushNullButtons == 2 && DoorForChangeColorButtonBackground)
                BrushingButtonsNull();
            secondForBrushNullButtons++;
        }

        private void BrushingButtonsNull()
        {
            BrushingButtonsColorDefult(listClickMistakesButtons.ToArray());
            secondForBrushNullButtons = 0;
        }

        private void BrushingButtonsColorDefult(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arrAllButtons[(arr[i] - 1)].Foreground = Brushes.Black;
                arrAllButtons[(arr[i] - 1)].Background = Brushes.White;
            }
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

        private void FinalStage()
        {
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

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            if (IsEnabledButtons)
            {
                IndexButton = GetButtonIndex(((Button)sender).Name);
                if (CounterButtonClick + 1 == Convert.ToByte(arrAllButtons[IndexButton].Content))
                {
                    CounterButtonClick++;
                    BrushingButtonsNull();
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
                FinalStage();
            }
        }

        private int GetButtonIndex(string buttonName)
        {
            for (int i = 0; i < arrAllButtons.Length; i++)
                if (buttonName == arrAllButtons[i].Name)
                    return i;
            return -1;
        }

        private void button1_MouseEnter(object sender, MouseEventArgs e)
        {
            IndexButton = GetButtonIndex(((Button)sender).Name);
            if (arrAllButtons[IndexButton].Background == Brushes.Red)
                arrAllButtons[IndexButton].Foreground = Brushes.Red;
        }

        private void button1_MouseLeave(object sender, MouseEventArgs e)
        {
            IndexButton = GetButtonIndex(((Button)sender).Name);
            if (arrAllButtons[IndexButton].Background == Brushes.Red)
                arrAllButtons[IndexButton].Foreground = Brushes.Black;
        }
    }
}