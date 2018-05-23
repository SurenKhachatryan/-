using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace M.B.N.G.B.T.VisualMemoryTest
{
    /// <summary>
    /// Логика взаимодействия для Rule.xaml
    /// </summary>
    public partial class VisualMemoryTestRulePage : Page
    {
        public VisualMemoryTestRulePage()
        {
            InitializeComponent();
        }
        private void Button_Exit_The_Main(object sender, RoutedEventArgs e)
        {
            TestRuleCollapsed();
        }

        private void Button_Start_Test(object sender, RoutedEventArgs e)
        {
            VisualMemoryTestRandomPicturesPage.picturesCount = 2;
            VisualMemoryTestRandomPicturesPage.stage = 1;
            NavigationService.Navigate(new VisualMemoryTestRandomPicturesPage());
        }
        public void TestRuleCollapsed()
        {
           NavigationService.Navigate(null);
        }
    }
}
