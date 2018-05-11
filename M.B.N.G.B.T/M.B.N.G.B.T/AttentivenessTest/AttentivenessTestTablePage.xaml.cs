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

namespace M.B.N.G.B.T.AttentivenessTest
{
    /// <summary>
    /// Логика взаимодействия для AttentivenessTestTablePage.xaml
    /// </summary>
    public partial class AttentivenessTestTablePage : Page
    {
        ClassLibraryMBNGBT cl = new ClassLibraryMBNGBT();

        public static int stage { get; set; } = 1;

        private string[] arrWords { get; set; } = { "մուկ", "պատ", "սպունգ", "մահճակալ", "սեղան", "տիկնիկ", "բառ" ,"վարունգ","կոստյում",
                                                    "ներկ", "միջանցք", "ձյան" , "փաթիլ", "հատոր" , "ձող", "նախաճաշ" , "բանալի","շերտ",
                                                    "գարնուն","կրպակ","ճնճղուկ","շարժիչ","դեղձ","դրոշ","խմորիչ", "միջատ", "ժապավեն","հեծանիվ",
                                                    "ուղղաթիռ" , "մորուք" , "ներարկիչ" , "միավոր" , "ձմեռ" , "անձնակազմ" , "փոխարժեք",
                                                    "աղյուս" , "սպիտակուց", "կոշիկ", "կոճակ" , "ծրար", "անակնկալ" ,"պինգվին" , "թագ" , "հոգի" ,
                                                    "ինքնաթիռ" , "հավ" , "թանաք" , "պոչ" , "վայրկյան" ,"փրփուր","ռետին" ,"մոմ",   "ակնոց" ,
                                                    "հանցանք" , "շաքար" , "ալիք" ,  "պիտակ","բալ" , "ծառ" , "դդում" ,"տոմս" , "գոլորշի" ,"փոշի",
                                                    "կողպեք" , "բանկ" , "մարտիկ" , "ականջակալ","սկուտեղ" , "ջրվեժ" ,"զանգ" , "պատվաստում" ,
                                                    "խաչքար" , "ձու" , "մեքենա", "վերնաշապիկ" ,"ձյուն" , "նարինջ" , "խցան" , "դեսերտ" ,  "հրաբուխ" ,
                                                    "երկաթ" , "խոռոչ" , "ղեկավար" , "թթվասեր" ,"վարդ" , "արծաթ" ,"յոդ" , "լողավազան" ,"օձ" , "տորթ" ,
                                                    "կայծ" , "մուրճ" ,"ամրոց" ,"ավանակ" , "վերմակ" , "լավաշ" , "օրորոց" , "ձագ" , "խմիչք" , "կետ" };

        private string[] arrRandomWords { get; set; } = new string[10];

        public AttentivenessTestTablePage()
        {
            InitializeComponent();

            string[] arrRandomWords = cl.GetRandomArrWord(arrWords, 10);
            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    LabelWord.Content += $"{arrRandomWords[i]}";
                }
                else
                {
                    LabelWord.Content += $" , {arrRandomWords[i]}";
                }

            }

        }

        private void Button_Exit_The_Test_View_Result(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AttentivenessTestResultPage());
        }

        private void Button_View_Word(object sender, RoutedEventArgs e)
        {

        }
    }
}
