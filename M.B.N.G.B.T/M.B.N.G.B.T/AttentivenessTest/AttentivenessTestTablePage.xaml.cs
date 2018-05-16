using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using System.Windows.Threading;
using ClassLibrary;

namespace M.B.N.G.B.T.AttentivenessTest
{
    /// <summary>
    /// Логика взаимодействия для AttentivenessTestTablePage.xaml
    /// </summary>

    public partial class AttentivenessTestTablePage : Page
    {
        private ClassLibraryMBNGBT cl = new ClassLibraryMBNGBT();
        private DispatcherTimer dispatcherTimer = new DispatcherTimer();

        private string[] arrWordsTextBox { get; set; }
        private string[] arrRandomWords { get; set; } = new string[10];

        public static int stage { get; set; } = 1;

        private int countAbsentWords { get; set; } = 0;
        private int countWrongWords { get; set; } = 0;
        private int second { get; set; }

        private string[] arrWords { get; set; } = { "մուկ", "պատ", "սպունգ", "մահճակալ", "սեղան", "տիկնիկ", "բառ" ,"վարունգ","կոստյում",
                                                    "ներկ", "միջանցք", "ձյուն" , "փաթիլ", "հատոր" , "ձող", "նախաճաշ" , "բանալի","շերտ",
                                                    "գարուն","կրպակ","ճնճղուկ","շարժիչ","դեղձ","դրոշ","խմորիչ", "միջատ", "ժապավեն","հեծանիվ",
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
            dispatcherTimer.Tick += new EventHandler(LabelTimer);

            arrRandomWords = cl.GetRandomArrWord(arrWords, 10);
            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                    LabelWord.Content += $"{arrRandomWords[i]}";
                else
                    LabelWord.Content += $" , {arrRandomWords[i]}";

                textBoxWords.IsEnabled = false;
                buttonExitTheTestViewResult.IsEnabled = false;
            }
        }

        private void LabelTimer(object sender, EventArgs e)
        {
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            if (second == 10)
            {
                LableInfo.Content = string.Empty;
                dispatcherTimer.Stop();
                second = 0;
            }
            if (buttonExitTheTestViewResult.Visibility != Visibility.Visible)
                dispatcherTimer.Stop();
            second++;
        }

        private void Button_Exit_The_Test_View_Result(object sender, RoutedEventArgs e)
        {
            if (textBoxWords.Text.Length != 0)
            {
                arrWordsTextBox = cl.FilteringLetterInTheTextAndGetArrWords(textBoxWords.Text);
                countAbsentWords = cl.GetArrayMissingWordsInAnArray(arrRandomWords, arrWordsTextBox).Length;
                countWrongWords = cl.GetArrayMissingWordsInAnArray(arrWordsTextBox, arrRandomWords).Length;

                if (countWrongWords <= 1)
                {
                    if ((countAbsentWords <= 1 && stage < 3) || (countAbsentWords <= 1 && stage == 3) ||
                       (countAbsentWords == 2 && stage == 3) || (countAbsentWords >= 3 && stage >= 3))
                    {
                        buttonExitTheTestViewResult.Visibility = Visibility.Collapsed;
                        buttonSeeWord.Visibility = Visibility.Collapsed;
                        LabelWord.Visibility = Visibility.Visible;
                    }
                    if (countAbsentWords <= 1 && stage < 3)
                        LableInfo.Content = $"Ձեր կարճաժամկետ հիշողությունը գերազանց է";
                    else
                    if (countAbsentWords <= 1 && stage == 3)
                        LableInfo.Content = $"Ձեր հիշողության հետ ամեն ինչ նորմալ է";
                    else
                    if (countAbsentWords == 2 && stage == 3)
                        LableInfo.Content = $"Թույլ զարգացած կարճաժամկետ հիշողություն";
                    else
                    if (countAbsentWords >= 3 && stage >= 3)
                        LableInfo.Content = $"կարճաժամկետ հիշողությունը զարգացած չէ";
                    else
                    if (((countAbsentWords <= 5 || countAbsentWords == 2) && stage == 1) ||
                        ((countAbsentWords == 3 || countAbsentWords == 2) && stage == 2))
                        LableInfo.Content = $"նորմալ զարգացած կարճաժամկետ հիշողություն, կարող էք կրկին կարդալ բառերը կամ ուղակի հիշել և գրել";
                    else
                    if (countAbsentWords >= 4 && (stage == 1 || stage == 2))
                        LableInfo.Content = $"Այս պահին բառերի քանակը քիչ է վերլուծություն կատարելու համար, կարող էք կրկին կարդալ բառերը կամ ուղղակի հիշել և գրել";
                }
                else
                {
                    LableInfo.Content = $"Ձեր մոտ նկատվում է ավելի շատ ուշադրության խնդիր, քան՝ հիշողության, խորհուրդ է տրվում թեստն անցնել սկզբից";
                    buttonExitTheTestViewResult.Visibility = Visibility.Collapsed;
                    buttonSeeWord.Visibility = Visibility.Collapsed;
                    LabelWord.Visibility = Visibility.Visible;
                }
            }
            else
            {
                if (stage <= 3)
                {
                    LableInfo.Content = $"Դուք չեք գրել ոչ մի բառ։ Գրեք ներքևում տրված դաշտում(առանց տառասխալների և փոքրատառերով)";
                    textBoxWords.Focus();
                }
                else
                {
                    LableInfo.Content = $"խորհուրդ է տրվում թեստն անցնել սկզբից";
                    buttonExitTheTestViewResult.Visibility = Visibility.Collapsed;
                    buttonSeeWord.Visibility = Visibility.Collapsed;
                }
            }
            if (buttonExitTheTestViewResult.Visibility == Visibility.Visible)
                dispatcherTimer.Start();
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
                buttonExitTheTestViewResult.IsEnabled = false;

                if (stage > 1)
                    LableInfo.Content = null;
            }
            else
            {
                textBoxWords.IsEnabled = true;
                textBoxWords.Focus();
                LabelWord.Visibility = Visibility.Collapsed;
                buttonSeeWord.Content = "Տեսնել բառերը կրկին";
                buttonExitTheTestViewResult.IsEnabled = true;

                if (stage == 1)
                    LableInfo.Content = "Բառերը Գրել ներքևում տրված դաշտում, առանց տառասխալների և փոքրատառերով, այլապես դա կդիտարկվի որպես սխալ";
                else
                    LableInfo.Content = null;

                if (stage == 4)
                    buttonSeeWord.Visibility = Visibility.Collapsed;
            }
        }

        private void Exit_The_Test(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AttentivenessTestRulePage());
            dispatcherTimer.Stop();
        }

        private void textBoxWords_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;
        }

        private void textBoxWords_PreviewMouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;
        }

        private void textBoxWords_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsLetter(Convert.ToChar(e.Text)) && Convert.ToChar(e.Text) != 44)
            {
                e.Handled = true;
            }
        }
    }
}
