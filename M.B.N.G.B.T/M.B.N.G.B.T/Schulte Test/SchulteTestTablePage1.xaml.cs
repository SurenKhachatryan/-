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
        private List<int> lsClickButton = new List<int>();
        private List<int> lsMissingNumbers = new List<int>();
        private Random rnd = new Random();
        private ClassLibraryMBNGBT cl = new ClassLibraryMBNGBT();
        private DispatcherTimer dispatcherTimer = new DispatcherTimer();

        private byte second = 0;
        private byte equalsDigit = 0;
        private byte buttonContent = 0;
        private bool door = true;
        public static byte stage = 1;
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
            }
            else
            {
                timer.Foreground = Brushes.Red;
                lsMissingNumbers = cl.SortingAndSerchInArrMissingNumbers(lsClickButton.ToArray(), 25);
                BrushingButtons1(lsMissingNumbers.ToArray());
                dispatcherTimer.Stop();
                buttonsIsEnabled = false;
            }
        }

        private void BrushingButtons1(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                switch (arr[i])
                {
                    case 1:
                        button1.Background = Brushes.Red;
                        break;
                    case 2:
                        button2.Background = Brushes.Red;
                        break;
                    case 3:
                        button3.Background = Brushes.Red;
                        break;
                    case 4:
                        button4.Background = Brushes.Red;
                        break;
                    case 5:
                        button5.Background = Brushes.Red;
                        break;
                    case 6:
                        button6.Background = Brushes.Red;
                        break;
                    case 7:
                        button7.Background = Brushes.Red;
                        break;
                    case 8:
                        button8.Background = Brushes.Red;
                        break;
                    case 9:
                        button9.Background = Brushes.Red;
                        break;
                    case 10:
                        button10.Background = Brushes.Red;
                        break;
                    case 11:
                        button11.Background = Brushes.Red;
                        break;
                    case 12:
                        button12.Background = Brushes.Red;
                        break;
                    case 13:
                        button13.Background = Brushes.Red;
                        break;
                    case 14:
                        button14.Background = Brushes.Red;
                        break;
                    case 15:
                        button15.Background = Brushes.Red;
                        break;
                    case 16:
                        button16.Background = Brushes.Red;
                        break;
                    case 17:
                        button17.Background = Brushes.Red;
                        break;
                    case 18:
                        button18.Background = Brushes.Red;
                        break;
                    case 19:
                        button19.Background = Brushes.Red;
                        break;
                    case 20:
                        button20.Background = Brushes.Red;
                        break;
                    case 21:
                        button21.Background = Brushes.Red;
                        break;
                    case 22:
                        button22.Background = Brushes.Red;
                        break;
                    case 23:
                        button23.Background = Brushes.Red;
                        break;
                    case 24:
                        button24.Background = Brushes.Red;
                        break;
                    case 25:
                        button25.Background = Brushes.Red;
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
                    lsMissingNumbers = cl.SortingAndSerchInArrMissingNumbers(lsClickButton.ToArray(), 25);
                    BrushingButtons1(lsMissingNumbers.ToArray());
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
                    else
                    {
                        NavigationService.Navigate(new SchulteTestResultPage());
                    }
                }
            }
            door = true;
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            if (buttonNumber != 1 && buttonsIsEnabled)
            {
                lsClickButton.Add(buttonNumber = 1);
            }
            if (equalsDigit + 1 != Convert.ToByte(button1.Content) && equalsDigit + 1 < Convert.ToByte(button1.Content) && buttonsIsEnabled)
            {
                button1.Background = Brushes.Yellow;
            }
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
            if (buttonNumber != 2 && buttonsIsEnabled)
            {
                lsClickButton.Add(buttonNumber = 2);
            }
            if (equalsDigit + 1 != Convert.ToByte(button2.Content) && equalsDigit + 1 < Convert.ToByte(button2.Content) && buttonsIsEnabled)
            {
                button2.Background = Brushes.Yellow;
            }
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
            if (buttonNumber != 3 && buttonsIsEnabled)
            {
                lsClickButton.Add(buttonNumber = 3);
            }
            if (equalsDigit + 1 != Convert.ToByte(button3.Content) && equalsDigit + 1 < Convert.ToByte(button3.Content) && buttonsIsEnabled)
            {
                button3.Background = Brushes.Yellow;
            }
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
            if (buttonNumber != 4 && buttonsIsEnabled)
            {
                lsClickButton.Add(buttonNumber = 4);
            }
            if (equalsDigit + 1 != Convert.ToByte(button4.Content) && equalsDigit + 1 < Convert.ToByte(button4.Content) && buttonsIsEnabled)
            {
                button4.Background = Brushes.Yellow;
            }
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
            if (buttonNumber != 5 && buttonsIsEnabled)
            {
                lsClickButton.Add(buttonNumber = 5);
            }
            if (equalsDigit + 1 != Convert.ToByte(button5.Content) && equalsDigit + 1 < Convert.ToByte(button5.Content) && buttonsIsEnabled)
            {
                button5.Background = Brushes.Yellow;
            }
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
            if (buttonNumber != 6 && buttonsIsEnabled)
            {
                lsClickButton.Add(buttonNumber = 6);
            }
            if (equalsDigit + 1 != Convert.ToByte(button6.Content) && equalsDigit + 1 < Convert.ToByte(button6.Content) && buttonsIsEnabled)
            {
                button6.Background = Brushes.Yellow;
            }
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
            if (buttonNumber != 7 && buttonsIsEnabled)
            {
                lsClickButton.Add(buttonNumber = 7);
            }
            if (equalsDigit + 1 != Convert.ToByte(button7.Content) && equalsDigit + 1 < Convert.ToByte(button7.Content) && buttonsIsEnabled)
            {
                button7.Background = Brushes.Yellow;
            }
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
            if (buttonNumber != 8 && buttonsIsEnabled)
            {
                lsClickButton.Add(buttonNumber = 8);
            }
            if (equalsDigit + 1 != Convert.ToByte(button8.Content) && equalsDigit + 1 < Convert.ToByte(button8.Content) && buttonsIsEnabled)
            {
                button8.Background = Brushes.Yellow;
            }
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
            if (buttonNumber != 9 && buttonsIsEnabled)
            {
                lsClickButton.Add(buttonNumber = 9);
            }
            if (equalsDigit + 1 != Convert.ToByte(button9.Content) && equalsDigit + 1 < Convert.ToByte(button9.Content) && buttonsIsEnabled)
            {
                button9.Background = Brushes.Yellow;
            }
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
            if (buttonNumber != 10 && buttonsIsEnabled)
            {
                lsClickButton.Add(buttonNumber = 10);
            }
            if (equalsDigit + 1 != Convert.ToByte(button10.Content) && equalsDigit + 1 < Convert.ToByte(button10.Content) && buttonsIsEnabled)
            {
                button10.Background = Brushes.Yellow;
            }
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
            if (buttonNumber != 11 && buttonsIsEnabled)
            {
                lsClickButton.Add(buttonNumber = 11);
            }
            if (equalsDigit + 1 != Convert.ToByte(button11.Content) && equalsDigit + 1 < Convert.ToByte(button11.Content) && buttonsIsEnabled)
            {
                button11.Background = Brushes.Yellow;
            }
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
            if (buttonNumber != 12 && buttonsIsEnabled)
            {
                lsClickButton.Add(buttonNumber = 12);
            }
            if (equalsDigit + 1 != Convert.ToByte(button12.Content) && equalsDigit + 1 < Convert.ToByte(button12.Content) && buttonsIsEnabled)
            {
                button12.Background = Brushes.Yellow;
            }
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
            if (buttonNumber != 13 && buttonsIsEnabled)
            {
                lsClickButton.Add(buttonNumber = 13);
            }
            if (equalsDigit + 1 != Convert.ToByte(button13.Content) && equalsDigit + 1 < Convert.ToByte(button13.Content) && buttonsIsEnabled)
            {
                button13.Background = Brushes.Yellow;
            }
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
            if (buttonNumber != 14 && buttonsIsEnabled)
            {
                lsClickButton.Add(buttonNumber = 14);
            }
            if (equalsDigit + 1 != Convert.ToByte(button14.Content) && equalsDigit + 1 < Convert.ToByte(button14.Content) && buttonsIsEnabled)
            {
                button14.Background = Brushes.Yellow;
            }
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
            if (buttonNumber != 15 && buttonsIsEnabled)
            {
                lsClickButton.Add(buttonNumber = 15);
            }
            if (equalsDigit + 1 != Convert.ToByte(button15.Content) && equalsDigit + 1 < Convert.ToByte(button15.Content) && buttonsIsEnabled)
            {
                button15.Background = Brushes.Yellow;
            }
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
            if (buttonNumber != 16 && buttonsIsEnabled)
            {
                lsClickButton.Add(buttonNumber = 16);
            }
            if (equalsDigit + 1 != Convert.ToByte(button16.Content) && equalsDigit + 1 < Convert.ToByte(button16.Content) && buttonsIsEnabled)
            {
                button16.Background = Brushes.Yellow;
            }
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
            if (buttonNumber != 17 && buttonsIsEnabled)
            {
                lsClickButton.Add(buttonNumber = 17);
            }
            if (equalsDigit + 1 != Convert.ToByte(button17.Content) && equalsDigit + 1 < Convert.ToByte(button17.Content) && buttonsIsEnabled)
            {
                button17.Background = Brushes.Yellow;
            }
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
            if (buttonNumber != 18 && buttonsIsEnabled)
            {
                lsClickButton.Add(buttonNumber = 18);
            }
            if (equalsDigit + 1 != Convert.ToByte(button18.Content) && equalsDigit + 1 < Convert.ToByte(button18.Content) && buttonsIsEnabled)
            {
                button18.Background = Brushes.Yellow;
            }
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
            if (buttonNumber != 19 && buttonsIsEnabled)
            {
                lsClickButton.Add(buttonNumber = 19);
            }
            if (equalsDigit + 1 != Convert.ToByte(button19.Content) && equalsDigit + 1 < Convert.ToByte(button19.Content) && buttonsIsEnabled)
            {
                button19.Background = Brushes.Yellow;
            }
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
            if (buttonNumber != 20 && buttonsIsEnabled)
            {
                lsClickButton.Add(buttonNumber = 20);
            }
            if (equalsDigit + 1 != Convert.ToByte(button20.Content) && equalsDigit + 1 < Convert.ToByte(button20.Content) && buttonsIsEnabled)
            {
                button20.Background = Brushes.Yellow;
            }
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
            if (buttonNumber != 21 && buttonsIsEnabled)
            {
                lsClickButton.Add(buttonNumber = 21);
            }
            if (equalsDigit + 1 != Convert.ToByte(button21.Content) && equalsDigit + 1 < Convert.ToByte(button21.Content) && buttonsIsEnabled)
            {
                button21.Background = Brushes.Yellow;
            }
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
            if (buttonNumber != 22 && buttonsIsEnabled)
            {
                lsClickButton.Add(buttonNumber = 22);
            }
            if (equalsDigit + 1 != Convert.ToByte(button22.Content) && equalsDigit + 1 < Convert.ToByte(button22.Content) && buttonsIsEnabled)
            {
                button22.Background = Brushes.Yellow;
            }
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
            if (buttonNumber != 23 && buttonsIsEnabled)
            {
                lsClickButton.Add(buttonNumber = 23);
            }
            if (equalsDigit + 1 != Convert.ToByte(button23.Content) && equalsDigit + 1 < Convert.ToByte(button23.Content) && buttonsIsEnabled)
            {
                button23.Background = Brushes.Yellow;
            }
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
            if (buttonNumber != 24 && buttonsIsEnabled)
            {
                lsClickButton.Add(buttonNumber = 24);
            }
            if (equalsDigit + 1 != Convert.ToByte(button24.Content) && equalsDigit + 1 < Convert.ToByte(button24.Content) && buttonsIsEnabled)
            {
                button24.Background = Brushes.Yellow;
            }
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
            if (buttonNumber != 25 && buttonsIsEnabled)
            {
                lsClickButton.Add(buttonNumber = 25);
            }
            if (equalsDigit + 1 != Convert.ToByte(button25.Content) && equalsDigit + 1 < Convert.ToByte(button25.Content) && buttonsIsEnabled)
            {
                button25.Background = Brushes.Yellow;
            }
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
