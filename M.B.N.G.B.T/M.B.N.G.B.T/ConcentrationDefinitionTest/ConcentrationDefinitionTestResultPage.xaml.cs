using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

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
                labelInfo.Visibility = Visibility.Visible;
                labelInfo.Content = "Դուք ոչինչ չեք լրացրել,կարող եք թեստը անցնել կրկին";
            }
            else
            if (ConcentrationDefinitionTestTablePage.IsBigNumbersInTextBox && ConcentrationDefinitionTestTablePage.countBigNumbers > 1)
            {
                labelInfo.Visibility = Visibility.Visible;
                labelInfo.Content = "Տեկստում կա 40-ից մեծ թվեր հնարավոր է դուք թվերը չեք արանձնացրել \nստորակետերով   խնդրում   եմ   ծանոթանալ    կանոներին  և  թեստն \nանցնել սկզբից:";
            }
            else
            if(ConcentrationDefinitionTestTablePage.IsBigNumbersInTextBox && ConcentrationDefinitionTestTablePage.countBigNumbers == 1)
            {
                labelInfo.Visibility = Visibility.Visible;
                labelInfo.Content = "Տեկստում կա 40-ից մեծ թիվ հնարավոր է դուք թվերը չեք արանձնացրել \nստորակետերով   խնդրում   եմ   ծանոթանալ    կանոներին  և  թեստն \nանցնել սկզբից:";
            }

        }

        private string WriteTextBlock(int[][] arr)
        {
            string str = $"\n";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null)
                {
                    str += $"{i + 1})";
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        str += $"{arr[i][j]},";
                    }
                    str += $"\n";
                }
            }
            return str;
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
