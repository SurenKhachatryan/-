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
                LabelPercent.Content = $"Ձեր տեսողական հիշողությունը զարգացած է {(RandomPicturesPage.stage-1) * 10}%";
            }
        }

        private void button_Click_Exit_Main(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
        }

        private void button_Click_try_again(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AttentivenessTestRulePage());
        }
    }
}
