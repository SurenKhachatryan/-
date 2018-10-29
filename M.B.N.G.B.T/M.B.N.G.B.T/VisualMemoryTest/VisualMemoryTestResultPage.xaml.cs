using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace M.B.N.G.B.T.VisualMemoryTest
{
    /// <summary>
    /// Логика взаимодействия для ResultPage.xaml
    /// </summary>
    public partial class VisualMemoryTestResultPage : Page
    {
        public VisualMemoryTestResultPage()
        {
            InitializeComponent();
            if (VisualMemoryTestRandomPicturesPage.stage != 1)
                LabelPercent.Content = $"Ձեր տեսողական հիշողության զարգացվածության ցուցանիշը - {(VisualMemoryTestRandomPicturesPage.stage - 1) * 10}%";
        }

        private void Button_Click_Exit_Main(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
            Process.Start(Application.ResourceAssembly.Location);
        }

        private void Button_Click_Try_Again(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
        }
    }
}
