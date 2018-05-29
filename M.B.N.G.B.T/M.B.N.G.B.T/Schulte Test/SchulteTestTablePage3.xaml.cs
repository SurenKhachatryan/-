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
    /// Логика взаимодействия для SchulteTestTablePage3.xaml
    /// </summary>
    public partial class SchulteTestTablePage3 : Page
    {
        private List<int> listRandomNumbers { get; set; } = new List<int>();
        private List<int> listClickMistakesButtons { get; set; } = new List<int>();
        private List<int> listIntervalClickButtons { get; set; } = new List<int>();
        private Button[] arrAllButtons { get; set; } = new Button[25];

        private Random rnd = new Random();
        private ClassLibraryMBNGBT cl = new ClassLibraryMBNGBT();
        private DispatcherTimer dispatcherTimer = new DispatcherTimer();

        public static byte stage { get; set; } = 1;

        private byte second { get; set; } = 0;
        private byte counterButtonClick { get; set; } = 0;
        private byte secondForBrushNullButtons { get; set; } = 0;
        private int indexButton { get; set; } = 0;

        public SchulteTestTablePage3()
        {
            InitializeComponent();

            dispatcherTimer.Tick += new EventHandler(LabelTimer);
            ChangeContentButtonRandom();
            startStage.Content = $"{stage}/5";
            dispatcherTimer.Start();
        }

        private void LabelTimer(object sender, EventArgs e)
        {

            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            if (second != 60)
            {
                second++;
                if (second < 10)
                    timer.Content = $"0{second}";
                else
                    timer.Content = $"{second}";

                secondForBrushNullButtons++;
                if (secondForBrushNullButtons == 2)
                {
                    BrushingButtonsNull();
                    secondForBrushNullButtons = 0;
                }
            }
            else
            {
                dispatcherTimer.Stop();
                NavigationService.Navigate(new SchulteTestResultPage());
            }
        }

        private void Button_Exit_The_Test_View_Result(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
            NavigationService.Navigate(new SchulteTestResultPage());
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


        private void BrushingButtonsNull()
        {
            for (int i = 0; i < listClickMistakesButtons.Count; i++)
            {
                arrAllButtons[listClickMistakesButtons[i]].Background = (Brush)new BrushConverter().ConvertFrom("#FF567962");
                arrAllButtons[listClickMistakesButtons[i]].Foreground = Brushes.Black;
            }
            timer.Foreground = Brushes.White;
            listClickMistakesButtons.Clear();
        }

        private void FinalStage()
        {
            if (counterButtonClick == 25)
            {
                stage++;
                if (stage != 6)
                    NavigationService.Navigate(new SchulteTestTablePage3());
                else
                    NavigationService.Navigate(new SchulteTestResultPage());

                dispatcherTimer.Stop();
            }
        }


        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            indexButton = GetButtonIndex(((Button)sender).Name);
            if (counterButtonClick + 1 == Convert.ToByte(arrAllButtons[indexButton].Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listIntervalClickButtons.Add(second);
                second = 0;
                timer.Content = "00";
            }
            else
            if (counterButtonClick != Convert.ToByte(arrAllButtons[indexButton].Content))
            {
                timer.Foreground = Brushes.Red;
                arrAllButtons[indexButton].Foreground = Brushes.Red;
                arrAllButtons[indexButton].Background = Brushes.Red;
                secondForBrushNullButtons = 0;
                listClickMistakesButtons.Add(indexButton);
            }
            FinalStage();
        }

        private void button1_MouseEnter(object sender, MouseEventArgs e)
        {
            indexButton = GetButtonIndex(((Button)sender).Name);
            if (arrAllButtons[indexButton].Background == Brushes.Red)
                arrAllButtons[indexButton].Foreground = Brushes.Red;
        }

        private void button1_MouseLeave(object sender, MouseEventArgs e)
        {
            int index = GetButtonIndex(((Button)sender).Name);
            if (arrAllButtons[indexButton].Background == Brushes.Red)
                arrAllButtons[indexButton].Foreground = Brushes.Black;
        }

        private int GetButtonIndex(string buttonName)
        {
            for (int i = 0; i < arrAllButtons.Length; i++)
                if (buttonName == arrAllButtons[i].Name)
                    return i;
            return -1;
        }
    }
}
