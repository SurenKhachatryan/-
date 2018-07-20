using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace M.B.N.G.B.T.AttentivenessTest
{
    /// <summary>
    /// Логика взаимодействия для AttentivenessTestRulePage.xaml
    /// </summary>
    public partial class AttentivenessTestRulePage : Page
    {
        public AttentivenessTestRulePage()
        {
            InitializeComponent();
        }

        private void Button_Exit_The_Main(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
        }

        private void Button_Start_Test(object sender, RoutedEventArgs e)
        {
            AttentivenessTestTablePage.stage = 1;
            NavigationService.Navigate(new AttentivenessTestTablePage());
        }
    }
}
