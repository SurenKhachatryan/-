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

        public ConcentrationDefinitionTestResultPage()
        {
            InitializeComponent();
            if (ConcentrationDefinitionTestTablePage.IsEmptyTextBox)
            {
                ViewboxResult1.Visibility = Visibility.Visible;
                labelInfo.Content = "Դուք ոչինչ չեք լրացրել,կարող եք թեստը անցնել կրկին";
            }
            else
            if (ConcentrationDefinitionTestTablePage.IsBigNumbersInTextBox || ConcentrationDefinitionTestTablePage.CountNumberOfEqualDigits >= 1)
            {
                ViewboxResult1.Visibility = Visibility.Visible;
                if (ConcentrationDefinitionTestTablePage.CountBigNumbers > 1 && ConcentrationDefinitionTestTablePage.CountNumberOfEqualDigits == 1)
                    labelInfo.Content = "Տեկստում կա 40-ից մեծ թվեր և կրկնվող թիվ հնարավոր է դուք թվերը չեք \nարանձնացրել ստորակետերով խնդրում եմ ծանոթանալ կանոներին և \nթեստն անցնել սկզբից:";
                else
                if (ConcentrationDefinitionTestTablePage.CountBigNumbers == 1 && ConcentrationDefinitionTestTablePage.CountNumberOfEqualDigits > 1)
                    labelInfo.Content = "Տեկստում կա 40-ից մեծ թիվ և կրկնվող թվեր հնարավոր է դուք թվերը չեք \nարանձնացրել ստորակետերով խնդրում եմ ծանոթանալ կանոներին և \nթեստն անցնել սկզբից:";
                else
                if (ConcentrationDefinitionTestTablePage.CountBigNumbers == 1 && ConcentrationDefinitionTestTablePage.CountNumberOfEqualDigits == 1)
                    labelInfo.Content = "Տեկստում կա 40-ից մեծ թիվ և կրկնվող թիվ հնարավոր է դուք թվերը չեք \nարանձնացրել ստորակետերով խնդրում եմ ծանոթանալ կանոներին և \nթեստն անցնել սկզբից:";
                else
                if (ConcentrationDefinitionTestTablePage.CountBigNumbers > 1 && ConcentrationDefinitionTestTablePage.CountNumberOfEqualDigits > 1)
                    labelInfo.Content = "Տեկստում կա 40-ից մեծ թվեր և կրկնվող թվեր հնարավոր է դուք թվերը չեք \nարանձնացրել ստորակետերով խնդրում եմ ծանոթանալ կանոներին և \nթեստն անցնել սկզբից:";
                else
                if (ConcentrationDefinitionTestTablePage.CountBigNumbers > 1 && ConcentrationDefinitionTestTablePage.CountNumberOfEqualDigits == 0)
                    labelInfo.Content = "Տեկստում կա 40-ից մեծ թվեր հնարավոր է դուք թվերը չեք արանձնացրել \nստորակետերով խնդրում եմ ծանոթանալ կանոներին և թեստն անցնել \nսկզբից:";
                else
                if (ConcentrationDefinitionTestTablePage.CountBigNumbers == 0 && ConcentrationDefinitionTestTablePage.CountNumberOfEqualDigits > 1)
                    labelInfo.Content = "Տեկստում կա կրկնվող թվեր խնդրում եմ ծանոթանալ կանոներին և թեստն \nանցնել սկզբից:";
                else
                if (ConcentrationDefinitionTestTablePage.CountBigNumbers == 1 && ConcentrationDefinitionTestTablePage.CountNumberOfEqualDigits == 0)
                    labelInfo.Content = "Տեկստում կա 40-ից մեծ թիվ հնարավոր է դուք թվերը չեք արանձնացրել \nստորակետերով խնդրում եմ ծանոթանալ կանոներին և թեստն անցնել \nսկզբից:";
                else
                if (ConcentrationDefinitionTestTablePage.CountBigNumbers == 0 && ConcentrationDefinitionTestTablePage.CountNumberOfEqualDigits == 1)
                    labelInfo.Content = "Տեկստում կա կրկնվող թիվ խնդրում եմ ծանոթանալ կանոներին և թեստն \nանցնել սկզբից:";

                ViewboxResult2.Visibility = Visibility.Visible;
                labelInfo2.Content = ConcentrationDefinitionTestTablePage.TextBoxText;

            }

        }

        private void Button_Click_Try_Again(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ConcentrationDefinitionTestRulePage());
        }

        private void Button_Click_Exit_Main(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
        }
    }
}
