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

namespace M.B.N.G.B.T.RavenTest_IQ
{
    /// <summary>
    /// Логика взаимодействия для RavenTestIQTablePage.xaml
    /// </summary>
    public partial class RavenTestIQTablePage : Page
    {
        public RavenTestIQTablePage()
        {
            InitializeComponent();
        }

        private void Button_Exit_The_Test(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RavenTestIQRulePage());
        }
    }
}
