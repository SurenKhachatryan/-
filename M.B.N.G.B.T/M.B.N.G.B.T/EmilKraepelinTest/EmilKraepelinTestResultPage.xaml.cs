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
using System.Windows.Controls.DataVisualization.Charting;

namespace M.B.N.G.B.T.EmilKraepelinTest
{
    /// <summary>
    /// Логика взаимодействия для EmilKraepelinTestResultPage.xaml
    /// </summary>
    public partial class EmilKraepelinTestResultPage : Page
    {
        ClassLibraryMBNGBT cl = new ClassLibraryMBNGBT();

        struct ToolkPoint
        {
            public int Second { get; private set; }
            public int Stage { get; private set; }

            public ToolkPoint(int second, int stage)
            {
                Stage = stage;
                Second = second;
            }
        }

        public EmilKraepelinTestResultPage()
        {
            InitializeComponent();
            DiagramDate();

            if (EmilKraepelinTestTablePage.ArrAllStageRightAnswers[0][0] != 0)
            {
                double tamp = (Convert.ToDouble(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[4][0])
               + Convert.ToDouble(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[5][0]) +
               Convert.ToDouble(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[6][0]) +
               Convert.ToDouble(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[7][0])) /
               (Convert.ToDouble(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[0][0]) +
               Convert.ToDouble(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[1][0]) +
               Convert.ToDouble(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[2][0]) +
               Convert.ToDouble(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[3][0]));

                if (tamp.ToString().Length > 4)
                    label1.Content = $"K-աշխ․ = {cl.DecreaseInNumbersAfterTheDecimalPoint(tamp, 2)}";
                else
                    label1.Content = $"K-աշխ․ = {tamp}";
            }
            else
                label1.Content = "K-աշխ․ = 0";
        }
        private void Button_Click_Try_Again(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EmilKraepelinTestRulePage());
        }

        private void Button_Click_Exit_Main(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
        }

        private void DiagramDate()
        {
            DiagrammaColumnSeries1.ItemsSource = new List<ToolkPoint>()
            {
               new ToolkPoint(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[0][0],1),
               new ToolkPoint(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[1][0],2),
               new ToolkPoint(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[2][0],3),
               new ToolkPoint(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[3][0],4),
               new ToolkPoint(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[4][0],5),
               new ToolkPoint(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[5][0],6),
               new ToolkPoint(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[6][0],7),
               new ToolkPoint(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[7][0],8)
            };

            DiagrammaColumnSeries2.ItemsSource = new List<ToolkPoint>()
            {
               new ToolkPoint(EmilKraepelinTestTablePage.ArrAllStageWrongAnswers[0][0],1),
               new ToolkPoint(EmilKraepelinTestTablePage.ArrAllStageWrongAnswers[1][0],2),
               new ToolkPoint(EmilKraepelinTestTablePage.ArrAllStageWrongAnswers[2][0],3),
               new ToolkPoint(EmilKraepelinTestTablePage.ArrAllStageWrongAnswers[3][0],4),
               new ToolkPoint(EmilKraepelinTestTablePage.ArrAllStageWrongAnswers[4][0],5),
               new ToolkPoint(EmilKraepelinTestTablePage.ArrAllStageWrongAnswers[5][0],6),
               new ToolkPoint(EmilKraepelinTestTablePage.ArrAllStageWrongAnswers[6][0],7),
               new ToolkPoint(EmilKraepelinTestTablePage.ArrAllStageWrongAnswers[7][0],8)
            };
            
            DiagrammaLineSeries.ItemsSource = new List<ToolkPoint>()
            {
               new ToolkPoint(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[0][0],1),
               new ToolkPoint(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[1][0],2),
               new ToolkPoint(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[2][0],3),
               new ToolkPoint(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[3][0],4),
               new ToolkPoint(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[4][0],5),
               new ToolkPoint(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[5][0],6),
               new ToolkPoint(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[6][0],7),
               new ToolkPoint(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[7][0],8)
            };

        }
    }
}
