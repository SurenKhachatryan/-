using System.Diagnostics;
using System.Windows;

namespace M.B.N.G.B.T.AttentivenessTest
{
    /// <summary>
    /// Логика взаимодействия для AttentivenessTestRuleWindow.xaml
    /// </summary>
    public partial class AttentivenessTestRuleWindow : Window
    {
        public AttentivenessTestRuleWindow()
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
            AttentivenessTestTablePage.stage = 1;
            Main.NavigationService.Navigate(new AttentivenessTestTablePage());
        }
    }
}
