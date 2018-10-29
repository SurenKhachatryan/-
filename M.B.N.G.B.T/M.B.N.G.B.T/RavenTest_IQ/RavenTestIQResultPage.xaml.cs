using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace M.B.N.G.B.T.RavenTest_IQ
{
    /// <summary>
    /// Логика взаимодействия для RavenTestIQResultPage.xaml
    /// </summary>
    public partial class RavenTestIQResultPage : Page
    {
        private static object ravenTestIQViewUserErrorsPage;
        public static object RavenTestIQViewUserErrorsPage { get { return ravenTestIQViewUserErrorsPage; } }

        public RavenTestIQResultPage()
        {
            InitializeComponent();

            buttonClickViewErrorsUser.Visibility = Visibility.Visible;
            if (ravenTestIQViewUserErrorsPage == null && RavenTestIQTablePage.IsUserErrors)
                ravenTestIQViewUserErrorsPage = new RavenTestIQViewUserErrorsPage();
        }

        private void Button_Click_View_Errors_User(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(RavenTestIQViewUserErrorsPage as RavenTestIQViewUserErrorsPage);
        }

        private void Button_Click_Try_Again(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
        }

        private void Button_Click_Exit_Main(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
            Process.Start(Application.ResourceAssembly.Location);
        }
    }
}
