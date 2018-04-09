using System.Windows;
using System.Windows.Controls;

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
            MainRule.Content = new RandomPicturesPage();
        }
        public void TestRuleCollapsed()
        {
            TestRule.Visibility = Visibility.Collapsed;
        }
        
    }
}
