using System.Windows;
using System.Windows.Controls;

namespace M.B.N.G.B.T.AttentivenessTest
{
    /// <summary>
    /// Логика взаимодействия для ResultPage.xaml
    /// </summary>
    public partial class ResultPage : Page
    {
        public ResultPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            RandomPicturesPage.startstage = 4;
            MainResultPage.Content = new Rule();
        }

        public void ResultPageCollapsed()
        {
            ResultPage1.Visibility = Visibility.Collapsed;
           
        }
    }
}
