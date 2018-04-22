using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
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
        private List<int> listClickButtons = new List<int>();
        private List<int> listRandomNumbers = new List<int>();
        private List<int> listClickMistakesButtons = new List<int>();

        private Random rnd = new Random();
        private ClassLibraryMBNGBT cl = new ClassLibraryMBNGBT();
        private DispatcherTimer dispatcherTimer = new DispatcherTimer();

        public static byte stage = 1;

        private byte second = 0;
        private byte counterButtonClick = 0;
        private byte secondForBrushNullButtons = 0;


        public SchulteTestTablePage1()
        {
            InitializeComponent();

            ChangeContentButtonRandom();
            startStage.Content = stage;
            dispatcherTimer.Tick += new EventHandler(LabelTimer);
            dispatcherTimer.Start();

        }

        private void button_Click_Result(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SchulteTestResultPage());
        }

        private void LabelTimer(object sender, EventArgs e)
        {
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);

            if (second != 40)
            {
                second++;
                timer.Content = second;
                if (second == 30)
                {
                    timer.Foreground = Brushes.Yellow;
                }
                else
                if (second == 35)
                {
                    timer.Foreground = Brushes.Red;
                }
                else
                if (second == 40)
                {
                    timer.Foreground = Brushes.Black;
                }

                if (secondForBrushNullButtons != 2)
                {
                    secondForBrushNullButtons++;
                }
                else
                {
                    BrushingButtonsNull();
                }
            }
            else
            {
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
                switch (arr[i])
                {
                    case 1:
                        if (brushRedandNull == 1)
                            button1.Background = Brushes.Red;
                        else
                            button1.Background = null;
                        break;
                    case 2:
                        if (brushRedandNull == 1)
                            button2.Background = Brushes.Red;
                        else
                            button2.Background = null;
                        break;
                    case 3:
                        if (brushRedandNull == 1)
                            button3.Background = Brushes.Red;
                        else
                            button3.Background = null;
                        break;
                    case 4:
                        if (brushRedandNull == 1)
                            button4.Background = Brushes.Red;
                        else
                            button4.Background = null;
                        break;
                    case 5:
                        if (brushRedandNull == 1)
                            button5.Background = Brushes.Red;
                        else
                            button5.Background = null;
                        break;
                    case 6:
                        if (brushRedandNull == 1)
                            button6.Background = Brushes.Red;
                        else
                            button6.Background = null;
                        break;
                    case 7:
                        if (brushRedandNull == 1)
                            button7.Background = Brushes.Red;
                        else
                            button7.Background = null;
                        break;
                    case 8:
                        if (brushRedandNull == 1)
                            button8.Background = Brushes.Red;
                        else
                            button8.Background = null;
                        break;
                    case 9:
                        if (brushRedandNull == 1)
                            button9.Background = Brushes.Red;
                        else
                            button9.Background = null;
                        break;
                    case 10:
                        if (brushRedandNull == 1)
                            button10.Background = Brushes.Red;
                        else
                            button10.Background = null;
                        break;
                    case 11:
                        if (brushRedandNull == 1)
                            button11.Background = Brushes.Red;
                        else
                            button11.Background = null;
                        break;
                    case 12:
                        if (brushRedandNull == 1)
                            button12.Background = Brushes.Red;
                        else
                            button12.Background = null;
                        break;
                    case 13:
                        if (brushRedandNull == 1)
                            button13.Background = Brushes.Red;
                        else
                            button13.Background = null;
                        break;
                    case 14:
                        if (brushRedandNull == 1)
                            button14.Background = Brushes.Red;
                        else
                            button14.Background = null;
                        break;
                    case 15:
                        if (brushRedandNull == 1)
                            button15.Background = Brushes.Red;
                        else
                            button15.Background = null;
                        break;
                    case 16:
                        if (brushRedandNull == 1)
                            button16.Background = Brushes.Red;
                        else
                            button16.Background = null;
                        break;
                    case 17:
                        if (brushRedandNull == 1)
                            button17.Background = Brushes.Red;
                        else
                            button17.Background = null;
                        break;
                    case 18:
                        if (brushRedandNull == 1)
                            button18.Background = Brushes.Red;
                        else
                            button18.Background = null;
                        break;
                    case 19:
                        if (brushRedandNull == 1)
                            button19.Background = Brushes.Red;
                        else
                            button19.Background = null;
                        break;
                    case 20:
                        if (brushRedandNull == 1)
                            button20.Background = Brushes.Red;
                        else
                            button20.Background = null;
                        break;
                    case 21:
                        if (brushRedandNull == 1)
                            button21.Background = Brushes.Red;
                        else
                            button21.Background = null;
                        break;
                    case 22:
                        if (brushRedandNull == 1)
                            button22.Background = Brushes.Red;
                        else
                            button22.Background = null;
                        break;
                    case 23:
                        if (brushRedandNull == 1)
                            button23.Background = Brushes.Red;
                        else
                            button23.Background = null;
                        break;
                    case 24:
                        if (brushRedandNull == 1)
                            button24.Background = Brushes.Red;
                        else
                            button24.Background = null;
                        break;
                    case 25:
                        if (brushRedandNull == 1)
                            button25.Background = Brushes.Red;
                        else
                            button25.Background = null;
                        break;
                }
            }
        }

        private void ChangeContentButtonRandom()
        {
            int temp = 0;
            for (int i = 1; i <= 25; i++)
            {
                temp = rnd.Next(1, 26);
                if (listRandomNumbers.Count == 0 || !cl.SerchMatchingNumberInArr(listRandomNumbers.ToArray(), temp))
                {
                    listRandomNumbers.Add(temp);

                    switch (i)
                    {
                        case 1:
                            button1.Content = temp;
                            break;
                        case 2:
                            button2.Content = temp;
                            break;
                        case 3:
                            button3.Content = temp;
                            break;
                        case 4:
                            button4.Content = temp;
                            break;
                        case 5:
                            button5.Content = temp;
                            break;
                        case 6:
                            button6.Content = temp;
                            break;
                        case 7:
                            button7.Content = temp;
                            break;
                        case 8:
                            button8.Content = temp;
                            break;
                        case 9:
                            button9.Content = temp;
                            break;
                        case 10:
                            button10.Content = temp;
                            break;
                        case 11:
                            button11.Content = temp;
                            break;
                        case 12:
                            button12.Content = temp;
                            break;
                        case 13:
                            button13.Content = temp;
                            break;
                        case 14:
                            button14.Content = temp;
                            break;
                        case 15:
                            button15.Content = temp;
                            break;
                        case 16:
                            button16.Content = temp;
                            break;
                        case 17:
                            button17.Content = temp;
                            break;
                        case 18:
                            button18.Content = temp;
                            break;
                        case 19:
                            button19.Content = temp;
                            break;
                        case 20:
                            button20.Content = temp;
                            break;
                        case 21:
                            button21.Content = temp;
                            break;
                        case 22:
                            button22.Content = temp;
                            break;
                        case 23:
                            button23.Content = temp;
                            break;
                        case 24:
                            button24.Content = temp;
                            break;
                        case 25:
                            button25.Content = temp;
                            break;
                    }
                }
                else
                {
                    i--;
                }
            }
        }

        private void FinalStage()
        {
            if (counterButtonClick == 25)
            {
                stage++;
                dispatcherTimer.Stop();
                if (stage != 6)
                {
                    NavigationService.Navigate(new SchulteTestTablePage1());
                }
                else
                {
                    NavigationService.Navigate(new SchulteTestResultPage());
                }
            }
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button1.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listClickButtons.Add(1);
            }
            else
            if (counterButtonClick != Convert.ToByte(button1.Content))
            {
                button1.Background = Brushes.Red;
                listClickMistakesButtons.Add(1);
                secondForBrushNullButtons = 0;
            }
            FinalStage();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button2.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listClickButtons.Add(2);
            }
            else
           if (counterButtonClick != Convert.ToByte(button2.Content))
            {
                button2.Background = Brushes.Red;
                listClickMistakesButtons.Add(2);
                secondForBrushNullButtons = 0;
            }
            FinalStage();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button3.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listClickButtons.Add(3);
            }
            else
               if (counterButtonClick != Convert.ToByte(button3.Content))
            {
                button3.Background = Brushes.Red;
                listClickMistakesButtons.Add(3);
                secondForBrushNullButtons = 0;
            }
            FinalStage();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button4.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listClickButtons.Add(4);
            }
            else
             if (counterButtonClick != Convert.ToByte(button4.Content))
            {
                button4.Background = Brushes.Red;
                listClickMistakesButtons.Add(4);
                secondForBrushNullButtons = 0;
            }
            FinalStage();
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button5.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listClickButtons.Add(5);
            }
            else
            if (counterButtonClick != Convert.ToByte(button5.Content))
            {
                button5.Background = Brushes.Red;
                listClickMistakesButtons.Add(5);
                secondForBrushNullButtons = 0;
            }
            FinalStage();
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button6.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listClickButtons.Add(6);
            }
            else
           if (counterButtonClick != Convert.ToByte(button6.Content))
            {
                button6.Background = Brushes.Red;
                listClickMistakesButtons.Add(6);
                secondForBrushNullButtons = 0;
            }
            FinalStage();
        }

        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button7.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listClickButtons.Add(7);
            }
            else
            if (counterButtonClick != Convert.ToByte(button7.Content))
            {
                button7.Background = Brushes.Red;
                listClickMistakesButtons.Add(7);
                secondForBrushNullButtons = 0;
            }
            FinalStage();
        }

        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button8.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listClickButtons.Add(8);
            }
            else
            if (counterButtonClick != Convert.ToByte(button8.Content))
            {
                button8.Background = Brushes.Red;
                listClickMistakesButtons.Add(8);
                secondForBrushNullButtons = 0;
            }
            FinalStage();
        }

        private void Button_Click9(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button9.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listClickButtons.Add(9);
            }
            else
            if (counterButtonClick != Convert.ToByte(button9.Content))
            {
                button9.Background = Brushes.Red;
                listClickMistakesButtons.Add(9);
                secondForBrushNullButtons = 0;
            }
            FinalStage();
        }

        private void Button_Click10(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button10.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listClickButtons.Add(10);
            }
            else
             if (counterButtonClick != Convert.ToByte(button10.Content))
            {
                button10.Background = Brushes.Red;
                listClickMistakesButtons.Add(10);
                secondForBrushNullButtons = 0;
            }
            FinalStage();
        }

        private void Button_Click11(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button11.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listClickButtons.Add(11);
            }
            else
           if (counterButtonClick != Convert.ToByte(button11.Content))
            {
                button11.Background = Brushes.Red;
                listClickMistakesButtons.Add(11);
                secondForBrushNullButtons = 0;
            }
            FinalStage();
        }

        private void Button_Click12(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button12.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listClickButtons.Add(12);
            }
            else
           if (counterButtonClick != Convert.ToByte(button12.Content))
            {
                button12.Background = Brushes.Red;
                listClickMistakesButtons.Add(12);
                secondForBrushNullButtons = 0;
            }
            FinalStage();
        }

        private void Button_Click13(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button13.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listClickButtons.Add(13);
            }
            else
            if (counterButtonClick != Convert.ToByte(button13.Content))
            {
                button13.Background = Brushes.Red;
                listClickMistakesButtons.Add(13);
                secondForBrushNullButtons = 0;
            }
            FinalStage();
        }

        private void Button_Click14(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button14.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listClickButtons.Add(14);
            }
            else
             if (counterButtonClick != Convert.ToByte(button14.Content))
            {
                button14.Background = Brushes.Red;
                listClickMistakesButtons.Add(14);
                secondForBrushNullButtons = 0;
            }
            FinalStage();
        }

        private void Button_Click15(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button15.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listClickButtons.Add(15);
            }
            else
            if (counterButtonClick != Convert.ToByte(button15.Content))
            {
                button15.Background = Brushes.Red;
                listClickMistakesButtons.Add(15);
                secondForBrushNullButtons = 0;
            }
            FinalStage();
        }

        private void Button_Click16(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button16.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listClickButtons.Add(16);
            }
            else
             if (counterButtonClick != Convert.ToByte(button16.Content))
            {
                button16.Background = Brushes.Red;
                listClickMistakesButtons.Add(16);
                secondForBrushNullButtons = 0;
            }
            FinalStage();
        }

        private void Button_Click17(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button17.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listClickButtons.Add(17);
            }
            else
             if (counterButtonClick != Convert.ToByte(button17.Content))
            {
                button17.Background = Brushes.Red;
                listClickMistakesButtons.Add(17);
                secondForBrushNullButtons = 0;
            }
            FinalStage();
        }

        private void Button_Click18(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button18.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listClickButtons.Add(18);
            }
            else
             if (counterButtonClick != Convert.ToByte(button18.Content))
            {
                button18.Background = Brushes.Red;
                listClickMistakesButtons.Add(18);
                secondForBrushNullButtons = 0;
            }
            FinalStage();
        }

        private void Button_Click19(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button19.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listClickButtons.Add(19);
            }
            else
            if (counterButtonClick != Convert.ToByte(button19.Content))
            {
                button19.Background = Brushes.Red;
                listClickMistakesButtons.Add(19);
                secondForBrushNullButtons = 0;
            }
            FinalStage();
        }

        private void Button_Click20(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button20.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listClickButtons.Add(20);
            }
            else
            if (counterButtonClick != Convert.ToByte(button20.Content))
            {
                button20.Background = Brushes.Red;
                listClickMistakesButtons.Add(20);
                secondForBrushNullButtons = 0;
            }
            FinalStage();
        }

        private void Button_Click21(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button21.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listClickButtons.Add(21);
            }
            else
           if (counterButtonClick != Convert.ToByte(button21.Content))
            {
                button21.Background = Brushes.Red;
                listClickMistakesButtons.Add(21);
                secondForBrushNullButtons = 0;
            }
            FinalStage();
        }

        private void Button_Click22(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button22.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listClickButtons.Add(22);
            }
            else
              if (counterButtonClick != Convert.ToByte(button22.Content))
            {
                button22.Background = Brushes.Red;
                listClickMistakesButtons.Add(22);
                secondForBrushNullButtons = 0;
            }
            FinalStage();
        }

        private void Button_Click23(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button23.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listClickButtons.Add(23);
            }
            else
            if (counterButtonClick != Convert.ToByte(button23.Content))
            {
                button23.Background = Brushes.Red;
                listClickMistakesButtons.Add(23);
                secondForBrushNullButtons = 0;
            }
            FinalStage();
        }

        private void Button_Click24(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button24.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listClickButtons.Add(24);
            }
            else
            if (counterButtonClick != Convert.ToByte(button24.Content))
            {
                button24.Background = Brushes.Red;
                listClickMistakesButtons.Add(24);
                secondForBrushNullButtons = 0;
            }
            FinalStage();
        }

        private void Button_Click25(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button25.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listClickButtons.Add(25);
            }
            else
            if (counterButtonClick != Convert.ToByte(button25.Content))
            {
                button25.Background = Brushes.Red;
                listClickMistakesButtons.Add(25);
                secondForBrushNullButtons = 0;
            }
            FinalStage();
        }
    }
}
