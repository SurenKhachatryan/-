using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace M.B.N.G.B.T.VisualMemoryTest
{
    /// <summary>
    /// Логика взаимодействия для ResultPage.xaml
    /// </summary>
    public partial class VisualMemoryTestResultPage : Page
    {
        private int percent = 0;

        public VisualMemoryTestResultPage()
        {
            InitializeComponent();

            if (VisualMemoryTestRandomPicturesPage.stage != 1)
                percent = (VisualMemoryTestRandomPicturesPage.stage - 1) * 10;
            else
                percent = 0;

            LabelPercent.Content += $"{percent}%";

            if (percent <= 20)
                labelPercent_1_1.Background = (labelPercent_1_2.Background = (Brush)(new BrushConverter().ConvertFrom("#FFFF0505")));
            else
              if (percent >= 30 && percent <= 40)
                labelPercent_2_1.Background = (labelPercent_2_2.Background = (Brush)(new BrushConverter().ConvertFrom("#FFFF5C10")));
            else
              if (percent >= 50 && percent <= 60)
                labelPercent_3_1.Background = (labelPercent_3_2.Background = (Brush)(new BrushConverter().ConvertFrom("#FFB8A009")));
            else
              if (percent > 70 && percent <= 80)
                labelPercent_4_1.Background = (labelPercent_4_2.Background = (Brush)(new BrushConverter().ConvertFrom("#FF60BF01")));
            else
              if (percent >= 90)
                labelPercent_5_1.Background = (labelPercent_5_2.Background = (Brush)(new BrushConverter().ConvertFrom("#FF008118")));

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
