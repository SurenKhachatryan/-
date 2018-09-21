using System.Windows;
using System.Windows.Input;
using M.B.N.G.B.T.VisualMemoryTest;
using M.B.N.G.B.T.AttentivenessTest;
using M.B.N.G.B.T.TestEclecticAttention;
using M.B.N.G.B.T.ConcentrationDefinitionTest;
using M.B.N.G.B.T.WalterSchulteTest;
using M.B.N.G.B.T.EmilKraepelinTest;
using M.B.N.G.B.T.RavenTest_IQ;

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
            Main.Content = new WalterSchulteTestRulePage();
        }

        private void Button_VLMarshuk_Test(object sender, RoutedEventArgs e)
        {
            Main.Content = new ConcentrationDefinitionTestRulePage();
        }

        private void Button_Krepelin_Test(object sender, RoutedEventArgs e)
        {
            Main.Content = new EmilKraepelinTestRulePage();
        }

        private void Button_Attentiveness_Test(object sender, RoutedEventArgs e)
        {
            Main.Content = new AttentivenessTestRulePage();
        }

        private void Button_Test_Eclectic_Attention(object sender, RoutedEventArgs e)
        {
            Main.Content = new TestEclecticAttentionRulePage();
        }

        private void Button_Test_Raven_IQ(object sender, RoutedEventArgs e)
        {
            Main.Content = new RavenTestIQRulePage();
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Tab)
                e.Handled = true;
        }

        private void Button_Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
