using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace M.B.N.G.B.T.RavenTest_IQ
{
    /// <summary>
    /// Логика взаимодействия для RavenTestIQResultPage.xaml
    /// </summary>
    public partial class RavenTestIQResultPage : Page, INewRavenTestIQResultPage
    {
        public static byte[] arrIQAccordingToTheNorm = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                                                    62, 65, 65, 66, 67, 69, 70, 71, 72, 73, 75, 76, 77, 79, 80, 82, 83,
                                                                    84, 86, 87, 88, 90, 91, 92, 94, 95, 96, 98, 99, 100, 102, 104, 106,
                                                                    108, 110, 112, 114, 116, 118, 120, 122, 124, 126, 128, 130, 140};

        private static object ravenTestIQViewUserErrorsPage;
        public static object RavenTestIQViewUserErrorsPage { get { return ravenTestIQViewUserErrorsPage; } }

        public RavenTestIQResultPage()
        {
            InitializeComponent();
            CreateNewResultPageForNewUser();
        }

        /// <summary>
        /// Этот метод обнулировает все данные в классе RavenTestIQResultPage и RavenTestIQViewUserErrorsPage
        /// для нового пользователя (как новое окно)
        /// </summary>
        public void CreateNewResultPageForNewUser()
        {
            buttonClickViewErrorsUser.Visibility = Visibility.Hidden;

            if (RavenTestIQTablePage.IsUserErrors)
                buttonClickViewErrorsUser.Visibility = Visibility.Visible;

            if (ravenTestIQViewUserErrorsPage == null && RavenTestIQTablePage.IsUserErrors)
                ravenTestIQViewUserErrorsPage = new RavenTestIQViewUserErrorsPage();
            else
            if (ravenTestIQViewUserErrorsPage != null && RavenTestIQTablePage.IsUserErrors)
                ((INewRavenTestIQViewUserErrorsPage)ravenTestIQViewUserErrorsPage).CreateNewViewUserErrorsPageForNewUser();
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
