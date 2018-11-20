using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using ClassLibrary;

namespace M.B.N.G.B.T.ConcentrationDefinitionTest
{
    /// <summary>
    /// Логика взаимодействия для ConcentrationDefinitionTestResultPage.xaml
    /// </summary>
    public partial class ConcentrationDefinitionTestResultPage : Page
    {
        private ClassLibraryMBNGBT cl = new ClassLibraryMBNGBT();

        public ConcentrationDefinitionTestResultPage()
        {
            InitializeComponent();

            if (ConcentrationDefinitionTestTablePage.IsBigNumbersInTextBox ||
                ConcentrationDefinitionTestTablePage.IsEmptyTextBox ||
                ConcentrationDefinitionTestTablePage.CountNumberOfEqualDigits > 0)
            {
                ViewboxResult1.Visibility = Visibility.Visible;
                if (ConcentrationDefinitionTestTablePage.IsEmptyTextBox)
                    labelInfo.Content = "Դուք ոչինչ չեք լրացրել,կարող եք թեստն անցնել կրկին:";
                else
                if (ConcentrationDefinitionTestTablePage.CountBigNumbers > 1 && ConcentrationDefinitionTestTablePage.CountNumberOfEqualDigits == 1)
                    labelInfo.Content = "Տեքստում կան 40-ից մեծ թվեր և կրկնվող թիվ։ Հնարավոր է դուք թվերը չեք \nառանձնացրել ստորակետերով, խնդրում եմ ծանոթանալ կանոններին և \nթեստն անցնել սկզբից:";
                else
                if (ConcentrationDefinitionTestTablePage.CountBigNumbers == 1 && ConcentrationDefinitionTestTablePage.CountNumberOfEqualDigits > 1)
                    labelInfo.Content = "Տեքստում կա 40-ից մեծ թիվ և կրկնվող թվեր։ Հնարավոր է դուք թվերը չեք \nառանձնացրել ստորակետերով, խնդրում եմ ծանոթանալ կանոններին և \nթեստն անցնել սկզբից:";
                else
                if (ConcentrationDefinitionTestTablePage.CountBigNumbers == 1 && ConcentrationDefinitionTestTablePage.CountNumberOfEqualDigits == 1)
                    labelInfo.Content = "Տեքստում կա 40-ից մեծ թիվ և կրկնվող թիվ։ Հնարավոր է դուք թվերը չեք \nառանձնացրել ստորակետերով, խնդրում եմ ծանոթանալ կանոններին և \nթեստն անցնել սկզբից:";
                else
                if (ConcentrationDefinitionTestTablePage.CountBigNumbers > 1 && ConcentrationDefinitionTestTablePage.CountNumberOfEqualDigits > 1)
                    labelInfo.Content = "Տեքստում կան 40-ից մեծ թվեր և կրկնվող թվեր։ Հնարավոր է դուք թվերը չեք \nառանձնացրել ստորակետերով, խնդրում եմ ծանոթանալ կանոններին և \nթեստն անցնել սկզբից:";
                else
                if (ConcentrationDefinitionTestTablePage.CountBigNumbers > 1 && ConcentrationDefinitionTestTablePage.CountNumberOfEqualDigits == 0)
                    labelInfo.Content = "Տեքստում կան 40-ից մեծ թվեր։ Հնարավոր է դուք թվերը չեք առանձնացրել \nստորակետերով, խնդրում եմ ծանոթանալ կանոններին և թեստն անցնել \nսկզբից:";
                else
                if (ConcentrationDefinitionTestTablePage.CountBigNumbers == 0 && ConcentrationDefinitionTestTablePage.CountNumberOfEqualDigits > 1)
                    labelInfo.Content = "Տեքստում կան կրկնվող թվեր։ Խնդրում եմ ծանոթանալ կանոններին և թեստն \nանցնել սկզբից:";
                else
                if (ConcentrationDefinitionTestTablePage.CountBigNumbers == 1 && ConcentrationDefinitionTestTablePage.CountNumberOfEqualDigits == 0)
                    labelInfo.Content = "Տեքստում կա 40-ից մեծ թիվ, հնարավոր է դուք թվերը չեք առանձնացրել \nստորակետերով, խնդրում եմ ծանոթանալ կանոններին և թեստն անցնել \nսկզբից:";
                else
                if (ConcentrationDefinitionTestTablePage.CountBigNumbers == 0 && ConcentrationDefinitionTestTablePage.CountNumberOfEqualDigits == 1)
                    labelInfo.Content = "Տեքստում կա կրկնվող թիվ, խնդրում եմ ծանոթանալ կանոններին և թեստն \nանցնել սկզբից:";

                if (!ConcentrationDefinitionTestTablePage.IsEmptyTextBox)
                {
                    ViewboxTextBoxText1.Visibility = Visibility.Visible;
                    labelTextBoxText1.Content = ConcentrationDefinitionTestTablePage.TextBoxText;
                }
            }
            else
            {
                ViewBoxLabels.Visibility = Visibility.Visible;

                labelListNumbers.Content += $"\n-{cl.GetOneTextArrItemsSeparationCommas(ConcentrationDefinitionTestTablePage.ArrAllRandomDigits)}";
                labelRightNumbers.Content += $"\n-{cl.GetOneTextArrItemsSeparationCommas(ConcentrationDefinitionTestTablePage.ArrAllRightNumbers)}";
                if (ConcentrationDefinitionTestTablePage.ArrAllRightNumbersUser.Length != 0)
                    LabelResult1.Content += $"\n-{cl.GetOneTextArrItemsSeparationCommas(ConcentrationDefinitionTestTablePage.ArrAllRightNumbersUser)}";
                else
                    LabelResult1.Content += $"\n-Դուք չեք գրել ոչ մի ճիշտ թիվ:";
                
                double finishResultOfPercent = (Convert.ToDouble(ConcentrationDefinitionTestTablePage.ArrAllRightNumbersUser.Length) / Convert.ToDouble(15)) * 100;

                if (ConcentrationDefinitionTestTablePage.ArrAllAbsentNumbers.Length > 0 && ConcentrationDefinitionTestTablePage.ArrAllExtraNumbers.Length > 0)
                {
                    LabelResult2.Visibility = Visibility.Visible;
                    LabelResult3.Visibility = Visibility.Visible;
                    LabelResult4.Visibility = Visibility.Visible;

                    LabelResult2.Content = $"Բաց թողած թվեր, որոնք դուք չեք նկատել \n-{cl.GetOneTextArrItemsSeparationCommas(ConcentrationDefinitionTestTablePage.ArrAllAbsentNumbers)}";
                    LabelResult3.Content = $"Թվեր, որոնք աղյուսակում կային \n-{cl.GetOneTextArrItemsSeparationCommas(ConcentrationDefinitionTestTablePage.ArrAllExtraNumbers)}";
                    LabelResult4.Content = $"Ուշադրության արդյունավետության ցուցանիշը \n-{Convert.ToInt32(finishResultOfPercent)}%";
                }
                else
                if (ConcentrationDefinitionTestTablePage.ArrAllAbsentNumbers.Length > 0 && ConcentrationDefinitionTestTablePage.ArrAllExtraNumbers.Length == 0)
                {
                    LabelResult2.Visibility = Visibility.Visible;
                    LabelResult3.Visibility = Visibility.Visible;

                    LabelResult2.Content = $"Բաց թողած թվեր, որոնք դուք չեք նկատել \n-{cl.GetOneTextArrItemsSeparationCommas(ConcentrationDefinitionTestTablePage.ArrAllAbsentNumbers)}";
                    LabelResult3.Content = $"Ուշադրության արդյունավետության ցուցանիշը \n-{ Convert.ToInt32(finishResultOfPercent)}%";
                }
                else
                if (ConcentrationDefinitionTestTablePage.ArrAllExtraNumbers.Length > 0 && ConcentrationDefinitionTestTablePage.ArrAllAbsentNumbers.Length == 0)
                {
                    LabelResult2.Visibility = Visibility.Visible;
                    LabelResult3.Visibility = Visibility.Visible;

                    LabelResult2.Content = $"Թվեր, որոնք աղյուսակում կային \n-{cl.GetOneTextArrItemsSeparationCommas(ConcentrationDefinitionTestTablePage.ArrAllExtraNumbers)}";
                    LabelResult3.Content = $"Ուշադրության արդյունավետության ցուցանիշը \n-{Convert.ToInt32(finishResultOfPercent)}%";
                }
                else
                if (ConcentrationDefinitionTestTablePage.ArrAllAbsentNumbers.Length == 0 && ConcentrationDefinitionTestTablePage.ArrAllExtraNumbers.Length == 0)
                {
                    LabelResult2.Visibility = Visibility.Visible;
                    LabelResult2.Content = $"Ուշադրության արդյունավետության ցուցանիշը \n-{ Convert.ToInt32(finishResultOfPercent)}%";
                }
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
