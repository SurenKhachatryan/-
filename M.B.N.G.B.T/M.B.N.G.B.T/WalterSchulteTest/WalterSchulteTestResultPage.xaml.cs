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
        private double Efficiency { get; set; } = 0;
        private double DegreeOfWorkability { get; set; } = 0;
        private double MentalStability { get; set; } = 0;
        private double Appraisal { get; set; } = 0;

        public WalterSchulteTestResultPage()
        {
            InitializeComponent();

            if (WalterSchulteTestTablePage.AllowableTime == 300)
                ViewboxResult1.Visibility = Visibility.Visible;
            else
            {
                Efficiency = cl.DecreaseInNumbersAfterTheDecimalPoint(Convert.ToDouble(cl.GetSumElementsInArr(WalterSchulteTestTablePage.ArrAllStageSecond)) / Convert.ToDouble(5), 1);
                DegreeOfWorkability = cl.DecreaseInNumbersAfterTheDecimalPoint(Convert.ToDouble(WalterSchulteTestTablePage.ArrAllStageSecond[0]) / Efficiency, 1);
                MentalStability = cl.DecreaseInNumbersAfterTheDecimalPoint(Convert.ToDouble(WalterSchulteTestTablePage.ArrAllStageSecond[3]) / Efficiency, 1);

                if (Efficiency >= 56)
                    Appraisal = 1;
                else
                if (Efficiency >= 46 && Efficiency <= 55)
                    Appraisal = 2;
                else
                if (Efficiency >= 36 && Efficiency <= 45)
                    Appraisal = 3;
                else
                if (Efficiency >= 31 && Efficiency <= 35)
                    Appraisal = 4;
                else
                if (Efficiency <= 30)
                    Appraisal = 5;

                if (DegreeOfWorkability <= 1.0)
                {

                }
                else
                {

                }

                if (MentalStability <= 1.0)
                {

                }
                else
                {

                }
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
