using System.Diagnostics;
using System.Windows;

namespace M.B.N.G.B.T.VisualMemoryTest
{
    /// <summary>
    /// Логика взаимодействия для VisualMemoryTestRuleWindow.xaml
    /// </summary>
    public partial class VisualMemoryTestRuleWindow : Window
    {
        public VisualMemoryTestRuleWindow()
        {
            InitializeComponent();
        }

        private void Button_Exit_The_Main(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
            Process.Start(Application.ResourceAssembly.Location);
        }

        private void Button_Start_Test(object sender, RoutedEventArgs e)
        {
            VisualMemoryTestRandomPicturesPage.stage = 1;
            Main.NavigationService.Navigate(new VisualMemoryTestRandomPicturesPage());
        }
    }
}
