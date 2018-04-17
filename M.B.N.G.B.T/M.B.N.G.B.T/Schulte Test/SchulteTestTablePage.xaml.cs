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
using ClassLibrary;

namespace M.B.N.G.B.T.Schulte_Test
{
    /// <summary>
    /// Логика взаимодействия для SchulteTablePage.xaml
    /// </summary>
    public partial class SchulteTablePage : Page
    {
        private List<int> lsRndDigite = new List<int>();
        private Dictionary<int, int> listbutton = new Dictionary<int, int>();
        private List<int> lsIntervalPressButtons = new List<int>();
        private Random rnd = new Random();
        private ClassLibraryMBNGBT cl = new ClassLibraryMBNGBT();
        private DispatcherTimer dispatcherTimer = new DispatcherTimer();

        private byte second = 0;
        private byte equalsDigit = 0;
        private byte buttonContent = 0;
        private bool door = true;
        private static byte stage = 1;
        private bool buttonsIsEnabled = true;

        public SchulteTablePage()
        {
            

            InitializeComponent();
            timer.Visibility = Visibility.Collapsed;
            ChangeContentButtonRandom();
            startStage.Content = stage;

            dispatcherTimer.Tick += new EventHandler(LabelTimer);

            if (SchulteTestRulePage.clause == 1)
            {
                timer.Visibility = Visibility.Visible;
                dispatcherTimer.Start();
            }
            else
            if (SchulteTestRulePage.clause == 3)
            {
                dispatcherTimer.Start();
            }
        }

        private void button_Click_Result(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SchulteResultPage());
            stage = 1;
        }

        private void LabelTimer(object sender, EventArgs e)
        {
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);

            if (SchulteTestRulePage.clause == 1)
            {
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
                }
                else
                {
                    dispatcherTimer.Stop();
                }
            }
            else
            if (SchulteTestRulePage.clause == 3)
            {
                second++;
            }
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

        private void AddlistIntervalPressButtons()
        {
            if (SchulteTestRulePage.clause == 3)
            {
                lsIntervalPressButtons.Add(second);
                second = 0;
            }
            else
            if (SchulteTestRulePage.clause == 1 && door)
            {
                equalsDigit++;
                if (equalsDigit != buttonContent)
                {
                    dispatcherTimer.Stop();
                    NavigationService.Navigate(new SchulteResultPage());
                    stage = 1;
                }
                else
                if (equalsDigit == 25)
                {
                    stage++;
                    dispatcherTimer.Stop();
                    if (stage != 6)
                    {
                        NavigationService.Navigate(new SchulteTablePage());
                    }
                }
            }
            door = true;
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button1.Content) && SchulteTestRulePage.clause == 1)
                {
                    buttonContent = Convert.ToByte(button1.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button1.Content))
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
                listbutton.Add(1, Convert.ToInt32(button1.Content));
            }
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button2.Content) && SchulteTestRulePage.clause == 1)
                {
                    buttonContent = Convert.ToByte(button2.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button2.Content) && SchulteTestRulePage.clause == 1)
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
                listbutton.Add(2, Convert.ToInt32(button2.Content));
            }
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button3.Content) && SchulteTestRulePage.clause == 1)
                {
                    buttonContent = Convert.ToByte(button3.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button3.Content) && SchulteTestRulePage.clause == 1)
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
                listbutton.Add(3, Convert.ToInt32(button3.Content));
            }
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button4.Content) && SchulteTestRulePage.clause == 1)
                {
                    buttonContent = Convert.ToByte(button4.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button4.Content) && SchulteTestRulePage.clause == 1)
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
                listbutton.Add(4, Convert.ToInt32(button4.Content));
            }
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button5.Content) && SchulteTestRulePage.clause == 1)
                {
                    buttonContent = Convert.ToByte(button5.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button5.Content) && SchulteTestRulePage.clause == 1)
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
                listbutton.Add(5, Convert.ToInt32(button5.Content));
            }
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button6.Content) && SchulteTestRulePage.clause == 1)
                {
                    buttonContent = Convert.ToByte(button6.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button6.Content) && SchulteTestRulePage.clause == 1)
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
                listbutton.Add(6, Convert.ToInt32(button6.Content));
            }
        }

        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button7.Content) && SchulteTestRulePage.clause == 1)
                {
                    buttonContent = Convert.ToByte(button7.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button7.Content) && SchulteTestRulePage.clause == 1)
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
                listbutton.Add(7, Convert.ToInt32(button7.Content));
            }
        }

        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button8.Content) && SchulteTestRulePage.clause == 1)
                {
                    buttonContent = Convert.ToByte(button8.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button8.Content) && SchulteTestRulePage.clause == 1)
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
                listbutton.Add(8, Convert.ToInt32(button8.Content));
            }
        }

        private void Button_Click9(object sender, RoutedEventArgs e)
        {
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button9.Content) && SchulteTestRulePage.clause == 1)
                {
                    buttonContent = Convert.ToByte(button9.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button9.Content) && SchulteTestRulePage.clause == 1)
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
                listbutton.Add(9, Convert.ToInt32(button9.Content));
            }
        }

        private void Button_Click10(object sender, RoutedEventArgs e)
        {
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button10.Content) && SchulteTestRulePage.clause == 1)
                {
                    buttonContent = Convert.ToByte(button10.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button10.Content) && SchulteTestRulePage.clause == 1)
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
                listbutton.Add(10, Convert.ToInt32(button10.Content));
            }
        }

        private void Button_Click11(object sender, RoutedEventArgs e)
        {
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button11.Content) && SchulteTestRulePage.clause == 1)
                {
                    buttonContent = Convert.ToByte(button11.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button11.Content) && SchulteTestRulePage.clause == 1)
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
                listbutton.Add(11, Convert.ToInt32(button11.Content));
            }
        }

        private void Button_Click12(object sender, RoutedEventArgs e)
        {
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button12.Content) && SchulteTestRulePage.clause == 1)
                {
                    buttonContent = Convert.ToByte(button12.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button12.Content) && SchulteTestRulePage.clause == 1)
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
                listbutton.Add(12, Convert.ToInt32(button12.Content));
            }
        }

        private void Button_Click13(object sender, RoutedEventArgs e)
        {
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button13.Content) && SchulteTestRulePage.clause == 1)
                {
                    buttonContent = Convert.ToByte(button13.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button13.Content) && SchulteTestRulePage.clause == 1)
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
                listbutton.Add(13, Convert.ToInt32(button13.Content));
            }
        }

        private void Button_Click14(object sender, RoutedEventArgs e)
        {
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button14.Content) && SchulteTestRulePage.clause == 1)
                {
                    buttonContent = Convert.ToByte(button14.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button14.Content) && SchulteTestRulePage.clause == 1)
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
                listbutton.Add(14, Convert.ToInt32(button14.Content));
            }
        }

        private void Button_Click15(object sender, RoutedEventArgs e)
        {
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button15.Content) && SchulteTestRulePage.clause == 1)
                {
                    buttonContent = Convert.ToByte(button15.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button15.Content) && SchulteTestRulePage.clause == 1)
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
                listbutton.Add(15, Convert.ToInt32(button15.Content));
            }
        }

        private void Button_Click16(object sender, RoutedEventArgs e)
        {
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button16.Content) && SchulteTestRulePage.clause == 1)
                {
                    buttonContent = Convert.ToByte(button16.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button16.Content) && SchulteTestRulePage.clause == 1)
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
                listbutton.Add(16, Convert.ToInt32(button16.Content));
            }
        }

        private void Button_Click17(object sender, RoutedEventArgs e)
        {
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button17.Content) && SchulteTestRulePage.clause == 1)
                {
                    buttonContent = Convert.ToByte(button17.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button17.Content) && SchulteTestRulePage.clause == 1)
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
                listbutton.Add(17, Convert.ToInt32(button17.Content));
            }
        }

        private void Button_Click18(object sender, RoutedEventArgs e)
        {
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button18.Content) && SchulteTestRulePage.clause == 1)
                {
                    buttonContent = Convert.ToByte(button18.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button18.Content) && SchulteTestRulePage.clause == 1)
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
                listbutton.Add(18, Convert.ToInt32(button18.Content));
            }
        }

        private void Button_Click19(object sender, RoutedEventArgs e)
        {
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button19.Content) && SchulteTestRulePage.clause == 1)
                {
                    buttonContent = Convert.ToByte(button19.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button19.Content) && SchulteTestRulePage.clause == 1)
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
                listbutton.Add(19, Convert.ToInt32(button19.Content));
            }
        }

        private void Button_Click20(object sender, RoutedEventArgs e)
        {
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button20.Content) && SchulteTestRulePage.clause == 1)
                {
                    buttonContent = Convert.ToByte(button20.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button20.Content) && SchulteTestRulePage.clause == 1)
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
                listbutton.Add(20, Convert.ToInt32(button20.Content));
            }
        }

        private void Button_Click21(object sender, RoutedEventArgs e)
        {
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button21.Content) && SchulteTestRulePage.clause == 1)
                {
                    buttonContent = Convert.ToByte(button21.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button21.Content) && SchulteTestRulePage.clause == 1)
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
                listbutton.Add(21, Convert.ToInt32(button21.Content));
            }
        }

        private void Button_Click22(object sender, RoutedEventArgs e)
        {
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button22.Content) && SchulteTestRulePage.clause == 1)
                {
                    buttonContent = Convert.ToByte(button22.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button22.Content) && SchulteTestRulePage.clause == 1)
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
                listbutton.Add(22, Convert.ToInt32(button22.Content));
            }
        }

        private void Button_Click23(object sender, RoutedEventArgs e)
        {
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button23.Content) && SchulteTestRulePage.clause == 1)
                {
                    buttonContent = Convert.ToByte(button23.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button23.Content) && SchulteTestRulePage.clause == 1)
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
                listbutton.Add(23, Convert.ToInt32(button23.Content));
            }
        }

        private void Button_Click24(object sender, RoutedEventArgs e)
        {
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button24.Content) && SchulteTestRulePage.clause == 1)
                {
                    buttonContent = Convert.ToByte(button24.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button24.Content) && SchulteTestRulePage.clause == 1)
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
                listbutton.Add(24, Convert.ToInt32(button24.Content));
            }
        }

        private void Button_Click25(object sender, RoutedEventArgs e)
        {
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button25.Content) && SchulteTestRulePage.clause == 1)
                {
                    buttonContent = Convert.ToByte(button25.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button25.Content) && SchulteTestRulePage.clause == 1)
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
                listbutton.Add(25, Convert.ToInt32(button25.Content));
            }
        }
    }
}
