using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.DataVisualization.Charting;
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
        private int Appraisal { get; set; } = 0;

        struct ToolkPoint
        {
            public int Second { get; set; }
            public int Stage { get; set; }

            public ToolkPoint(int second, int stage)
            {
                Stage = stage;
                Second = second;
            }
        }

        public WalterSchulteTestResultPage()
        {
            InitializeComponent();

            if (WalterSchulteTestTablePage.AllowableTime == 300)
                ViewboxResult1.Visibility = Visibility.Visible;
            else
            {
                ViewBoxDiagramma.Visibility = Visibility.Visible;
                Y.Maximum = cl.GetMaxNumberInArr(WalterSchulteTestTablePage.ArrAllStageSecond) + 5;
                Diagramma.ItemsSource = new List<ToolkPoint>()
                {
                  new ToolkPoint(WalterSchulteTestTablePage.ArrAllStageSecond[0],1),
                  new ToolkPoint(WalterSchulteTestTablePage.ArrAllStageSecond[1],2),
                  new ToolkPoint(WalterSchulteTestTablePage.ArrAllStageSecond[2],3),
                  new ToolkPoint(WalterSchulteTestTablePage.ArrAllStageSecond[3],4),
                  new ToolkPoint(WalterSchulteTestTablePage.ArrAllStageSecond[4],5)
                };

                Efficiency = cl.DecreaseInNumbersAfterTheDecimalPoint(Convert.ToDouble(cl.GetSumElementsInArr(WalterSchulteTestTablePage.ArrAllStageSecond)) / Convert.ToDouble(5), 1);
                DegreeOfWorkability = cl.DecreaseInNumbersAfterTheDecimalPoint(Convert.ToDouble(WalterSchulteTestTablePage.ArrAllStageSecond[0]) / Efficiency, 1);
                MentalStability = cl.DecreaseInNumbersAfterTheDecimalPoint(Convert.ToDouble(WalterSchulteTestTablePage.ArrAllStageSecond[3]) / Efficiency, 1);

                if (Convert.ToInt16(Efficiency) >= 56)
                    Appraisal = 1;
                else
                if (Convert.ToInt16(Efficiency) >= 46 && Convert.ToInt16(Efficiency) <= 55)
                    Appraisal = 2;
                else
                if (Convert.ToInt16(Efficiency) >= 36 && Convert.ToInt16(Efficiency) <= 45)
                    Appraisal = 3;
                else
                if (Convert.ToInt16(Efficiency) >= 31 && Convert.ToInt16(Efficiency) <= 35)
                    Appraisal = 4;
                else
                if (Convert.ToInt16(Efficiency) <= 30)
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
