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
        private int labelWrongAnswerTemp = 0;
        private int labelWrongAnswer = 0;
        private int labelRightAnswer = 0;
        private string _operator = "+";
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

        private void Button_Exit_The_Test(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
            NavigationService.Navigate(null);
        }

        private void LabelTimer(object sender, EventArgs e)
        {
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);

            if (second <= 0)
                textBox.IsEnabled = false;

            if ((labelWrongAnswerTemp + 4) <= labelWrongAnswer ||
                (labelWrongAnswer >= 12 && labelRightAnswer <= 2 && second >= 22) ||
                (labelWrongAnswer >= 18 && labelRightAnswer <= 5 && second >= 19) ||
                (labelWrongAnswer >= 23 && labelRightAnswer <= 7 && second >= 15) ||
                (labelWrongAnswer >= 27 && labelRightAnswer <= 8 && second >= 12 ||
                (labelWrongAnswer >= 30 && labelRightAnswer <= 10 && second >= 10)) ||
                (labelWrongAnswer >= 33 && labelRightAnswer <= 12 && second <= 7) ||
                (labelWrongAnswer >= 18 && labelRightAnswer <= 3) ||
                (labelWrongAnswer >= 25 && labelRightAnswer <= 4) ||
                (labelWrongAnswer >= 29 && labelRightAnswer <= 7))
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

                if (labelWrongAnswer == 0 && labelRightAnswer == 0 && second == -1)
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

                    arrAllStageRightAnswers[stage - 1][0] = labelRightAnswer;
                    arrAllStageWrongAnswers[stage - 1][0] = labelWrongAnswer;

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
            labelWrongAnswerTemp = labelWrongAnswer;
            if (!timer2.IsVisible)
                textBox.Focus();
        }

        private void Initializator()
        {
            int temp = 0;
            int tempLabelUp = Convert.ToInt32(LableCalculatingUp.Content);
            int tempLabelDown = Convert.ToInt32(LableCalculatingDown.Content);
            do
            {
                LableCalculatingDown.Content = $"{rnd.Next(1, 11)}";
                if (_operator == "-")
                {
                    do
                    {
                        temp = rnd.Next(1, 21);
                        LableCalculatingUp.Content = $"{temp}";
                    } while (((Convert.ToInt32(LableCalculatingUp.Content) - Convert.ToInt32(LableCalculatingDown.Content)) % 10) < 1);
                }
                else
                    LableCalculatingUp.Content = $"{rnd.Next(1, 11)}";
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
                labelRightAnswer++;
                lebleTrue.Content = $"Ճիշտ - {labelRightAnswer}";
                Initializator();
            }
            else
            {
                labelWrongAnswer++;
                lebleFalse.Content = $"Սխալ - {labelWrongAnswer}";
                Initializator();
            }

            if (labelWrongAnswer > 37)
            {
                dispatcherTimer.Stop();
                isIncreasedErrors = true;
                NavigationService.Navigate(new EmilKraepelinTestWarningPage());
            }
        }

        private void ButtonsColection_Click(object sender, RoutedEventArgs e)
        {
            FinishStage(Convert.ToInt16(((Button)sender).Content), _operator);
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
