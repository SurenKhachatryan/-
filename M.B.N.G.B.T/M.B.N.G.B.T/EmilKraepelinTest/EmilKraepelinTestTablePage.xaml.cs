using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Threading;

namespace M.B.N.G.B.T.EmilKraepelinTest
{
    /// <summary>
    /// Логика взаимодействия для EmilKraepelinTestTablePage.xaml
    /// </summary>
    public partial class EmilKraepelinTestTablePage : Page
    {
        private Random rnd = new Random();
        private DispatcherTimer dispatcherTimer = new DispatcherTimer();

        private int second = 30;
        private int labelFalse = 0;
        private int labelTrue = 0;
        private string _operator = "+";
        private int labelFalsetemp = 0;
        private static bool isZeroLabelFalseAndTrue = false;
        private static bool isIncreasedErrors = false;
        private static bool isSeriousness = false;
        private static int[][] arrAllStageRightAnswers = new int[8][];
        private static int[][] arrAllStageWrongAnswers = new int[8][];

        public static int stage { get; set; } = 1;
        public static bool IsZeroLabelFalseAndTrue { get { return isZeroLabelFalseAndTrue; } }
        public static bool IsIncreasedErrors { get { return isIncreasedErrors; } }
        public static bool IsSeriousness { get { return isSeriousness; } }
        public static int[][] ArrAllStageRightAnswers { get { return arrAllStageRightAnswers; } }
        public static int[][] ArrAllStageWrongAnswers { get { return arrAllStageWrongAnswers; } }

        public EmilKraepelinTestTablePage()
        {
            InitializeComponent();

            dispatcherTimer.Tick += new EventHandler(LabelTimer);

            if (stage == 1)
            {
                arrAllStageRightAnswers = new int[8][];
                arrAllStageWrongAnswers = new int[8][];
                isZeroLabelFalseAndTrue = false;
                isIncreasedErrors = false;
                isSeriousness = false;
            }

            LableStage.Content = $"Փուլ {stage}/8";

            if (stage % 2 != 0)
                _Operator.Content = (_operator = "+");
            else
                _Operator.Content = (_operator = "-");

            Initializator();
            dispatcherTimer.Start();
        }

        private void Button_Exit_The_Test_View_Result(object sender, RoutedEventArgs e)
        {
            arrAllStageRightAnswers[stage - 1] = new int[1];
            arrAllStageWrongAnswers[stage - 1] = new int[1];

            arrAllStageRightAnswers[stage - 1][0] = labelTrue;
            arrAllStageWrongAnswers[stage - 1][0] = labelFalse;

            for (int i = stage; i < 8; i++)
            {
                arrAllStageRightAnswers[i] = new int[1];
                arrAllStageWrongAnswers[i] = new int[1];
            }

            dispatcherTimer.Stop();

            NavigationService.Navigate(new EmilKraepelinTestResultPage());
        }

        private void LabelTimer(object sender, EventArgs e)
        {
            textBox.Focus();
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);

            if ((labelFalsetemp + 4) <= labelFalse ||
                (labelFalse >= 12 && labelTrue <= 2 && second >= 22) ||
                (labelFalse >= 18 && labelTrue <= 5 && second >= 19) ||
                (labelFalse >= 23 && labelTrue <= 7 && second >= 15) ||
                (labelFalse >= 27 && labelTrue <= 8 && second >= 12 ||
                (labelFalse >= 30 && labelTrue <= 10 && second >= 10)) ||
                (labelFalse >= 33 && labelTrue <= 12 && second <= 7) ||
                (labelFalse >= 18 && labelTrue <= 3) ||
                (labelFalse >= 25 && labelTrue <= 4) ||
                (labelFalse >= 29 && labelTrue <= 7))
            {
                dispatcherTimer.Stop();
                isSeriousness = true;
                NavigationService.Navigate(new EmilKraepelinTestWarningPage());
            }
            else
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

                if (labelFalse == 0 && labelTrue == 0 && second == -1)
                {
                    dispatcherTimer.Stop();
                    isZeroLabelFalseAndTrue = true;
                    NavigationService.Navigate(new EmilKraepelinTestWarningPage());
                }
                else
                if (second == -1 && stage != 8)
                {
                    timer2.Visibility = Visibility.Visible;
                    wrapPanelButtons.IsEnabled = false;
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
                        NavigationService.Navigate(new EmilKraepelinTestTablePage());
                    }
                    else
                        NavigationService.Navigate(new EmilKraepelinTestResultPage());

                    dispatcherTimer.Stop();
                }
                timer2.Content = $"0{(second + 3)}";
                second--;
            }
            labelFalsetemp = labelFalse;
        }

        private void Initializator()
        {
            int temp = 0;
            int tempLabelUp = Convert.ToInt32(LableCalculatingUp.Content);
            int tempLabelDown = Convert.ToInt32(LableCalculatingDown.Content);
            do
            {
                LableCalculatingDown.Content = $"{rnd.Next(1, 10)}";
                if (_operator == "-")
                {
                    do
                    {
                        temp = rnd.Next(1, 21);
                        LableCalculatingUp.Content = $"{temp}";
                    } while (((Convert.ToInt32(LableCalculatingUp.Content) - Convert.ToInt32(LableCalculatingDown.Content)) % 10) < 1);
                }
                else
                    LableCalculatingUp.Content = $"{rnd.Next(1, 10)}";
            }
            while (tempLabelDown == (Convert.ToInt32(LableCalculatingDown.Content)) || tempLabelUp == (Convert.ToInt32(LableCalculatingUp.Content)));

            textBox.Text = "";
            textBox.Focus();
        }

        private void FinishStage(int Number, string _operator)
        {
            switch (_operator)
            {
                case "+":
                    if (Number == ((Convert.ToInt32(LableCalculatingUp.Content) + Convert.ToInt32(LableCalculatingDown.Content)) % 10))
                        InitializatorLabelTrueAndFalse(true);
                    else
                        InitializatorLabelTrueAndFalse(false);
                    break;

                case "-":
                    if (Number == ((Convert.ToInt32(LableCalculatingUp.Content) - Convert.ToInt32(LableCalculatingDown.Content)) % 10))
                        InitializatorLabelTrueAndFalse(true);
                    else
                        InitializatorLabelTrueAndFalse(false);
                    break;
            }
        }

        private void InitializatorLabelTrueAndFalse(bool bl)
        {
            if (bl)
            {
                labelTrue++;
                lebleTrue.Content = $"Ճիշտ - {labelTrue}";
                Initializator();
            }
            else
            {
                labelFalse++;
                lebleFalse.Content = $"Սխալ - {labelFalse}";
                Initializator();
            }

            if (labelFalse > 37)
            {
                dispatcherTimer.Stop();
                isIncreasedErrors = true;
                NavigationService.Navigate(new EmilKraepelinTestWarningPage());
            }
        }

        private void ButtonsColection_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt16(((Button)sender).Content) != 10)
                FinishStage(Convert.ToInt16(((Button)sender).Content), _operator);
            else
                FinishStage(0, _operator);
        }

        private void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if ((!Char.IsDigit(e.Text, 0)) || textBox.Text.Length == 3)
                e.Handled = true;

            if (Char.IsDigit(e.Text, 0))
            {
                FinishStage(Convert.ToInt32(e.Text), _operator);
                e.Handled = true;
            }
        }

        private void Grid_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }
    }
}
