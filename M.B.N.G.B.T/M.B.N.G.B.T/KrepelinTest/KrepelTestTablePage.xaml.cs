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

        private List<int> listAllStageRightAnswers { get; set; } = new List<int>();
        private List<int> listAllStageWrongAnswers { get; set; } = new List<int>();

        public static int stage { get; set; } = 1;
        public static int[] arrAllStageRightAnswers { get; private set; } = new int[8];
        public static int[] arrAllStageWrongAnswers { get; private set; } = new int[8];

        public KrepelinTestTablePage()
        {
            InitializeComponent();

            dispatcherTimer.Tick += new EventHandler(LabelTimer);

            LableStage.Content = $"Փուլ {stage}/8";
            Initializator();
            textBox.Focus();
            dispatcherTimer.Start();
        }

        private void button_Click_Result(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new KrepelinTestResultPage());
            dispatcherTimer.Stop();
        }

        private void LabelTimer(object sender, EventArgs e)
        {
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            if (second != -1)
            {
                if (second > 9)
                    timerStage.Content = $"{second}";
                else
                    timerStage.Content = $"0{second}";
                second--;
            }
            else
            {
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
        }

        private void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if ((!Char.IsDigit(e.Text, 0)) || textBox.Text.Length == 3)
            {
                e.Handled = true;
            }
            if (Char.IsDigit(e.Text, 0))
            {
                FinishStage(Convert.ToInt32(e.Text));
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
            LableCalculatingUp.Content = $" {rnd.Next(1, 10)}";
            LableCalculatingDown.Content = $" {rnd.Next(1, 10)}";
            textBox.Text = "";
            textBox.Focus();
            buttonContent = -1;
        }

        private void FinishStage(int Number)
        {
            if (Number == ((Convert.ToInt32(LableCalculatingUp.Content) + Convert.ToInt32(LableCalculatingDown.Content)) % 10))
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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FinishStage(0);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FinishStage(1);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FinishStage(2);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            FinishStage(3);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            FinishStage(4);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            FinishStage(5);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            FinishStage(6);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            FinishStage(7);
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            FinishStage(8);
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            FinishStage(9);
        }
    }
}
