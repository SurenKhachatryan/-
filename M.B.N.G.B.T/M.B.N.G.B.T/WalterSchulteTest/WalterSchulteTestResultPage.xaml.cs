using ClassLibrary;
using System;
using System.Collections.Generic;
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
                ViewBoxTitile.Visibility = Visibility.Visible;
                ViewboxTextBlockInfo1.Visibility = Visibility.Visible;
                ViewBoxRectangles.Visibility = Visibility.Visible;
                ViewBoxLabels.Visibility = Visibility.Visible;
                ViewBoxLabelsAndTextBlocks.Visibility = Visibility.Visible;

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

                LabelAppraisa.Content += $"{efficiency}";
                for (int i = 0; i < WalterSchulteTestTablePage.ArrAllStageSecond.Length; i++)
                {
                    if (i == 0)
                        LabelAppraisa.Content += " ((";
                    if (i + 1 != WalterSchulteTestTablePage.ArrAllStageSecond.Length)
                        LabelAppraisa.Content += $"{WalterSchulteTestTablePage.ArrAllStageSecond[i]} + ";
                    else
                        LabelAppraisa.Content += $"{WalterSchulteTestTablePage.ArrAllStageSecond[i]} )/5)";
                }

                if (Convert.ToInt16(efficiency) >= 56)
                    RectengleAppraisal5.Fill = (RectengleAppraisal10.Fill = (Brush)(new BrushConverter().ConvertFrom("#FFFF3204")));
                else
                if (Convert.ToInt16(efficiency) >= 46 && Convert.ToInt16(efficiency) <= 55)
                    RectengleAppraisal4.Fill = (RectengleAppraisal9.Fill = (Brush)(new BrushConverter().ConvertFrom("#FFE08313")));
                else
                if (Convert.ToInt16(efficiency) >= 36 && Convert.ToInt16(efficiency) <= 45)
                    RectengleAppraisal3.Fill = (RectengleAppraisal8.Fill = (Brush)(new BrushConverter().ConvertFrom("#FFDCAA00")));
                else
                if (Convert.ToInt16(efficiency) >= 31 && Convert.ToInt16(efficiency) <= 35)
                    RectengleAppraisal2.Fill = (RectengleAppraisal7.Fill = (Brush)(new BrushConverter().ConvertFrom("#FF6EA21F")));
                else
                if (Convert.ToInt16(efficiency) <= 30)
                    RectengleAppraisal1.Fill = (RectengleAppraisal6.Fill = Brushes.Green);


                if (degreeOfWorkability <= 1.0)
                {
                    LabelDegreeOfWorkability.Content += $"{degreeOfWorkability} ,որը համարվում է բարձր ցուցանիշ։";
                    TextBlockMentalStability1.Visibility = Visibility.Visible;
                }
                else
                {
                    LabelDegreeOfWorkability.Content += $"{degreeOfWorkability} ,որը համարվում է ցածր ցուցանիշ։";
                    LabelDegreeOfWorkabilityinfo.Visibility = Visibility.Visible;
                    TextBlockMentalStability2.Visibility = Visibility.Visible;
                }

                if (mentalStability <= 1.0)
                    LabelMentalStability.Content += $"{mentalStability} ,որը համարվում է բարձր ցուցանիշ։";
                else
                    LabelMentalStability.Content += $"{mentalStability} , որը համարվում է ցածր ցուցանիշ։ Ձեր ՀԿ ցուցանիշը թույլ չի տալիս տվյալ\nհանձնարարությունը նույն տեմպով կատարել մինչև վերջ։";
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
