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
    /// Логика взаимодействия для RavenTestIQResultPage.xaml
    /// </summary>
    public partial class RavenTestIQResultPage : Page
    {
        public static object ErorsPage { get; set; }

        public RavenTestIQResultPage()
        {
            InitializeComponent();
        }

        private void Button_Click_View_Errors_User(object sender, RoutedEventArgs e)
        {
            if (ErorsPage == null)
                ErorsPage = new RavenTestIQViewUserErrorsPage();

            NavigationService.Navigate(ErorsPage as RavenTestIQViewUserErrorsPage);
        }

        private void Button_Click_Try_Again(object sender, RoutedEventArgs e)
        {
            ErorsPage = null;
            NavigationService.Navigate(new RavenTestIQRulePage());
        }

        private void Button_Click_Exit_Main(object sender, RoutedEventArgs e)
        {
            ErorsPage = null;
            NavigationService.Navigate(null);
        }
    }
}
