using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace M.B.N.G.B.T.TestEclecticAttention
{
    /// <summary>
    /// Логика взаимодействия для TestEclecticAttentionRulePage.xaml
    /// </summary>
    public partial class TestEclecticAttentionRulePage : Page
    {
        public TestEclecticAttentionRulePage()
        {
            InitializeComponent();
        }

        private void Button_Exit_the_Main(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
        }

        private void Button_Start_Test(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TestEclecticAttentionTablePage());
        }
    }
}
