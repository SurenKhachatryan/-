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
    public partial class SchulteTestTablePage1 : Page
    {
        private List<int> lsRndDigite = new List<int>();
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
        private byte buttonNumber = 0;

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
            NavigationService.Navigate(new SchulteResultPage());
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
            }
            else
            {
                equalsDigit++;
                if (equalsDigit != 25)
                {
                    dispatcherTimer.Stop();
                }

                buttonsIsEnabled = false;
            }
        }

        private void BrushingButtons()
        {
            switch (buttonNumber)
            {
                case 1:
                    if (Convert.ToByte(button1.Content) != equalsDigit)
                    {
                        button1.Background = Brushes.Red;
                    }
                    break;
                case 2:
                    if (Convert.ToByte(button2.Content) != equalsDigit)
                    {
                        button2.Background = Brushes.Red;
                    }
                    break;
                case 3:
                    if (Convert.ToByte(button3.Content) != equalsDigit)
                    {
                        button3.Background = Brushes.Red;
                    }
                    break;
                case 4:
                    if (Convert.ToByte(button4.Content) != equalsDigit)
                    {
                        button4.Background = Brushes.Red;
                    }
                    break;
                case 5:
                    if (Convert.ToByte(button5.Content) != equalsDigit)
                    {
                        button5.Background = Brushes.Red;
                    }
                    break;
                case 6:
                    if (Convert.ToByte(button6.Content) != equalsDigit)
                    {
                        button6.Background = Brushes.Red;
                    }
                    break;
                case 7:
                    if (Convert.ToByte(button7.Content) != equalsDigit)
                    {
                        button7.Background = Brushes.Red;
                    }
                    break;
                case 8:
                    if (Convert.ToByte(button8.Content) != equalsDigit)
                    {
                        button8.Background = Brushes.Red;
                    }
                    break;
                case 9:
                    if (Convert.ToByte(button9.Content) != equalsDigit)
                    {
                        button9.Background = Brushes.Red;
                    }
                    break;
                case 10:
                    if (Convert.ToByte(button10.Content) != equalsDigit)
                    {
                        button10.Background = Brushes.Red;
                    }
                    break;
                case 11:
                    if (Convert.ToByte(button11.Content) != equalsDigit)
                    {
                        button11.Background = Brushes.Red;
                    }
                    break;
                case 12:
                    if (Convert.ToByte(button12.Content) != equalsDigit)
                    {
                        button12.Background = Brushes.Red;
                    }
                    break;
                case 13:
                    if (Convert.ToByte(button13.Content) != equalsDigit)
                    {
                        button13.Background = Brushes.Red;
                    }
                    break;
                case 14:
                    if (Convert.ToByte(button14.Content) != equalsDigit)
                    {
                        button14.Background = Brushes.Red;
                    }
                    break;
                case 15:
                    if (Convert.ToByte(button15.Content) != equalsDigit)
                    {
                        button15.Background = Brushes.Red;
                    }
                    break;
                case 16:
                    if (Convert.ToByte(button16.Content) != equalsDigit)
                    {
                        button16.Background = Brushes.Red;
                    }
                    break;
                case 17:
                    if (Convert.ToByte(button17.Content) != equalsDigit)
                    {
                        button17.Background = Brushes.Red;
                    }
                    break;
                case 18:
                    if (Convert.ToByte(button18.Content) != equalsDigit)
                    {
                        button18.Background = Brushes.Red;
                    }
                    break;
                case 19:
                    if (Convert.ToByte(button19.Content) != equalsDigit)
                    {
                        button19.Background = Brushes.Red;
                    }
                    break;
                case 20:
                    if (Convert.ToByte(button20.Content) != equalsDigit)
                    {
                        button20.Background = Brushes.Red;
                    }
                    break;
                case 21:
                    if (Convert.ToByte(button21.Content) != equalsDigit)
                    {
                        button21.Background = Brushes.Red;
                    }
                    break;
                case 22:
                    if (Convert.ToByte(button22.Content) != equalsDigit)
                    {
                        button22.Background = Brushes.Red;
                    }
                    break;
                case 23:
                    if (Convert.ToByte(button23.Content) != equalsDigit)
                    {
                        button23.Background = Brushes.Red;
                    }
                    break;
                case 24:
                    if (Convert.ToByte(button24.Content) != equalsDigit)
                    {
                        button24.Background = Brushes.Red;
                    }
                    break;
                case 25:
                    if (Convert.ToByte(button25.Content) != equalsDigit)
                    {
                        button25.Background = Brushes.Red;
                    }
                    break;

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
            if (door)
            {
                equalsDigit++;
                if (equalsDigit != buttonContent)
                {
                    dispatcherTimer.Stop();
                    BrushingButtons();
                    stage = 1;
                    buttonsIsEnabled = false;
                    timer.Foreground = Brushes.Red;
                }
                else
                if (equalsDigit == 25)
                {
                    stage++;
                    dispatcherTimer.Stop();
                    if (stage != 6)
                    {
                        NavigationService.Navigate(new SchulteTestTablePage1());
                    }
                }
            }
            door = true;
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            buttonNumber = 1;
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button1.Content))
                {
                    buttonContent = Convert.ToByte(button1.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button1.Content))
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
            }
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            buttonNumber = 2;
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button2.Content))
                {
                    buttonContent = Convert.ToByte(button2.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button2.Content))
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
            }
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            buttonNumber = 3;
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button3.Content))
                {
                    buttonContent = Convert.ToByte(button3.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button3.Content))
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
            }
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            buttonNumber = 4;
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button4.Content))
                {
                    buttonContent = Convert.ToByte(button4.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button4.Content))
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
            }
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            buttonNumber = 5;
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button5.Content))
                {
                    buttonContent = Convert.ToByte(button5.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button5.Content))
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
            }
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            buttonNumber = 6;
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button6.Content))
                {
                    buttonContent = Convert.ToByte(button6.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button6.Content))
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
            }
        }

        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            buttonNumber = 7;
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button7.Content))
                {
                    buttonContent = Convert.ToByte(button7.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button7.Content))
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
            }
        }

        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            buttonNumber = 8;
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button8.Content))
                {
                    buttonContent = Convert.ToByte(button8.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button8.Content))
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
            }
        }

        private void Button_Click9(object sender, RoutedEventArgs e)
        {
            buttonNumber = 9;
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button9.Content))
                {
                    buttonContent = Convert.ToByte(button9.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button9.Content))
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
            }
        }

        private void Button_Click10(object sender, RoutedEventArgs e)
        {
            buttonNumber = 10;
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button10.Content))
                {
                    buttonContent = Convert.ToByte(button10.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button10.Content))
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
            }
        }

        private void Button_Click11(object sender, RoutedEventArgs e)
        {
            buttonNumber = 11;
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button11.Content))
                {
                    buttonContent = Convert.ToByte(button11.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button11.Content))
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
            }
        }

        private void Button_Click12(object sender, RoutedEventArgs e)
        {
            buttonNumber = 12;
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button12.Content))
                {
                    buttonContent = Convert.ToByte(button12.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button12.Content))
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
            }
        }

        private void Button_Click13(object sender, RoutedEventArgs e)
        {
            buttonNumber = 13;
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button13.Content))
                {
                    buttonContent = Convert.ToByte(button13.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button13.Content))
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
            }
        }

        private void Button_Click14(object sender, RoutedEventArgs e)
        {
            buttonNumber = 14;
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button14.Content))
                {
                    buttonContent = Convert.ToByte(button14.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button14.Content))
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
            }
        }

        private void Button_Click15(object sender, RoutedEventArgs e)
        {
            buttonNumber = 15;
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button15.Content))
                {
                    buttonContent = Convert.ToByte(button15.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button15.Content))
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
            }
        }

        private void Button_Click16(object sender, RoutedEventArgs e)
        {
            buttonNumber = 16;
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button16.Content))
                {
                    buttonContent = Convert.ToByte(button16.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button16.Content))
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
            }
        }

        private void Button_Click17(object sender, RoutedEventArgs e)
        {
            buttonNumber = 17;
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button17.Content))
                {
                    buttonContent = Convert.ToByte(button17.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button17.Content))
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
            }
        }

        private void Button_Click18(object sender, RoutedEventArgs e)
        {
            buttonNumber = 18;
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button18.Content))
                {
                    buttonContent = Convert.ToByte(button18.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button18.Content))
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
            }
        }

        private void Button_Click19(object sender, RoutedEventArgs e)
        {
            buttonNumber = 19;
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button19.Content))
                {
                    buttonContent = Convert.ToByte(button19.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button19.Content))
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
            }
        }

        private void Button_Click20(object sender, RoutedEventArgs e)
        {
            buttonNumber = 20;
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button20.Content))
                {
                    buttonContent = Convert.ToByte(button20.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button20.Content))
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
            }
        }

        private void Button_Click21(object sender, RoutedEventArgs e)
        {
            buttonNumber = 21;
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button21.Content))
                {
                    buttonContent = Convert.ToByte(button21.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button21.Content))
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
            }
        }

        private void Button_Click22(object sender, RoutedEventArgs e)
        {
            buttonNumber = 22;
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button22.Content))
                {
                    buttonContent = Convert.ToByte(button22.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button22.Content))
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
            }
        }

        private void Button_Click23(object sender, RoutedEventArgs e)
        {
            buttonNumber = 23;
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button23.Content))
                {
                    buttonContent = Convert.ToByte(button23.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button23.Content))
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
            }
        }

        private void Button_Click24(object sender, RoutedEventArgs e)
        {
            buttonNumber = 24;
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button24.Content))
                {
                    buttonContent = Convert.ToByte(button24.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button24.Content))
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
            }
        }

        private void Button_Click25(object sender, RoutedEventArgs e)
        {
            buttonNumber = 25;
            if (buttonsIsEnabled)
            {
                if (equalsDigit < Convert.ToByte(button25.Content))
                {
                    buttonContent = Convert.ToByte(button25.Content);
                }
                else
                if (equalsDigit >= Convert.ToByte(button25.Content))
                {
                    door = false;
                }
                AddlistIntervalPressButtons();
            }
        }
    }
}
