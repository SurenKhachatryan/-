using System.Diagnostics;
using System.Windows;

namespace M.B.N.G.B.T.WalterSchulteTest
{
    /// <summary>
    /// Логика взаимодействия для WalterSchulteTestRuleWindow.xaml
    /// </summary>
    public partial class WalterSchulteTestRuleWindow : Window
    {
        public WalterSchulteTestRuleWindow()
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
            WalterSchulteTestTablePage.Stage = 1;
            Main.NavigationService.Navigate(new WalterSchulteTestTablePage());
        }
    }
}
