using M.B.N.G.B.T.V.L.Marshukov_Test;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace M.B.N.G.B.T.V.L.Marshuk_Test
{
    /// <summary>
    /// Логика взаимодействия для MarshukResaltPage.xaml
    /// </summary>
    public partial class MarshukTestResultPage : Page
    {
        public MarshukTestResultPage()
        {
            InitializeComponent();

            textBlock1.Text += $"{ new string('-', 80)}\n" +
                "Ցանկի թվերը ըստ փուլերի\n";
            textBlock1.Text += WriteTextBlock(MarshukTestTablePage.arrAllStageRandomDigits);

            textBlock1.Text += $"{ new string('-', 80)}\n"
                + "ճիշտ պատասխանները ըստ փուլերի\n";
            textBlock1.Text += WriteTextBlock(MarshukTestTablePage.arrAllStageRightNumbers);

            textBlock.Text += $"{ new string('-', 55)}\n"
                + "Ձեր պատասխանները ըստ փուլերի\n";
            textBlock.Text += WriteTextBlock(MarshukTestTablePage.arrAllStageDigitsInTextBox);

            textBlock.Text += $"{ new string('-', 55)}" +
                "\nՍխալ պատասխանները ըստ փուլերի \n" +
                $"{ new string('-', 55)}\n" +
                "Ավելորդ թվերը որոնք ցանկում կային\n";
            textBlock.Text += WriteTextBlock(MarshukTestTablePage.arrAllStageExtraNumbers);

            textBlock.Text += $"{ new string('-', 55)}\n" +
                "Բացթողնված թվերը որոնք ցանկում չկային\n";
            textBlock.Text += WriteTextBlock(MarshukTestTablePage.arrAllStageAbsentNumbers);

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

        private void button_Click_try_again(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MarshukTestRulePage());
        }

        private void button_Click_Exit_Main(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
        }
    }
}
