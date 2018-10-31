using System.Diagnostics;
using System.Windows;

namespace M.B.N.G.B.T.RavenTest_IQ
{
    /// <summary>
    /// Логика взаимодействия для RavenTestIQRuleWindow.xaml
    /// </summary>
    public partial class RavenTestIQRuleWindow : Window
    {
        private static object ravenTestIQTablePage;

        public static object RavenTestIQTablePage { get { return ravenTestIQTablePage; } }
        public RavenTestIQRuleWindow()
        {
            InitializeComponent();
        }

        private void Button_Exit_The_Main(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
            Process.Start(Application.ResourceAssembly.Location);
        }

        private void Button_Start_Test(object sender, RoutedEventArgs e)
        {
            if (ravenTestIQTablePage == null)
                ravenTestIQTablePage = new RavenTestIQTablePage();
            else
                ((INewRavenIQTestTablePage)ravenTestIQTablePage).CreateNewPageTestRavenForNewUser();

            Main.NavigationService.Navigate(ravenTestIQTablePage);
        }
    }
}
