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
        public static int stage { get; set; } = 1;

        string[] arr = { "մուկ", "պատ", "սպունգ", "մահճակալ", "սեղան", "տիկնիկ", "բառ" ,"վարունգ","կոստյում",
                             "ներկ", "միջանցք", "ձյան" , "փաթիլ", "հատոր" , "ձող", "նախաճաշ" , "բանալի","շերտ",
                              "գարնուն","կրպակ","ճնճղուկ","շարժիչ","դեղձ","դրոշ","խմորիչ", "միջատ", "ժապավեն",
                              "ուղղաթիռ" , "մորուք" , "ներարկիչ" , "միավոր" , "ձմեռ" , "անձնակազմ" , "փոխարժեք",
                              "աղյուս" , "սպիտակուց", "կոշիկ", "կոճակ" ,  "ծրար", "անակնկալ" ,
                              "պինգվին" , "թագ" , "ինքնաթիռ" , "հավ" , "թանաք" , "պոչ" , "վայրկյան" ,"փրփուր","ռետին" ,
                              "մոմ",   "ակնոց" , "հանցանք" , "շաքար" , "ալիք" ,  "պիտակ",
                              "բալ" , "ծառ" , "դդում" , "տոմս" , "գոլորշի" , "կողպեք" , "բանկ" , "մարտիկ" , "ականջակալ",
                              "սկուտեղ" , "ջրվեժ" , "զանգ" , "պատվաստում" , "խաչքար" , "ձու" , "մեքենա", "վերնաշապիկ" ,
                              "ձյուն" , "նարինջ" , "խցան" , "դեսերտ" , "հրաբուխ" , "երկաթ" , "խոռոչ" , "ղեկավար" , "թթվասեր" ,
                               "վարդ" , "արծաթ" ,"յոդ" , "լողավազան" , "օձ" , "տորթ" , "կայծ" , "մուրճ" ,"ամրոց" ,
                               "ավանակ" , "վերմակ" , "լավաշ" , "օրորոց" ,"ձագ" , "խմիչք" , "կետ" , "փոշի", "հոգի"};

        public AttentivenessTestTablePage()
        {
            InitializeComponent();
          
        }

        private void button_Click_Result(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AttentivenessTestResultPage());
        }


    }
}
