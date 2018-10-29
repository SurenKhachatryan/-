using System.Diagnostics;
using System.Windows;

namespace M.B.N.G.B.T.TestEclecticAttention
{
    /// <summary>
    /// Логика взаимодействия для TestEclecticAttentionRuleWindow.xaml
    /// </summary>
    public partial class TestEclecticAttentionRuleWindow : Window
    {
        public TestEclecticAttentionRuleWindow()
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
            Main.NavigationService.Navigate(new TestEclecticAttentionTablePage());
        }
    }
}
