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

        private string[] arrWordsTextBox { get; set; }
        private string[] arrRandomWords { get; set; } = new string[10];

        public static int stage { get; set; } = 1;

        private int countAbsentWords { get; set; } = 0;
        private int countWrongWords { get; set; } = 0;

        private string[] arrWords { get; set; } = { "մուկ", "պատ", "սպունգ", "մահճակալ", "սեղան", "տիկնիկ", "բառ" ,"վարունգ","կոստյում",
                                                    "ներկ", "միջանցք", "ձյուն" , "փաթիլ", "հատոր" , "ձող", "նախաճաշ" , "բանալի","շերտ",
                                                    "գարնուն","կրպակ","ճնճղուկ","շարժիչ","դեղձ","դրոշ","խմորիչ", "միջատ", "ժապավեն","հեծանիվ",
                                                    "ուղղաթիռ" , "մորուք" , "ներարկիչ" , "միավոր" , "ձմեռ" , "անձնակազմ" , "փոխարժեք",
                                                    "աղյուս" , "սպիտակուց", "կոշիկ", "կոճակ" , "ծրար", "անակնկալ" ,"պինգվին" , "թագ" , "հոգի" ,
                                                    "ինքնաթիռ" , "հավ" , "թանաք" , "պոչ" , "վայրկյան" ,"փրփուր","ռետին" ,"մոմ",   "ակնոց" ,
                                                    "հանցանք" , "շաքար" , "ալիք" ,  "պիտակ","բալ" , "ծառ" , "դդում" ,"տոմս" , "գոլորշի" ,"փոշի",
                                                    "կողպեք" , "բանկ" , "մարտիկ" , "ականջակալ","սկուտեղ" , "ջրվեժ" ,"զանգ" , "պատվաստում" ,
                                                    "խաչքար" , "ձու" , "մեքենա", "վերնաշապիկ" ,"ձյուն" , "նարինջ" , "խցան" , "դեսերտ" ,  "հրաբուխ" ,
                                                    "երկաթ" , "խոռոչ" , "ղեկավար" , "թթվասեր" ,"վարդ" , "արծաթ" ,"յոդ" , "լողավազան" ,"օձ" , "տորթ" ,
                                                    "կայծ" , "մուրճ" ,"ամրոց" ,"ավանակ" , "վերմակ" , "լավաշ" , "օրորոց" , "ձագ" , "խմիչք" , "կետ" };



        public AttentivenessTestTablePage()
        {
            InitializeComponent();

            arrRandomWords = cl.GetRandomArrWord(arrWords, 10);
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
                textBoxWords.IsEnabled = false;
            }

        }

        private void Button_Exit_The_Test_View_Result(object sender, RoutedEventArgs e)
        {
            if (textBoxWords.Text.Length != 0)
            {
                arrWordsTextBox = cl.FilteringLetterInTheTextAndGetArrWords(textBoxWords.Text);
                countAbsentWords = cl.GetArrayMissingWordsInAnArray(arrRandomWords, arrWordsTextBox).Length;
                countWrongWords = cl.GetArrayMissingWordsInAnArray(arrWordsTextBox, arrRandomWords).Length;
                if (countWrongWords == 0)
                {
                    if (countAbsentWords <= 1 && stage < 3)
                    {
                        LableInfo.Content = $"Ձեր հիշողությունը գերազանց է";
                        buttonExitTheTestViewResult.Visibility = Visibility.Collapsed;
                        buttonSeeWord.Visibility = Visibility.Collapsed;
                    }
                    else
                    if (countAbsentWords <= 1 && stage == 3)
                    {
                        LableInfo.Content = $"Ձեր հիշողության հետ ամեն ինչ նորմալ է";
                        buttonExitTheTestViewResult.Visibility = Visibility.Collapsed;
                        buttonSeeWord.Visibility = Visibility.Collapsed;
                    }
                    else
                    if (countAbsentWords <= 1 && stage > 3)
                    {
                        LableInfo.Content = $"Ձեր մոտ կարճաժամկետ հիշողությունը գերազանց չէ";
                        buttonExitTheTestViewResult.Visibility = Visibility.Collapsed;
                        buttonSeeWord.Visibility = Visibility.Collapsed;
                    }
                }
                else
                {
                    LableInfo.Content = $"Ձեր մոտ նկատվում է ավելի շատ ուշադրության խնդիր քան հիշողության";
                    buttonExitTheTestViewResult.Visibility = Visibility.Collapsed;
                    buttonSeeWord.Visibility = Visibility.Collapsed;
                }
            }
            else
            {
                LableInfo.Content = $"Դուք չեք գրել ոչ մի բառ։ Գրել ներքևում տրված դաշտում(արանց տառասխալների և փոքրատառերով)";
                textBoxWords.Focus();
            }


        }

        private void Button_View_Word(object sender, RoutedEventArgs e)
        {
            if (textBoxWords.IsEnabled)
            {
                textBoxWords.IsEnabled = false;
                textBoxWords.Clear();
                LabelWord.Visibility = Visibility.Visible;
                buttonSeeWord.Content = "Շարունակել";
                LableTryAgein.Content = $"Փորձ {++stage}";

                if (stage > 1)
                    LableInfo.Content = null;

            }
            else
            {
                textBoxWords.IsEnabled = true;
                textBoxWords.Focus();
                LabelWord.Visibility = Visibility.Collapsed;
                buttonSeeWord.Content = "Տեսնել բառերը կրկին";

                if (stage == 1)
                    LableInfo.Content = "Բառերը Գրել ներքևում տրված դաշտում, արանց տառասխալների և փոքրատառերով , այլապես դա կդիտարկվի սխալ";
                else
                    LableInfo.Content = null;
            }
        }

        private void Exit_The_Test(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AttentivenessTestRulePage());
        }
    }
}
