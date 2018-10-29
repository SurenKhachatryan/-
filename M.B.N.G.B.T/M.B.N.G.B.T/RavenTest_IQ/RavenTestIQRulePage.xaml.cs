using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace M.B.N.G.B.T.RavenTest_IQ
{
    /// <summary>
    /// Логика взаимодействия для RavenTestIQRulePage.xaml
    /// </summary>
    public partial class RavenTestIQRulePage : Page
    {
        private static object ravenTestIQTablePage;

        public static object RavenTestIQTablePage { get { return ravenTestIQTablePage; } }

        public RavenTestIQRulePage()
        {
            InitializeComponent();
        }

        private void Button_Exit_The_Main(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
        }

        private void Button_Start_Test(object sender, RoutedEventArgs e)
        {
            if (ravenTestIQTablePage == null)
                ravenTestIQTablePage = new RavenTestIQTablePage();
            else
                ((INewRavenIQTestTablePage)ravenTestIQTablePage).CreateNewPageTestRavenForNewUser();

            NavigationService.Navigate(ravenTestIQTablePage);
        }
    }
}
