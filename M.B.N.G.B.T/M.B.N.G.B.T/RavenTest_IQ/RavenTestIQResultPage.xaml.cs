using ClassLibrary;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace M.B.N.G.B.T.RavenTest_IQ
{
    /// <summary>
    /// Логика взаимодействия для RavenTestIQResultPage.xaml
    /// </summary>
    public partial class RavenTestIQResultPage : Page, INewRavenTestIQResultPage
    {
        ClassLibraryMBNGBT cl = new ClassLibraryMBNGBT();

        public static readonly byte[] arrIQ_16_30 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 55, 57, 58,
                                                      59, 61, 62, 64, 65, 66, 67, 69,70, 71,
                                                      72, 74, 75, 76, 77, 79, 80, 82,83, 84,
                                                      86, 87, 89, 90, 91, 92, 94, 95,96, 97,
                                                      99, 100, 102, 104, 106, 108, 110, 112, 114,
                                                      116, 118, 120, 122, 124, 126, 128, 130, 130};

        public static readonly byte[] arrIQ_13_5 = { 46, 47, 49, 50, 51, 52, 54, 55, 56, 57,
                                                     59, 60, 61, 62, 64, 65, 66, 67, 69, 70,
                                                     71, 72, 74, 75, 76, 77, 79, 80, 81, 82,
                                                     84, 85, 86, 87, 89, 90, 91, 92, 94, 95,
                                                     96, 97, 99, 100, 102, 105, 107, 110, 112,
                                                     115, 117, 120, 122, 123, 127, 130, 132, 134,
                                                     137, 139 };

        public static readonly byte[] arrIQ_13 = { 46, 48, 49, 50, 52, 53, 54, 55, 57, 59,
                                                   60, 61, 62, 63, 64, 66, 67, 68, 69, 71,
                                                   72, 73, 74, 76, 77, 78, 80, 81, 82, 83,
                                                   85, 86, 87, 88, 90, 91, 92, 94, 95, 96,
                                                   97, 99, 100, 102, 105, 107, 109, 110, 114,
                                                   116, 118, 121, 123, 125, 127, 130, 132, 134,
                                                   137, 139 };

        public static readonly byte[] arrIQ_12_5 = { 46, 49, 50, 51, 52, 54, 55, 57, 58, 59,
                                                     61, 62, 63, 65, 66, 67, 69, 70, 71, 72,
                                                     74, 75, 76, 78, 79, 80, 82, 83, 84, 85,
                                                     86, 87, 90, 91, 92, 93, 95, 96, 97, 99,
                                                     100, 102, 104, 106, 109, 111, 113, 115,
                                                     117, 119, 121, 123, 126, 128, 130, 132,
                                                     134, 136, 138, 139 };

        public static readonly byte[] arrIQ_12 = { 48, 49, 51, 52, 53, 55, 56, 57, 59, 60,
                                                   61, 63, 64, 65, 67, 68, 69, 71, 72, 73,
                                                   75, 76, 77, 79, 80, 81, 83, 84, 85, 87,
                                                   88, 90, 91, 92, 93, 95, 96, 97, 99, 100,
                                                   102, 104, 106, 108, 110, 112, 114, 116,
                                                   118, 120, 122, 124, 126, 128, 130, 132,
                                                   134, 136, 138, 140 };

        public static readonly byte[] arrIQ_11_5 = { 50, 51, 53, 54, 56, 57, 58, 60, 61, 62,
                                                     64, 65, 67, 68, 69, 72, 73, 74, 75, 76,
                                                     78, 79, 81, 82, 83, 85, 86, 88, 89, 90,
                                                     92, 93, 95, 96, 97, 99, 100, 102, 104,
                                                     106, 108, 109, 111, 113, 115, 117, 119,
                                                     121, 123, 124, 127, 128, 130, 132, 134,
                                                     136, 138, 139, 141, 143 };

        public static readonly byte[] arrIQ_11 = { 53, 54, 55, 57, 58, 59, 61, 62, 64, 65,
                                                   66, 68, 69, 71, 72, 73, 75, 76, 78, 79,
                                                   80, 82, 83, 85, 86, 87, 89, 90, 92, 93,
                                                   94, 96, 97, 99, 100, 102, 104, 105, 107,
                                                   109, 111, 112, 114, 116, 118, 120, 121,
                                                   123, 125, 127, 128, 130, 132, 134, 136,
                                                   137, 139, 141, 143, 144 };

        public static readonly byte[] arrIQ_10_5 = { 53, 56, 57, 58, 59, 61, 63, 64, 66, 67,
                                                     69, 70, 71, 73, 74, 76, 77, 79, 80, 81,
                                                     83, 84, 86, 87, 89, 90, 91, 93, 94, 96,
                                                     97, 99, 100, 102, 103, 105, 107, 108,
                                                     110, 112, 113, 115, 117, 118, 120, 122,
                                                     123, 125, 127, 128, 130, 132, 133, 135,
                                                     137, 138, 140, 141, 145, 147 };

        public static readonly byte[] arrIQ_10 = { 56, 57, 60, 61, 63, 64, 66, 67, 69, 70,
                                                   72, 73, 75, 77, 78, 79, 81, 82, 84, 85,
                                                   87, 88, 90, 91, 93, 94, 96, 97, 99, 100,
                                                   102, 103, 104, 105, 107, 109, 110, 112,
                                                   115, 116, 117, 118, 120, 121, 123, 125,
                                                   126, 128, 129, 131, 133, 134, 136, 137,
                                                   139, 142, 143, 144, 145, 147 };

        public static readonly byte[] arrIQ_9_5 = { 59, 61, 62, 64, 65, 67, 68, 70, 71, 73,
                                                    74, 76, 77, 79, 80, 82, 83, 85, 86, 88,
                                                    89, 91, 92, 94, 95, 97, 98, 100, 102,
                                                    103, 105, 106, 108, 111, 112, 113, 114,
                                                    115, 117, 118, 120, 121, 123, 125, 126,
                                                    127, 129, 130, 132, 133, 135, 136, 138,
                                                    139, 141, 142, 144, 145, 147, 148 };

        public static readonly byte[] arrIQ_9 = { 65, 67, 68, 70, 71, 73, 74, 76, 77, 79,
                                                  80, 82, 83, 85, 86, 88, 89, 91, 92, 94,
                                                  95, 97, 98, 100, 101, 103, 104, 106, 107,
                                                  109, 110, 112, 113, 115, 116, 118, 119, 121,
                                                  122, 124, 125, 127, 128, 130, 131, 133, 134,
                                                  136, 137, 139, 140, 142, 143, 145, 146, 147,
                                                  148, 151, 152, 154 };

        public static readonly byte[] arrIQ_8_5 = { 68, 70, 72, 73, 75, 76, 78, 79, 81, 83,
                                                    84, 86, 87, 89, 90, 92, 95, 96, 97, 98,
                                                    100, 101, 103, 104, 106, 107, 108, 110,
                                                    111, 113, 114, 115, 117, 118, 120, 121,
                                                    122, 124, 125, 127, 128, 129, 131, 132,
                                                    134, 135, 136, 138, 139, 141, 142, 143,
                                                    144, 146, 148, 149, 150, 152, 153, 155 };

        public static readonly byte[] arrIQ_8 = { 73, 74, 76, 77, 79, 81, 82, 84, 85, 87,
                                                  89, 90, 92, 93, 95, 97, 98, 100, 101, 103,
                                                  104, 105, 107, 108, 109, 110, 112, 113, 114,
                                                  116, 117, 118, 120, 121, 122, 123, 125, 126,
                                                  127, 129, 130, 132, 133, 134, 135, 136, 138,
                                                  139, 140, 142, 143, 144, 146, 147, 148, 149,
                                                  151, 152, 153, 155 };

        private static object ravenTestIQViewUserErrorsPage;
        public static object RavenTestIQViewUserErrorsPage { get { return ravenTestIQViewUserErrorsPage; } }

        public RavenTestIQResultPage()
        {
            InitializeComponent();
            CreateNewResultPageForNewUser();
        }

        /// <summary>
        /// Этот метод обнулировает все данные в классе RavenTestIQResultPage и RavenTestIQViewUserErrorsPage
        /// для нового пользователя (как новое окно)
        /// </summary>
        public void CreateNewResultPageForNewUser()
        {
            buttonClickViewErrorsUser.Visibility = Visibility.Hidden;

            if (RavenTestIQTablePage.IsUserErrors)
                buttonClickViewErrorsUser.Visibility = Visibility.Visible;

            if (ravenTestIQViewUserErrorsPage == null && RavenTestIQTablePage.IsUserErrors)
                ravenTestIQViewUserErrorsPage = new RavenTestIQViewUserErrorsPage();
            else
            if (ravenTestIQViewUserErrorsPage != null && RavenTestIQTablePage.IsUserErrors)
                ((INewRavenTestIQViewUserErrorsPage)ravenTestIQViewUserErrorsPage).CreateNewViewUserErrorsPageForNewUser();

            InitializeLabels();
        }

        private void InitializeLabels()
        {
            int tempIQ = 0;
            int rightAnswers = ((60 - RavenTestIQTablePage.ArrWrongSelectedUserAnswersByLevel.Length) - RavenTestIQTablePage.CountOfTestsNotPassed);

            if (Convert.ToByte(RavenTestIQRuleWindow.Age) <= 13.5)
            {
                switch (RavenTestIQRuleWindow.Age)
                {
                    case "8":
                        tempIQ = arrIQ_8[(rightAnswers - 1)];
                        break;
                    case "8,5":
                        tempIQ = arrIQ_8_5[(rightAnswers - 1)];
                        break;
                    case "9":
                        tempIQ = arrIQ_9[(rightAnswers - 1)];
                        break;
                    case "9,5":
                        tempIQ = arrIQ_9_5[(rightAnswers - 1)];
                        break;
                    case "10":
                        tempIQ = arrIQ_10[(rightAnswers - 1)];
                        break;
                    case "10,5":
                        tempIQ = arrIQ_10_5[(rightAnswers - 1)];
                        break;
                    case "11":
                        tempIQ = arrIQ_11[(rightAnswers - 1)];
                        break;
                    case "11,5":
                        tempIQ = arrIQ_11_5[(rightAnswers - 1)];
                        break;
                    case "12":
                        tempIQ = arrIQ_12[(rightAnswers - 1)];
                        break;
                    case "12,5":
                        tempIQ = arrIQ_12_5[(rightAnswers - 1)];
                        break;
                    case "13":
                        tempIQ = arrIQ_13[(rightAnswers - 1)];
                        break;
                    case "13,5":
                        tempIQ = arrIQ_13_5[(rightAnswers - 1)];
                        break;
                }
            }
            else
            if (Convert.ToByte(RavenTestIQRuleWindow.Age) > 13.5 && Convert.ToByte(RavenTestIQRuleWindow.Age) <= 30)
                tempIQ = arrIQ_16_30[(rightAnswers - 1)];
            else
            if (Convert.ToByte(RavenTestIQRuleWindow.Age) > 30 && Convert.ToByte(RavenTestIQRuleWindow.Age) <= 35)
                tempIQ = ((arrIQ_16_30[(rightAnswers - 1)] * 100) / 97);
            else
            if (Convert.ToByte(RavenTestIQRuleWindow.Age) > 35 && Convert.ToByte(RavenTestIQRuleWindow.Age) <= 40)
                tempIQ = ((arrIQ_16_30[(rightAnswers - 1)] * 100) / 93);
            else
            if (Convert.ToByte(RavenTestIQRuleWindow.Age) > 40 && Convert.ToByte(RavenTestIQRuleWindow.Age) <= 45)
                tempIQ = ((arrIQ_16_30[(rightAnswers - 1)] * 100) / 88);
            else
            if (Convert.ToByte(RavenTestIQRuleWindow.Age) > 45 && Convert.ToByte(RavenTestIQRuleWindow.Age) <= 50)
                tempIQ = ((arrIQ_16_30[(rightAnswers - 1)] * 100) / 82);
            else
            if (Convert.ToByte(RavenTestIQRuleWindow.Age) > 50 && Convert.ToByte(RavenTestIQRuleWindow.Age) <= 55)
                tempIQ = ((arrIQ_16_30[(rightAnswers - 1)] * 100) / 76);
            else
            if (Convert.ToByte(RavenTestIQRuleWindow.Age) > 55 && Convert.ToByte(RavenTestIQRuleWindow.Age) <= 60 ||
                Convert.ToByte(RavenTestIQRuleWindow.Age) > 60)
                tempIQ = ((arrIQ_16_30[(rightAnswers - 1)] * 100) / 70);

            labelRightAnswers.Content = $"Ճիշտ պատասխանների քանակը = {rightAnswers}";
            labelPercent.Content = $"Տոկոս = {cl.DecreaseInNumbersAfterTheDecimalPoint(((Convert.ToDouble(60) - Convert.ToDouble(RavenTestIQTablePage.ArrWrongSelectedUserAnswersByLevel.Length) - Convert.ToDouble(RavenTestIQTablePage.CountOfTestsNotPassed))) * Convert.ToDouble(100) / Convert.ToDouble(60), 2)}%";
            if (tempIQ == 0)
                labelIQ.Content = $"IQ = -";
            else
               labelIQ.Content = $"IQ = {tempIQ}";
            
        }

        private void Button_Click_View_Errors_User(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(RavenTestIQViewUserErrorsPage as RavenTestIQViewUserErrorsPage);
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
