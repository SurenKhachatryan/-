using M.B.N.G.B.T.V.L.Marshukov_Test;
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

namespace M.B.N.G.B.T.V.L.Marshuk_Test
{
    /// <summary>
    /// Логика взаимодействия для MarshukResaltPage.xaml
    /// </summary>
    public partial class MarshukTestResultPage : Page
    {
        public MarshukTestResultPage()
        {
            InitializeComponent();
        }
        private void button_Click_try_again(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MarshukTestRulePage());
        }

        private void button_Click_Exit_Main(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
        }
    }
}
