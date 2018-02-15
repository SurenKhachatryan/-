using M.B.N.G.B.T.AttentivenessTest;
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

namespace M.B.N.G.B.T
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
            button1.IsEnabled = false;
            button2.IsEnabled = false;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
         

        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("holo xop");
            
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Main.Content = new Rule();
           
        }
    }
}
