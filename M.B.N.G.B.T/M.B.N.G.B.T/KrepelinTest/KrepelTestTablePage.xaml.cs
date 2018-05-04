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
        
        private int second = 0;

        public KrepelinTestTablePage()
        {
            InitializeComponent();

            dispatcherTimer.Tick += new EventHandler(LabelTimer);
            Initializator();
            textBox.Focus();
            dispatcherTimer.Start();

        }

        private void button_Click_Result(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
        }

        private void LabelTimer(object sender, EventArgs e)
        {
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            second++;
            if (textBox.Text != "" && second == 1)
            {
                FinishStage();
            }
        }

        private void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            second = 0;
            if ((!Char.IsDigit(e.Text, 0)) || textBox.Text.Length == 3)
            {
                e.Handled = true;
            }
            //if (Char.IsDigit(e.Text, 0))
            //{
            //    textBox.Text = e.Text;
            //    FinishStage();
            //    e.Handled = true;
            //}
        }

        private void Grid_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            second = 0;
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }

        }
        private void Initializator()
        {
            LableCalculatingUp.Content = $"{rnd.Next(1, 10)}";
            LableCalculatingDown.Content = $"{rnd.Next(1, 10)}";
            textBox.Text = "";
        }

        private void FinishStage()
        {
            if (Convert.ToInt32(textBox.Text) == ((Convert.ToInt32(LableCalculatingUp.Content) + Convert.ToInt32(LableCalculatingDown.Content)) % 10))
            {
                lebleTrue.Content = $"Ճիշտ = {(Convert.ToInt32(lebleTrue.Content) + 1)}";
                Initializator();
            }
            else
            {
                lebleFalse.Content = $"Սխալ = {Convert.ToInt32(lebleFalse) + 1}";
                Initializator();
            }
        }
    }
}
