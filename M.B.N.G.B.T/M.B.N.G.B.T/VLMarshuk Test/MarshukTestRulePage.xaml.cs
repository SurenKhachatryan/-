using M.B.N.G.B.T.V.L.Marshuk_Test;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace M.B.N.G.B.T.V.L.Marshukov_Test
{
    /// <summary>
    /// Логика взаимодействия для MarshukTestRulePage.xaml
    /// </summary>
    public partial class MarshukTestRulePage : Page
    {
        public MarshukTestRulePage()
        {
            InitializeComponent();
        }

        private void Button_Exit_The_Main(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
        }

        private void Button_Start_Test(object sender, RoutedEventArgs e)
        {
            MarshukTestTablePage.arrAllStageRandomDigits = new int[5][];
            MarshukTestTablePage.arrAllStageDigitsInTextBox = new int[5][];
            MarshukTestTablePage.arrAllStageRightNumbers = new int[5][];
            MarshukTestTablePage.arrAllStageAbsentNumbers = new int[5][];
            MarshukTestTablePage.arrAllStageExtraNumbers = new int[5][];
            MarshukTestTablePage.stage = 1;
            NavigationService.Navigate(new MarshukTestTablePage());
        }
    }
}
