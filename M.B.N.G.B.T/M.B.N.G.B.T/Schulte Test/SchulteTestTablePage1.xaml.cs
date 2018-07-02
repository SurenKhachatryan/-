using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Threading;

namespace M.B.N.G.B.T.Schulte_Test
{
    /// <summary>
    /// Логика взаимодействия для SchulteTablePage.xaml
    /// </summary>
    public partial class SchulteTestTablePage1 : Page
    {
        private List<int> listClickButtons { get; set; } = new List<int>();
        private List<int> listRandomNumbers { get; set; } = new List<int>();
        private List<int> listClickMistakesButtons { get; set; } = new List<int>();

        private Button[] arrAllButtons { get; set; } = new Button[25];

        private Random rnd = new Random();
        private ClassLibraryMBNGBT cl = new ClassLibraryMBNGBT();
        private DispatcherTimer dispatcherTimer = new DispatcherTimer();

        public static byte stage { get; set; } = 1;

        private byte Second { get; set; } = 0;
        private byte CounterButtonClick { get; set; } = 0;
        private byte secondForBrushNullButtons { get; set; } = 0;
        private bool IsEnabledButtons { get; set; } = true;
        private bool DoorForChangeColorButtonBackground { get; set; } = false;
        private int IndexButton { get; set; } = 0;

        public SchulteTestTablePage1()
        {
            InitializeComponent();

            ChangeContentButtonRandom();
            startStage.Content = $"{stage}/5";
            dispatcherTimer.Tick += new EventHandler(LabelTimer);
            dispatcherTimer.Start();

        }

        private void Button_Exit_The_Test_View_Result(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SchulteTestResultPage());
        }

        private void LabelTimer(object sender, EventArgs e)
        {
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);

            if (Second != 40)
            {
                Second++;

                if (Second < 10)
                    timer.Content = $"0{Second}";
                else
                    timer.Content = $"{Second}";

                if (Second == 30)
                    timer.Foreground = Brushes.Yellow;
                else
                if (Second == 35)
                    timer.Foreground = Brushes.Red;
                else
                if (Second == 40)
                    timer.Foreground = Brushes.Black;

                secondForBrushNullButtons++;
                if (secondForBrushNullButtons == 2 && DoorForChangeColorButtonBackground)
                    BrushingButtonsNull();
            }
            else
            {
                IsEnabledButtons = false;
                timer.Foreground = Brushes.Red;
                listClickMistakesButtons = cl.SortingAndSerchInArrMissingNumbers(listClickButtons.ToArray(), 25);
                BrushingButtonsRedAndNull(listClickMistakesButtons.ToArray(), 1);
                dispatcherTimer.Stop();
            }
        }
        private void BrushingButtonsNull()
        {
            BrushingButtonsRedAndNull(listClickMistakesButtons.ToArray(), 2);
            secondForBrushNullButtons = 0;
        }

        private void BrushingButtonsRedAndNull(int[] arr, byte brushRedandNull)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                if (brushRedandNull == 1)
                {
                    if (i == IndexButton)
                        arrAllButtons[IndexButton].Foreground = Brushes.Red;

                    arrAllButtons[(arr[i] - 1)].Background = Brushes.Red;
                }
                else
                {
                    arrAllButtons[(arr[i] - 1)].Foreground = Brushes.Black;
                    arrAllButtons[(arr[i] - 1)].Background = (Brush)new BrushConverter().ConvertFrom("#FF567962");
                    DoorForChangeColorButtonBackground = false;
                }
            }
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
                stage++;
                dispatcherTimer.Stop();
                if (stage != 6)
                    NavigationService.Navigate(new SchulteTestTablePage1());
                else
                    NavigationService.Navigate(new SchulteTestResultPage());
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
