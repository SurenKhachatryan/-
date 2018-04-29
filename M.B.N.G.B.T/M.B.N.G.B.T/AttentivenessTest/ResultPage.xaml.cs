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
            if (RandomPicturesPage.stage != 1)
            {
                LabelPercent.Content = $"{(RandomPicturesPage.stage-1) * 10}%";
            }

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Rule());
        }
    }
}
