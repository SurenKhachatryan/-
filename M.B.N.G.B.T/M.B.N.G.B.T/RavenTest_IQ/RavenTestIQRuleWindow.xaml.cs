using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

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
