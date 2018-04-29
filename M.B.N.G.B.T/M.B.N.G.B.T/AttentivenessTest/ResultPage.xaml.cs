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
            NavigationService.Navigate(null);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            RandomPicturesPage.picturesCount = 4;
            this.NavigationService.Navigate(new Rule());
        }

        public void ResultPageCollapsed()
        {
            ResultPage1.Visibility = Visibility.Collapsed;
           
        }
    }
}
