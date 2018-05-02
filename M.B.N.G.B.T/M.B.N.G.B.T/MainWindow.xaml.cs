using M.B.N.G.B.T.AttentivenessTest;
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

        private void Button_Attentiveness_Test(object sender, RoutedEventArgs e)
        {
            Main.NavigationService.Navigate(new AttentivenessTestRulePage());
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
    }
}
