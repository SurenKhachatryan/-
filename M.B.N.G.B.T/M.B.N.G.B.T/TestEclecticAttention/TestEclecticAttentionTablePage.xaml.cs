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

namespace M.B.N.G.B.T.TestEclecticAttention
{
    /// <summary>
    /// Логика взаимодействия для TestEclecticAttentionTablePage.xaml
    /// </summary>
    public partial class TestEclecticAttentionTablePage : Page
    {
        public TestEclecticAttentionTablePage()
        {
            InitializeComponent();
        }

        private void Button_Exit_The_Test_View_Result(object sender, RoutedEventArgs e)
        {

        }

        private void LabelNumber1_MouseEnter(object sender, MouseEventArgs e)
        {
            BrushesLabels(((FrameworkElement)sender).Name, 1);
        }
        private void LabelNumber1_MouseLeave(object sender, MouseEventArgs e)
        {
            BrushesLabels(((FrameworkElement)sender).Name, 2);
        }

        private void BrushesLabels(string str, byte miban)
        {
            switch (str)
            {
                case "LabelNumber1":
                    if (miban == 1)
                        LabelNumber1.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber1.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber2":
                    if (miban == 1)
                        LabelNumber2.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber2.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber3":
                    if (miban == 1)
                        LabelNumber3.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber3.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber4":
                    if (miban == 1)
                        LabelNumber4.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber4.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber5":
                    if (miban == 1)
                        LabelNumber5.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber5.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber6":
                    if (miban == 1)
                        LabelNumber6.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber6.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber7":
                    if (miban == 1)
                        LabelNumber7.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber7.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber8":
                    if (miban == 1)
                        LabelNumber8.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber8.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber9":
                    if (miban == 1)
                        LabelNumber9.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber9.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber10":
                    if (miban == 1)
                        LabelNumber10.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber10.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber11":
                    if (miban == 1)
                        LabelNumber11.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber11.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber12":
                    if (miban == 1)
                        LabelNumber12.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber12.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber13":
                    if (miban == 1)
                        LabelNumber13.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber13.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber14":
                    if (miban == 1)
                        LabelNumber14.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber14.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber15":
                    if (miban == 1)
                        LabelNumber15.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber15.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber16":
                    if (miban == 1)
                        LabelNumber16.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber16.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber17":
                    if (miban == 1)
                        LabelNumber17.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber17.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber18":
                    if (miban == 1)
                        LabelNumber18.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber18.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber19":
                    if (miban == 1)
                        LabelNumber19.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber19.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber20":
                    if (miban == 1)
                        LabelNumber20.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber20.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber21":
                    if (miban == 1)
                        LabelNumber21.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber21.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber22":
                    if (miban == 1)
                        LabelNumber22.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber22.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber23":
                    if (miban == 1)
                        LabelNumber23.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber23.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber24":
                    if (miban == 1)
                        LabelNumber24.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber24.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber25":
                    if (miban == 1)
                        LabelNumber25.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber25.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber26":
                    if (miban == 1)
                        LabelNumber26.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber26.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber27":
                    if (miban == 1)
                        LabelNumber27.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber27.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber28":
                    if (miban == 1)
                        LabelNumber28.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber28.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber29":
                    if (miban == 1)
                        LabelNumber29.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber29.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber30":
                    if (miban == 1)
                        LabelNumber30.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber30.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber31":
                    if (miban == 1)
                        LabelNumber31.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber31.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber32":
                    if (miban == 1)
                        LabelNumber32.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber32.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber33":
                    if (miban == 1)
                        LabelNumber33.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber33.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber34":
                    if (miban == 1)
                        LabelNumber34.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber34.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber35":
                    if (miban == 1)
                        LabelNumber35.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber35.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber36":
                    if (miban == 1)
                        LabelNumber36.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber36.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber37":
                    if (miban == 1)
                        LabelNumber37.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber37.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber38":
                    if (miban == 1)
                        LabelNumber38.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber38.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber39":
                    if (miban == 1)
                        LabelNumber39.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber39.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber40":
                    if (miban == 1)
                        LabelNumber40.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber40.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber41":
                    if (miban == 1)
                        LabelNumber41.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber41.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber42":
                    if (miban == 1)
                        LabelNumber42.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber42.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber43":
                    if (miban == 1)
                        LabelNumber43.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber43.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber44":
                    if (miban == 1)
                        LabelNumber44.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber44.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber45":
                    if (miban == 1)
                        LabelNumber45.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber45.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber46":
                    if (miban == 1)
                        LabelNumber46.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber46.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber47":
                    if (miban == 1)
                        LabelNumber47.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber47.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber48":
                    if (miban == 1)
                        LabelNumber48.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber48.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber49":
                    if (miban == 1)
                        LabelNumber49.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber49.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber50":
                    if (miban == 1)
                        LabelNumber50.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber50.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber51":
                    if (miban == 1)
                        LabelNumber51.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber51.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber52":
                    if (miban == 1)
                        LabelNumber52.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber52.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber53":
                    if (miban == 1)
                        LabelNumber53.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber53.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber54":
                    if (miban == 1)
                        LabelNumber54.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber54.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber55":
                    if (miban == 1)
                        LabelNumber55.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber55.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber56":
                    if (miban == 1)
                        LabelNumber56.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber56.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber57":
                    if (miban == 1)
                        LabelNumber57.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber57.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber58":
                    if (miban == 1)
                        LabelNumber58.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber58.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber59":
                    if (miban == 1)
                        LabelNumber59.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber59.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber60":
                    if (miban == 1)
                        LabelNumber60.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber60.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber61":
                    if (miban == 1)
                        LabelNumber61.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber61.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber62":
                    if (miban == 1)
                        LabelNumber62.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber62.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber63":
                    if (miban == 1)
                        LabelNumber63.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber63.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber64":
                    if (miban == 1)
                        LabelNumber64.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber64.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber65":
                    if (miban == 1)
                        LabelNumber65.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber65.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber66":
                    if (miban == 1)
                        LabelNumber66.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber66.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber67":
                    if (miban == 1)
                        LabelNumber67.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber67.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber68":
                    if (miban == 1)
                        LabelNumber68.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber68.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber69":
                    if (miban == 1)
                        LabelNumber69.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber69.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber70":
                    if (miban == 1)
                        LabelNumber70.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber70.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber71":
                    if (miban == 1)
                        LabelNumber71.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber71.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber72":
                    if (miban == 1)
                        LabelNumber72.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber72.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber73":
                    if (miban == 1)
                        LabelNumber73.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber73.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber74":
                    if (miban == 1)
                        LabelNumber74.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber74.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber75":
                    if (miban == 1)
                        LabelNumber75.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber75.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber76":
                    if (miban == 1)
                        LabelNumber76.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber76.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber77":
                    if (miban == 1)
                        LabelNumber77.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber77.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber78":
                    if (miban == 1)
                        LabelNumber78.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber78.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber79":
                    if (miban == 1)
                        LabelNumber79.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber79.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber80":
                    if (miban == 1)
                        LabelNumber80.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber80.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber81":
                    if (miban == 1)
                        LabelNumber81.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber81.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber82":
                    if (miban == 1)
                        LabelNumber82.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber82.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber83":
                    if (miban == 1)
                        LabelNumber83.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber83.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber84":
                    if (miban == 1)
                        LabelNumber84.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber84.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber85":
                    if (miban == 1)
                        LabelNumber85.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber85.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber86":
                    if (miban == 1)
                        LabelNumber86.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber86.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber87":
                    if (miban == 1)
                        LabelNumber87.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber87.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber88":
                    if (miban == 1)
                        LabelNumber88.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber88.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber89":
                    if (miban == 1)
                        LabelNumber89.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber89.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber90":
                    if (miban == 1)
                        LabelNumber90.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber90.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber91":
                    if (miban == 1)
                        LabelNumber91.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber91.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber92":
                    if (miban == 1)
                        LabelNumber92.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber92.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber93":
                    if (miban == 1)
                        LabelNumber93.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber93.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber94":
                    if (miban == 1)
                        LabelNumber94.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber94.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber95":
                    if (miban == 1)
                        LabelNumber95.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber95.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber96":
                    if (miban == 1)
                        LabelNumber96.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber96.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber97":
                    if (miban == 1)
                        LabelNumber97.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber97.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber98":
                    if (miban == 1)
                        LabelNumber98.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber98.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber99":
                    if (miban == 1)
                        LabelNumber99.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber99.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber100":
                    if (miban == 1)
                        LabelNumber100.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber100.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber101":
                    if (miban == 1)
                        LabelNumber101.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber101.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber102":
                    if (miban == 1)
                        LabelNumber102.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber102.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber103":
                    if (miban == 1)
                        LabelNumber103.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber103.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber104":
                    if (miban == 1)
                        LabelNumber104.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber104.Foreground = Brushes.Snow;
                    break;
                case "LabelNumber105":
                    if (miban == 1)
                        LabelNumber105.Foreground = Brushes.YellowGreen;
                    else
                        LabelNumber105.Foreground = Brushes.Snow;
                    break;
            }
        }
    }
}
