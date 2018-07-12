using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace M.B.N.G.B.T.WalterSchulteTest
{
    /// <summary>
    /// Логика взаимодействия для WalterSchulteTestResultPage.xaml
    /// </summary>
    public partial class WalterSchulteTestResultPage : Page
    {
        private ClassLibraryMBNGBT cl = new ClassLibraryMBNGBT();
        private int Efficiency { get; set; } = 0;
        private int DegreeOfWorkability { get; set; } = 0;
        private int MentalStability { get; set; } = 0;

        public WalterSchulteTestResultPage()
        {
            InitializeComponent();

            Efficiency = cl.GetSumElementsInArr(WalterSchulteTestTablePage.ArrAllStageSecond) / 5;
            DegreeOfWorkability = WalterSchulteTestTablePage.ArrAllStageSecond[0] / Efficiency;
            MentalStability = WalterSchulteTestTablePage.ArrAllStageSecond[3] / Efficiency;

            if (WalterSchulteTestTablePage.AllowableTime == 300)
            {
                ViewboxResult1.Visibility = Visibility.Visible;
            }
            else
            {

            }

        }

        private void Button_Click_Try_Again(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new WalterSchulteTestRulePage());
        }

        private void Button_Click_Exit_Main(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
        }
    }
}
