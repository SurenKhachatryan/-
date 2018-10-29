using System.Diagnostics;
using System.Windows;

namespace M.B.N.G.B.T.EmilKraepelinTest
{
    /// <summary>
    /// Логика взаимодействия для EmilKraepelinTestRuleWindow.xaml
    /// </summary>
    public partial class EmilKraepelinTestRuleWindow : Window
    {
        public EmilKraepelinTestRuleWindow()
        {
            InitializeComponent();
        }

        private void Button_Exit_the_Main(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
            Process.Start(Application.ResourceAssembly.Location);
        }

        private void Button_Start_Test(object sender, RoutedEventArgs e)
        {
            EmilKraepelinTestTablePage.stage = 1;
            Main.NavigationService.Navigate(new EmilKraepelinTestTablePage());
        }
    }
}
