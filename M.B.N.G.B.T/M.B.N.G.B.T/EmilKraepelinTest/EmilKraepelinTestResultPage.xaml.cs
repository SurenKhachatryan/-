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
            ((ColumnSeries)Diagramma.Series[0]).ItemsSource = new KeyValuePair<int, int>[] {
             new KeyValuePair<int, int>(1, EmilKraepelinTestTablePage.ArrAllStageRightAnswers[0][0]),
             new KeyValuePair<int, int>(2, EmilKraepelinTestTablePage.ArrAllStageRightAnswers[1][0]),
             new KeyValuePair<int, int>(3, EmilKraepelinTestTablePage.ArrAllStageRightAnswers[2][0]),
             new KeyValuePair<int, int>(4, EmilKraepelinTestTablePage.ArrAllStageRightAnswers[3][0]),
             new KeyValuePair<int, int>(5, EmilKraepelinTestTablePage.ArrAllStageRightAnswers[4][0]),
             new KeyValuePair<int, int>(6, EmilKraepelinTestTablePage.ArrAllStageRightAnswers[5][0]),
             new KeyValuePair<int, int>(7, EmilKraepelinTestTablePage.ArrAllStageRightAnswers[6][0]),
             new KeyValuePair<int, int>(8, EmilKraepelinTestTablePage.ArrAllStageRightAnswers[7][0])};


            ((ColumnSeries)Diagramma.Series[1]).ItemsSource = new KeyValuePair<int, int>[]{
             new KeyValuePair<int, int>(1, EmilKraepelinTestTablePage.ArrAllStageWrongAnswers[0][0]),
             new KeyValuePair<int, int>(2, EmilKraepelinTestTablePage.ArrAllStageWrongAnswers[1][0]),
             new KeyValuePair<int, int>(3, EmilKraepelinTestTablePage.ArrAllStageWrongAnswers[2][0]),
             new KeyValuePair<int, int>(4, EmilKraepelinTestTablePage.ArrAllStageWrongAnswers[3][0]),
             new KeyValuePair<int, int>(5, EmilKraepelinTestTablePage.ArrAllStageWrongAnswers[4][0]),
             new KeyValuePair<int, int>(6, EmilKraepelinTestTablePage.ArrAllStageWrongAnswers[5][0]),
             new KeyValuePair<int, int>(7, EmilKraepelinTestTablePage.ArrAllStageWrongAnswers[6][0]),
             new KeyValuePair<int, int>(8, EmilKraepelinTestTablePage.ArrAllStageWrongAnswers[7][0])};

            ((LineSeries)Diagramma.Series[2]).ItemsSource = new KeyValuePair<int, int>[]{
            new KeyValuePair<int, int>(1, EmilKraepelinTestTablePage.ArrAllStageRightAnswers[0][0]),
            new KeyValuePair<int, int>(2, EmilKraepelinTestTablePage.ArrAllStageRightAnswers[1][0]),
            new KeyValuePair<int, int>(3, EmilKraepelinTestTablePage.ArrAllStageRightAnswers[2][0]),
            new KeyValuePair<int, int>(4, EmilKraepelinTestTablePage.ArrAllStageRightAnswers[3][0]),
            new KeyValuePair<int, int>(5, EmilKraepelinTestTablePage.ArrAllStageRightAnswers[4][0]),
            new KeyValuePair<int, int>(6, EmilKraepelinTestTablePage.ArrAllStageRightAnswers[5][0]),
            new KeyValuePair<int, int>(7, EmilKraepelinTestTablePage.ArrAllStageRightAnswers[6][0]),
            new KeyValuePair<int, int>(8, EmilKraepelinTestTablePage.ArrAllStageRightAnswers[7][0])};


        }
    }
}
