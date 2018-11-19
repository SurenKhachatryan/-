using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;

namespace M.B.N.G.B.T.EmilKraepelinTest
{
    /// <summary>
    /// Логика взаимодействия для EmilKraepelinTestResultPage.xaml
    /// </summary>
    public partial class EmilKraepelinTestResultPage : Page
    {
        private ClassLibraryMBNGBT cl = new ClassLibraryMBNGBT();

        private double powerFactorTemp = 0.0d;
        private int tampLaborProductivityIndicatorTemp = 0;

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
                powerFactorTemp = (Convert.ToDouble(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[4][0]) +
                                   Convert.ToDouble(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[5][0]) +
                                   Convert.ToDouble(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[6][0]) +
                                   Convert.ToDouble(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[7][0]))
                                                               /
                                  (Convert.ToDouble(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[0][0]) +
                                   Convert.ToDouble(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[1][0]) +
                                   Convert.ToDouble(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[2][0]) +
                                   Convert.ToDouble(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[3][0]));

                if (powerFactorTemp.ToString().Length > 4)
                    labelPowerFactor.Content += $"{cl.DecreaseInNumbersAfterTheDecimalPoint(powerFactorTemp, 2)}";
                else
                    labelPowerFactor.Content += $"{powerFactorTemp}";
            }
            else
                labelPowerFactor.Content += "0";

            labelPowerFactorСalculation.Content = $"({Convert.ToDouble(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[4][0]) + Convert.ToDouble(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[5][0]) + Convert.ToDouble(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[6][0]) + Convert.ToDouble(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[7][0])}"
                                                     + " / " +
                                                   $"{ Convert.ToDouble(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[0][0]) + Convert.ToDouble(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[1][0]) + Convert.ToDouble(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[2][0]) + Convert.ToDouble(EmilKraepelinTestTablePage.ArrAllStageRightAnswers[3][0])})";

            if (powerFactorTemp <= 1.5d && powerFactorTemp >= 0.96d)
                labelResultPowerFactor_1.Visibility = Visibility.Visible;
            else
              if (powerFactorTemp > 1.5d)
                labelResultPowerFactor_2.Visibility = Visibility.Visible;
            else
              if (powerFactorTemp < 0.96d && powerFactorTemp != 0.0d)
                labelResultPowerFactor_3.Visibility = Visibility.Visible;
            else
              if (powerFactorTemp == 0.0d)
                labelResultPowerFactor_4.Visibility = Visibility.Visible;



            tampLaborProductivityIndicatorTemp = (EmilKraepelinTestTablePage.ArrAllStageRightAnswers[4][0] +
                                                  EmilKraepelinTestTablePage.ArrAllStageRightAnswers[5][0] +
                                                  EmilKraepelinTestTablePage.ArrAllStageRightAnswers[6][0] +
                                                  EmilKraepelinTestTablePage.ArrAllStageRightAnswers[7][0] +
                                                  EmilKraepelinTestTablePage.ArrAllStageRightAnswers[0][0] +
                                                  EmilKraepelinTestTablePage.ArrAllStageRightAnswers[1][0] +
                                                  EmilKraepelinTestTablePage.ArrAllStageRightAnswers[2][0] +
                                                  EmilKraepelinTestTablePage.ArrAllStageRightAnswers[3][0]) / 8;

            labelLaborProductivityIndicator.Content += $"{tampLaborProductivityIndicatorTemp}";
            labelLaborProductivityIndicatorСalculation.Content = $"({EmilKraepelinTestTablePage.ArrAllStageRightAnswers[0][0]}" +
                                                                 $" + {EmilKraepelinTestTablePage.ArrAllStageRightAnswers[1][0]}" +
                                                                 $" + {EmilKraepelinTestTablePage.ArrAllStageRightAnswers[2][0]}" +
                                                                 $" + {EmilKraepelinTestTablePage.ArrAllStageRightAnswers[3][0]}" +
                                                                 $" + {EmilKraepelinTestTablePage.ArrAllStageRightAnswers[4][0]}" +
                                                                 $" + {EmilKraepelinTestTablePage.ArrAllStageRightAnswers[5][0]}" +
                                                                 $" + {EmilKraepelinTestTablePage.ArrAllStageRightAnswers[6][0]}" +
                                                                 $" + {EmilKraepelinTestTablePage.ArrAllStageRightAnswers[7][0]}) / 8";

            if (tampLaborProductivityIndicatorTemp < 6)
                LabelAppraisal_5_1.Background = (LabelAppraisal_5_2.Background = (Brush)(new BrushConverter().ConvertFrom("#FFFF3204")));
            else
            if (tampLaborProductivityIndicatorTemp >= 6 && tampLaborProductivityIndicatorTemp < 12)
                LabelAppraisal_4_1.Background = (LabelAppraisal_4_2.Background = (Brush)(new BrushConverter().ConvertFrom("#FFE08313")));
            else
            if (tampLaborProductivityIndicatorTemp >= 12 && tampLaborProductivityIndicatorTemp < 20)
                LabelAppraisal_3_1.Background = (LabelAppraisal_3_2.Background = (Brush)(new BrushConverter().ConvertFrom("#FFDCAA00")));
            else
            if (tampLaborProductivityIndicatorTemp >= 20 && tampLaborProductivityIndicatorTemp < 23)
                LabelAppraisal_2_1.Background = (LabelAppraisal_2_2.Background = (Brush)(new BrushConverter().ConvertFrom("#FF6EA21F")));
            else
            if (tampLaborProductivityIndicatorTemp <= 23)
                LabelAppraisal_1_1.Background = (LabelAppraisal_1_2.Background = Brushes.Green);
        }

        private void Button_Click_Try_Again(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
        }

        private void Button_Click_Exit_Main(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
            Process.Start(Application.ResourceAssembly.Location);
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
