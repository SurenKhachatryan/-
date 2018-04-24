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

namespace M.B.N.G.B.T.Schulte_Test
{
    /// <summary>
    /// Логика взаимодействия для SchulteTestTablePage3.xaml
    /// </summary>
    public partial class SchulteTestTablePage3 : Page
    {
        private List<int> lsRndDigite = new List<int>();
        private List<int> listClickMistakesButtons = new List<int>();
        private List<int> listIntervalClickButtons = new List<int>();

        private Random rnd = new Random();
        private ClassLibraryMBNGBT cl = new ClassLibraryMBNGBT();
        private DispatcherTimer dispatcherTimer = new DispatcherTimer();

        public static byte stage = 1;

        private byte second = 0;
        private byte counterButtonClick;
        private byte secondForBrushNullButtons = 0;


        public SchulteTestTablePage3()
        {
            InitializeComponent();

            dispatcherTimer.Tick += new EventHandler(LabelTimer);
            ChangeContentButtonRandom();
            startStage.Content = stage;
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

        private void button_Click_Result(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SchulteTestResultPage());
        }

        private void ChangeContentButtonRandom()
        {
            int temp = 0;
            for (int i = 1; i <= 25; i++)
            {
                temp = rnd.Next(1, 26);
                if (lsRndDigite.Count == 0 || !cl.SerchMatchingNumberInArr(lsRndDigite.ToArray(), temp))
                {
                    lsRndDigite.Add(temp);

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


        private void BrushingButtonsNull()
        {
            timer.Foreground = Brushes.White;

            for (int i = 0; i < listClickMistakesButtons.Count; i++)
            {
                switch (listClickMistakesButtons[i])
                {
                    case 1:
                        button1.Background = null;
                        break;
                    case 2:
                        button2.Background = null;
                        break;
                    case 3:
                        button3.Background = null;
                        break;
                    case 4:
                        button4.Background = null;
                        break;
                    case 5:
                        button5.Background = null;
                        break;
                    case 6:
                        button6.Background = null;
                        break;
                    case 7:
                        button7.Background = null;
                        break;
                    case 8:
                        button8.Background = null;
                        break;
                    case 9:
                        button9.Background = null;
                        break;
                    case 10:
                        button10.Background = null;
                        break;
                    case 11:
                        button11.Background = null;
                        break;
                    case 12:
                        button12.Background = null;
                        break;
                    case 13:
                        button13.Background = null;
                        break;
                    case 14:
                        button14.Background = null;
                        break;
                    case 15:
                        button15.Background = null;
                        break;
                    case 16:
                        button16.Background = null;
                        break;
                    case 17:
                        button17.Background = null;
                        break;
                    case 18:
                        button18.Background = null;
                        break;
                    case 19:
                        button19.Background = null;
                        break;
                    case 20:
                        button20.Background = null;
                        break;
                    case 21:
                        button21.Background = null;
                        break;
                    case 22:
                        button22.Background = null;
                        break;
                    case 23:
                        button23.Background = null;
                        break;
                    case 24:
                        button24.Background = null;
                        break;
                    case 25:
                        button25.Background = null;
                        break;
                }
            }
            listClickMistakesButtons.Clear();
        }

        private void FinalStage()
        {
            if (counterButtonClick == 25)
            {
                stage++;
                if (stage != 6)
                {
                    NavigationService.Navigate(new SchulteTestTablePage3());
                }
                else
                {
                    NavigationService.Navigate(new SchulteTestResultPage());
                }
                dispatcherTimer.Stop();
            }
        }


        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button1.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listIntervalClickButtons.Add(second);
                second = 0;
                timer.Content = "00";
            }
            else
            if (counterButtonClick != Convert.ToByte(button1.Content))
            {
                timer.Foreground = Brushes.Red;
                button1.Background = Brushes.Red;
                secondForBrushNullButtons = 0;
                listClickMistakesButtons.Add(1);
            }
            FinalStage();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button2.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listIntervalClickButtons.Add(second);
                second = 0;
                timer.Content = "00";
            }
            else
            if (counterButtonClick != Convert.ToByte(button2.Content))
            {
                timer.Foreground = Brushes.Red;
                button2.Background = Brushes.Red;
                secondForBrushNullButtons = 0;
                listClickMistakesButtons.Add(2);
            }
            FinalStage();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button3.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listIntervalClickButtons.Add(second);
                second = 0;
                timer.Content = "00";
            }
            else
            if (counterButtonClick != Convert.ToByte(button3.Content))
            {
                timer.Foreground = Brushes.Red;
                button3.Background = Brushes.Red;
                secondForBrushNullButtons = 0;
                listClickMistakesButtons.Add(3);
            }
            FinalStage();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button4.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listIntervalClickButtons.Add(second);
                second = 0;
                timer.Content = "00";
            }
            else
            if (counterButtonClick != Convert.ToByte(button4.Content))
            {
                timer.Foreground = Brushes.Red;
                button4.Background = Brushes.Red;
                secondForBrushNullButtons = 0;
                listClickMistakesButtons.Add(4);
            }
            FinalStage();
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button5.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listIntervalClickButtons.Add(second);
                second = 0;
                timer.Content = "00";
            }
            else
            if (counterButtonClick != Convert.ToByte(button5.Content))
            {
                timer.Foreground = Brushes.Red;
                button5.Background = Brushes.Red;
                secondForBrushNullButtons = 0;
                listClickMistakesButtons.Add(5);
            }
            FinalStage();
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button6.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listIntervalClickButtons.Add(second);
                second = 0;
                timer.Content = "00";
            }
            else
            if (counterButtonClick != Convert.ToByte(button6.Content))
            {
                timer.Foreground = Brushes.Red;
                button6.Background = Brushes.Red;
                secondForBrushNullButtons = 0;
                listClickMistakesButtons.Add(6);
            }
            FinalStage();
        }

        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button7.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listIntervalClickButtons.Add(second);
                second = 0;
                timer.Content = "00";
            }
            else
            if (counterButtonClick != Convert.ToByte(button7.Content))
            {
                timer.Foreground = Brushes.Red;
                button7.Background = Brushes.Red;
                secondForBrushNullButtons = 0;
                listClickMistakesButtons.Add(7);
            }
            FinalStage();
        }

        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button8.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listIntervalClickButtons.Add(second);
                second = 0;
                timer.Content = "00";
            }
            else
            if (counterButtonClick != Convert.ToByte(button8.Content))
            {
                timer.Foreground = Brushes.Red;
                button8.Background = Brushes.Red;
                secondForBrushNullButtons = 0;
                listClickMistakesButtons.Add(8);
            }
            FinalStage();
        }

        private void Button_Click9(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button9.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listIntervalClickButtons.Add(second);
                second = 0;
                timer.Content = "00";
            }
            else
            if (counterButtonClick != Convert.ToByte(button9.Content))
            {
                timer.Foreground = Brushes.Red;
                button9.Background = Brushes.Red;
                secondForBrushNullButtons = 0;
                listClickMistakesButtons.Add(9);
            }
            FinalStage();
        }

        private void Button_Click10(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button10.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listIntervalClickButtons.Add(second);
                second = 0;
                timer.Content = "00";
            }
            else
            if (counterButtonClick != Convert.ToByte(button10.Content))
            {
                timer.Foreground = Brushes.Red;
                button10.Background = Brushes.Red;
                secondForBrushNullButtons = 0;
                listClickMistakesButtons.Add(10);
            }
            FinalStage();
        }

        private void Button_Click11(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button11.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listIntervalClickButtons.Add(second);
                second = 0;
                timer.Content = "00";
            }
            else
            if (counterButtonClick != Convert.ToByte(button11.Content))
            {
                timer.Foreground = Brushes.Red;
                button11.Background = Brushes.Red;
                secondForBrushNullButtons = 0;
                listClickMistakesButtons.Add(11);
            }
            FinalStage();
        }

        private void Button_Click12(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button12.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listIntervalClickButtons.Add(second);
                second = 0;
                timer.Content = "00";
            }
            else
            if (counterButtonClick != Convert.ToByte(button12.Content))
            {
                timer.Foreground = Brushes.Red;
                button12.Background = Brushes.Red;
                secondForBrushNullButtons = 0;
                listClickMistakesButtons.Add(12);
            }
            FinalStage();
        }

        private void Button_Click13(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button13.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listIntervalClickButtons.Add(second);
                second = 0;
                timer.Content = "00";
            }
            else
            if (counterButtonClick != Convert.ToByte(button13.Content))
            {
                timer.Foreground = Brushes.Red;
                button13.Background = Brushes.Red;
                secondForBrushNullButtons = 0;
                listClickMistakesButtons.Add(13);
            }
            FinalStage();
        }

        private void Button_Click14(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button14.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listIntervalClickButtons.Add(second);
                second = 0;
                timer.Content = "00";
            }
            else
            if (counterButtonClick != Convert.ToByte(button14.Content))
            {
                timer.Foreground = Brushes.Red;
                button14.Background = Brushes.Red;
                secondForBrushNullButtons = 0;
                listClickMistakesButtons.Add(14);
            }
            FinalStage();
        }

        private void Button_Click15(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button15.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listIntervalClickButtons.Add(second);
                second = 0;
                timer.Content = "00";
            }
            else
            if (counterButtonClick != Convert.ToByte(button15.Content))
            {
                timer.Foreground = Brushes.Red;
                button15.Background = Brushes.Red;
                secondForBrushNullButtons = 0;
                listClickMistakesButtons.Add(15);
            }
            FinalStage();
        }

        private void Button_Click16(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button16.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listIntervalClickButtons.Add(second);
                second = 0;
                timer.Content = "00";
            }
            else
            if (counterButtonClick != Convert.ToByte(button16.Content))
            {
                timer.Foreground = Brushes.Red;
                button16.Background = Brushes.Red;
                secondForBrushNullButtons = 0;
                listClickMistakesButtons.Add(16);
            }
            FinalStage();
        }

        private void Button_Click17(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button17.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listIntervalClickButtons.Add(second);
                second = 0;
                timer.Content = "00";
            }
            else
            if (counterButtonClick != Convert.ToByte(button17.Content))
            {
                timer.Foreground = Brushes.Red;
                button17.Background = Brushes.Red;
                secondForBrushNullButtons = 0;
                listClickMistakesButtons.Add(17);
            }
            FinalStage();
        }

        private void Button_Click18(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button18.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listIntervalClickButtons.Add(second);
                second = 0;
                timer.Content = "00";
            }
            else
            if (counterButtonClick != Convert.ToByte(button18.Content))
            {
                timer.Foreground = Brushes.Red;
                button18.Background = Brushes.Red;
                secondForBrushNullButtons = 0;
                listClickMistakesButtons.Add(18);
            }
            FinalStage();
        }

        private void Button_Click19(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button19.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listIntervalClickButtons.Add(second);
                second = 0;
                timer.Content = "00";
            }
            else
            if (counterButtonClick != Convert.ToByte(button19.Content))
            {
                timer.Foreground = Brushes.Red;
                button19.Background = Brushes.Red;
                secondForBrushNullButtons = 0;
                listClickMistakesButtons.Add(19);
            }
            FinalStage();
        }

        private void Button_Click20(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button20.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listIntervalClickButtons.Add(second);
                second = 0;
                timer.Content = "00";
            }
            else
            if (counterButtonClick != Convert.ToByte(button20.Content))
            {
                timer.Foreground = Brushes.Red;
                button20.Background = Brushes.Red;
                secondForBrushNullButtons = 0;
                listClickMistakesButtons.Add(20);
            }
            FinalStage();
        }

        private void Button_Click21(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button21.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listIntervalClickButtons.Add(second);
                second = 0;
                timer.Content = "00";
            }
            else
            if (counterButtonClick != Convert.ToByte(button21.Content))
            {
                timer.Foreground = Brushes.Red;
                button21.Background = Brushes.Red;
                secondForBrushNullButtons = 0;
                listClickMistakesButtons.Add(21);
            }
            FinalStage();
        }

        private void Button_Click22(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button22.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listIntervalClickButtons.Add(second);
                second = 0;
                timer.Content = "00";
            }
            else
            if (counterButtonClick != Convert.ToByte(button22.Content))
            {
                timer.Foreground = Brushes.Red;
                button22.Background = Brushes.Red;
                secondForBrushNullButtons = 0;
                listClickMistakesButtons.Add(22);
            }
            FinalStage();
        }

        private void Button_Click23(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button23.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listIntervalClickButtons.Add(second);
                second = 0;
                timer.Content = "00";
            }
            else
            if (counterButtonClick != Convert.ToByte(button23.Content))
            {
                timer.Foreground = Brushes.Red;
                button23.Background = Brushes.Red;
                secondForBrushNullButtons = 0;
                listClickMistakesButtons.Add(23);
            }
            FinalStage();
        }

        private void Button_Click24(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button24.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listIntervalClickButtons.Add(second);
                second = 0;
                timer.Content = "00";
            }
            else
            if (counterButtonClick != Convert.ToByte(button24.Content))
            {
                timer.Foreground = Brushes.Red;
                button24.Background = Brushes.Red;
                secondForBrushNullButtons = 0;
                listClickMistakesButtons.Add(24);
            }
            FinalStage();
        }

        private void Button_Click25(object sender, RoutedEventArgs e)
        {
            if (counterButtonClick + 1 == Convert.ToByte(button25.Content))
            {
                counterButtonClick++;
                BrushingButtonsNull();
                listIntervalClickButtons.Add(second);
                second = 0;
                timer.Content = "00";
            }
            else
            if (counterButtonClick != Convert.ToByte(button25.Content))
            {
                timer.Foreground = Brushes.Red;
                button25.Background = Brushes.Red;
                secondForBrushNullButtons = 0;
                listClickMistakesButtons.Add(25);
            }
            FinalStage();
        }
    }
}
