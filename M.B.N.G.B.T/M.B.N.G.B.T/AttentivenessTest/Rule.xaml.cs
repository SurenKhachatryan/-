using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace M.B.N.G.B.T.AttentivenessTest
{
    /// <summary>
    /// Логика взаимодействия для Rule.xaml
    /// </summary>
    public partial class Rule : Page
    {
        public Rule()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TestRuleCollapsed();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            RandomPicturesPage.picturesCount = 2;
            RandomPicturesPage.stage = 1;
            NavigationService.Navigate(new RandomPicturesPage());
        }
        public void TestRuleCollapsed()
        {
           NavigationService.Navigate(null);
        }
    }
}
