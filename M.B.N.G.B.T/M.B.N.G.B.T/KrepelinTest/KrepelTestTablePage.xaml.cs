using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Threading;

namespace M.B.N.G.B.T.KrepelTest
{
    /// <summary>
    /// Логика взаимодействия для KrepelTestTablePage.xaml
    /// </summary>
    public partial class KrepelinTestTablePage : Page
    {
        private Random rnd = new Random();
        private DispatcherTimer dispatcherTimer = new DispatcherTimer();

        private int second { get; set; } = 30;
        private int labelFalse { get; set; } = 0;
        private int labelTrue { get; set; } = 0;
        private int buttonContent { get; set; }
        private string _operator { get; set; } = "+";

        public static int stage { get; set; } = 1;
        public static int[][] arrAllStageRightAnswers { get; set; } = new int[8][];
        public static int[][] arrAllStageWrongAnswers { get; set; } = new int[8][];

        public KrepelinTestTablePage()
        {
            InitializeComponent();

            dispatcherTimer.Tick += new EventHandler(LabelTimer);

            LableStage.Content = $"Փուլ {stage}/8";

            if (stage % 2 != 0)
                _Operator.Content = (_operator = "+");
            else
                _Operator.Content = (_operator = "-");

            Initializator();
            dispatcherTimer.Start();
        }

        private void button_Click_Result(object sender, RoutedEventArgs e)
        {
            arrAllStageRightAnswers[stage - 1] = new int[1];
            arrAllStageWrongAnswers[stage - 1] = new int[1];

            arrAllStageRightAnswers[stage - 1][0] = labelTrue;
            arrAllStageWrongAnswers[stage - 1][0] = labelFalse;

            dispatcherTimer.Stop();

            NavigationService.Navigate(new KrepelinTestResultPage());
        }

        private void LabelTimer(object sender, EventArgs e)
        {
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            if (second >= 0)
            {
                if (second == 10)
                    timer1.Foreground = Brushes.Yellow;
                if (second == 5)
                    timer1.Foreground = Brushes.Red;

                if (second > 9)
                    timer1.Content = $"{second}";
                else
                    timer1.Content = $"0{second}";
                second--;
                if (second == -1 && stage != 8)
                {
                    timer2.Visibility = Visibility.Visible;
                    IsEnabledButtonsAndTextBox(false);
                    timer2.Content = $"0{(second + 4)}";
                }
            }
            else
            {
                if (second == -4 || (stage == 8 && second <= 0))
                {
                    arrAllStageRightAnswers[stage - 1] = new int[1];
                    arrAllStageWrongAnswers[stage - 1] = new int[1];

                    arrAllStageRightAnswers[stage - 1][0] = labelTrue;
                    arrAllStageWrongAnswers[stage - 1][0] = labelFalse;

                    if (stage != 8)
                    {
                        stage++;
                        NavigationService.Navigate(new KrepelinTestTablePage());
                    }
                    else
                    {
                        NavigationService.Navigate(new KrepelinTestResultPage());
                    }
                    dispatcherTimer.Stop();
                }
                timer2.Content = $"0{(second + 3)}";
                second--;
            }
        }

        private void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if ((!Char.IsDigit(e.Text, 0)) || textBox.Text.Length == 3)
            {
                e.Handled = true;
            }
            if (Char.IsDigit(e.Text, 0))
            {
                FinishStage(Convert.ToInt32(e.Text), _operator);
                e.Handled = true;
            }
        }

        private void Grid_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }

        private void Initializator()
        {
            int tamp = 0;
            LableCalculatingDown.Content = $" {rnd.Next(1, 10)}";
            if (_operator == "-")
            {
                do
                {
                    tamp = rnd.Next(1, 21);
                    if (tamp < 10)
                        LableCalculatingUp.Content = $" {tamp}";
                    else
                        LableCalculatingUp.Content = $"{tamp}";

                } while (((Convert.ToInt32(LableCalculatingUp.Content) - Convert.ToInt32(LableCalculatingDown.Content)) % 10) < 1);
            }
            else
                LableCalculatingUp.Content = $" {rnd.Next(1, 10)}";

            textBox.Text = "";
            textBox.Focus();
            buttonContent = -1;
        }

        private void InitializatorLabelTrue()
        {
            labelTrue++;
            lebleTrue.Content = $"Ճիշտ - {labelTrue}";
            Initializator();
        }

        private void InitializatorLabelFalse()
        {
            labelFalse++;
            lebleFalse.Content = $"Սխալ - {labelFalse}";
            Initializator();
        }

        private void FinishStage(int Number, string _operator)
        {
            switch (_operator)
            {
                case "+":
                    if (Number == ((Convert.ToInt32(LableCalculatingUp.Content) + Convert.ToInt32(LableCalculatingDown.Content)) % 10))
                        InitializatorLabelTrue();
                    else
                        InitializatorLabelFalse();
                    break;

                case "-":
                    if (Number == ((Convert.ToInt32(LableCalculatingUp.Content) - Convert.ToInt32(LableCalculatingDown.Content)) % 10))
                        InitializatorLabelTrue();
                    else
                        InitializatorLabelFalse();
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FinishStage(0, _operator);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FinishStage(1, _operator);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FinishStage(2, _operator);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            FinishStage(3, _operator);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            FinishStage(4, _operator);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            FinishStage(5, _operator);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            FinishStage(6, _operator);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            FinishStage(7, _operator);
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            FinishStage(8, _operator);
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            FinishStage(9, _operator);
        }

        private void IsEnabledButtonsAndTextBox(bool bl)
        {
            button0.IsEnabled = bl;
            button1.IsEnabled = bl;
            button2.IsEnabled = bl;
            button3.IsEnabled = bl;
            button4.IsEnabled = bl;
            button5.IsEnabled = bl;
            button6.IsEnabled = bl;
            button7.IsEnabled = bl;
            button8.IsEnabled = bl;
            button9.IsEnabled = bl;
            textBox.IsEnabled = bl;
        }
    }
}
