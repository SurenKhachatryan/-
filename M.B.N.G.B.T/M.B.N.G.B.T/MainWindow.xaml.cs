using M.B.N.G.B.T.VisualMemoryTest;
using M.B.N.G.B.T.KrepelTest;
using M.B.N.G.B.T.Schulte_Test;
using M.B.N.G.B.T.V.L.Marshukov_Test;
using System.Windows;

namespace M.B.N.G.B.T
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Visual_Memory_Test(object sender, RoutedEventArgs e)
        {
            Main.NavigationService.Navigate(new VisualMemoryTestRulePage());
        }

        private void Button_Schulte_Test(object sender, RoutedEventArgs e)
        {
            Main.Content = new SchulteTestRulePage();
        }

        private void Button_VLMarshuk_Test(object sender, RoutedEventArgs e)
        {
            Main.Content = new MarshukTestRulePage();
        }

        private void Button_Krepelin_Test(object sender, RoutedEventArgs e)
        {
            Main.Content = new KrepelinTestRulePage();
        }

        private void Button_Attentiveness_Test(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Test_Eclectic_Attention(object sender, RoutedEventArgs e)
        {

        }
    }
}
