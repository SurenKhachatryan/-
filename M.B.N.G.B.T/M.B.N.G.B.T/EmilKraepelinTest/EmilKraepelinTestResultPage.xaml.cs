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
            initializerPowerFactor();
            InitializerLaborProductivityIndicator();
        }

        private void initializerPowerFactor()
        {
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

            if (powerFactorTemp <= 1.06d && powerFactorTemp >= 0.94d)
                labelResultPowerFactor_1.Visibility = Visibility.Visible;
            else
            if (powerFactorTemp > 1.06d)
                labelResultPowerFactor_2.Visibility = Visibility.Visible;
            else
            if (powerFactorTemp < 0.94d && powerFactorTemp != 0.0d)
                labelResultPowerFactor_3.Visibility = Visibility.Visible;
            else
            if (powerFactorTemp == 0.0d)
                labelResultPowerFactor_4.Visibility = Visibility.Visible;
        }

        private void InitializerLaborProductivityIndicator()
        {
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

            int counter;
            bool bl = IsHesitation(out counter);

            if (bl && counter > 2)
                labelLaborProductivityIndicatorResult_1.Visibility = Visibility.Visible;
            else
            if (bl && counter <= 2 && counter != 0)
                labelLaborProductivityIndicatorResult_3.Visibility = Visibility.Visible;

            if (IsBig_7_and_8_Colums())
                labelLaborProductivityIndicatorResult_2.Visibility = Visibility.Visible;
        }

        private bool IsBig_7_and_8_Colums()
        {
            bool bl = false;
            if (EmilKraepelinTestTablePage.ArrAllStageRightAnswers[6][0] != 0 ||
                EmilKraepelinTestTablePage.ArrAllStageRightAnswers[7][0] != 0)
                bl = false;
            else
            if ((EmilKraepelinTestTablePage.ArrAllStageRightAnswers[6][0] +
                EmilKraepelinTestTablePage.ArrAllStageRightAnswers[7][0])
                                             >
                (EmilKraepelinTestTablePage.ArrAllStageRightAnswers[0][0] +
                EmilKraepelinTestTablePage.ArrAllStageRightAnswers[1][0] +
                EmilKraepelinTestTablePage.ArrAllStageRightAnswers[2][0] +
                EmilKraepelinTestTablePage.ArrAllStageRightAnswers[3][0] +
                EmilKraepelinTestTablePage.ArrAllStageRightAnswers[4][0] +
                EmilKraepelinTestTablePage.ArrAllStageRightAnswers[5][0]))
                bl = true;

            return bl;
        }

        /// <summary>
        /// Проверяет есть ли серьезные калибания между стобцами
        /// </summary>
        /// <returns></returns>
        private bool IsHesitation(out int counter)
        {
            bool bl = false;
            int temp = 0;
            counter = 0;

            for (int i = 0; i < EmilKraepelinTestTablePage.ArrAllStageRightAnswers.Length - 1; i++)
            {
                if (EmilKraepelinTestTablePage.ArrAllStageRightAnswers[i][0] <= 6)
                    temp = 1;
                else
                if (EmilKraepelinTestTablePage.ArrAllStageRightAnswers[i][0] <= 13)
                    temp = 2;
                else
                if (EmilKraepelinTestTablePage.ArrAllStageRightAnswers[i][0] <= 20)
                    temp = 3;
                else
                if (EmilKraepelinTestTablePage.ArrAllStageRightAnswers[i][0] <= 27)
                    temp = 4;
                else
                if (EmilKraepelinTestTablePage.ArrAllStageRightAnswers[i][0] > 27)
                    temp = 5;

                if (EmilKraepelinTestTablePage.ArrAllStageRightAnswers[i][0] <
                    EmilKraepelinTestTablePage.ArrAllStageRightAnswers[i + 1][0])
                {
                    temp += EmilKraepelinTestTablePage.ArrAllStageRightAnswers[i][0];
                    if (temp <= EmilKraepelinTestTablePage.ArrAllStageRightAnswers[i + 1][0])
                    {
                        bl = true;
                        counter++;
                    }
                }
                else
                {
                    temp = EmilKraepelinTestTablePage.ArrAllStageRightAnswers[i][0] - temp;
                    if (temp >= EmilKraepelinTestTablePage.ArrAllStageRightAnswers[i + 1][0])
                    {
                        bl = true;
                        counter++;
                    }
                }
            }

            return bl;
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
