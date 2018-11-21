using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;

namespace M.B.N.G.B.T.WalterSchulteTest
{
    /// <summary>
    /// Логика взаимодействия для WalterSchulteTestResultPage.xaml
    /// </summary>
    public partial class WalterSchulteTestResultPage : Page
    {
        private ClassLibraryMBNGBT cl = new ClassLibraryMBNGBT();
        private double efficiency = 0;
        private double degreeOfWorkability = 0;
        private double mentalStability = 0;

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

        public WalterSchulteTestResultPage()
        {
            InitializeComponent();

            if (WalterSchulteTestTablePage.AllowableTime >= 300)
                ViewboxlabelInfo.Visibility = Visibility.Visible;
            else
            {
                ViewBoxDiagramma.Visibility = Visibility.Visible;
                ViewBoxAllWrapPanels.Visibility = Visibility.Visible;

                Y.Maximum = cl.GetMaxNumberInArr(WalterSchulteTestTablePage.ArrAllStageSecond) + 5;
                Diagramma.ItemsSource = new List<ToolkPoint>()
                {
                  new ToolkPoint(WalterSchulteTestTablePage.ArrAllStageSecond[0],1),
                  new ToolkPoint(WalterSchulteTestTablePage.ArrAllStageSecond[1],2),
                  new ToolkPoint(WalterSchulteTestTablePage.ArrAllStageSecond[2],3),
                  new ToolkPoint(WalterSchulteTestTablePage.ArrAllStageSecond[3],4),
                  new ToolkPoint(WalterSchulteTestTablePage.ArrAllStageSecond[4],5)
                };

                efficiency = cl.DecreaseInNumbersAfterTheDecimalPoint(Convert.ToDouble(cl.GetSumElementsInArr(WalterSchulteTestTablePage.ArrAllStageSecond)) / Convert.ToDouble(5), 1);
                degreeOfWorkability = cl.DecreaseInNumbersAfterTheDecimalPoint(Convert.ToDouble(WalterSchulteTestTablePage.ArrAllStageSecond[0]) / efficiency, 1);
                mentalStability = cl.DecreaseInNumbersAfterTheDecimalPoint(Convert.ToDouble(WalterSchulteTestTablePage.ArrAllStageSecond[3]) / efficiency, 1);

                labelAppraisa.Content += $"{efficiency}";
                for (int i = 0; i < WalterSchulteTestTablePage.ArrAllStageSecond.Length; i++)
                {
                    if (i == 0)
                        labelAppraisaСalculation.Content += " ((";
                    if (i + 1 != WalterSchulteTestTablePage.ArrAllStageSecond.Length)
                        labelAppraisaСalculation.Content += $"{WalterSchulteTestTablePage.ArrAllStageSecond[i]} + ";
                    else
                        labelAppraisaСalculation.Content += $"{WalterSchulteTestTablePage.ArrAllStageSecond[i]} ) / 5)";
                }

                if (Convert.ToInt16(efficiency) >= 56)
                    LabelAppraisal_5_1.Background = (LabelAppraisal_5_2.Background = (Brush)(new BrushConverter().ConvertFrom("#FFFF3204")));
                else
                if (Convert.ToInt16(efficiency) >= 46 && Convert.ToInt16(efficiency) <= 55)
                    LabelAppraisal_4_1.Background = (LabelAppraisal_4_2.Background = (Brush)(new BrushConverter().ConvertFrom("#FFE08313")));
                else
                if (Convert.ToInt16(efficiency) >= 36 && Convert.ToInt16(efficiency) <= 45)
                    LabelAppraisal_3_1.Background = (LabelAppraisal_3_2.Background = (Brush)(new BrushConverter().ConvertFrom("#FFDCAA00")));
                else
                if (Convert.ToInt16(efficiency) >= 31 && Convert.ToInt16(efficiency) <= 35)
                    LabelAppraisal_2_1.Background = (LabelAppraisal_2_2.Background = (Brush)(new BrushConverter().ConvertFrom("#FF6EA21F")));
                else
                if (Convert.ToInt16(efficiency) <= 30)
                    LabelAppraisal_1_1.Background = (LabelAppraisal_1_2.Background = Brushes.Green);


                LabelDegreeOfWorkability.Content += $"{degreeOfWorkability}";
                LabelDegreeOfWorkabilityCalculation.Content = $"({WalterSchulteTestTablePage.ArrAllStageSecond[0]} / {efficiency})";
                LabelMentalStability.Content += $"{mentalStability}";
                LabelMentalStabilityCalculation.Content = $"({WalterSchulteTestTablePage.ArrAllStageSecond[3]} / {efficiency})";

                if (degreeOfWorkability <= 1.0)
                    LabelDegreeOfWorkabilityResult.Content = "Այն  համարվում  է  բարձր  ցուցանիշ։";
                else
                    LabelDegreeOfWorkabilityResult.Content = "Այն համարվում է ցածր ցուցանիշ։ Դուք առաջին փուլի\nվրա  առավել երկար ժամանակ եք ծախսել, քան  միջին\nցուցանիշն է։  Աշխատունակության  ցուցանիշը  բարձր\nկլինի այն դեպքում, երբ  ի սկզբանե  պատրաստ  լինեք\nհիմնական  աշխատանքին։";


                if (mentalStability <= 1.0)
                    LabelMentalStabilityResult.Content += "Այն  համարվում  է  բարձր  ցուցանիշ։";
                else
                    LabelMentalStabilityResult.Content += "Այն   համարվում   է   ցածր    ցուցանիշ։   Ձեր   Հոգեկան\nկայունության (ՀԿ)  ցուցանիշը   թույլ  չի  տալիս  տվյալ\nհանձնարարությունը  նույն  տեմպով   կատարել  մինչև\nվերջ։";
            }

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
    }
}
