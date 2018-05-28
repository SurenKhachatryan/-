using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace M.B.N.G.B.T.TestEclecticAttention
{
    /// <summary>
    /// Логика взаимодействия для TestEclecticAttentionResultPage.xaml
    /// </summary>
    public partial class TestEclecticAttentionResultPage : Page
    {
        public TestEclecticAttentionResultPage()
        {
            InitializeComponent();
            if (TestEclecticAttentionTablePage.counterVibronicaFalseNumbers == 11)
            {
                ViewboxResult1.Visibility = Visibility.Visible;
            }
            else
            {
                ViewboxResult2.Visibility = Visibility.Visible;
                switch (TestEclecticAttentionTablePage.chekedRadioButton)
                {
                    case 1:
                        LabelResult2.Content = "Դուք աշխատել եք համակարգված ոճով։";
                        break;
                    case 2:
                        LabelResult2.Content = "Դուք աշխատել եք օպտիմալ ոճով։";
                        break;
                    case 3:
                        LabelResult2.Content = "Դուք աշխատել եք քաոսային ոճով։";
                        break;
                }

                if (TestEclecticAttentionTablePage.second <= 100)
                    LabelResult3.Content = $"Ձեր ցուցանիշն է - {TestEclecticAttentionTablePage.second} վրկ, որը համարվում է գերազանց ցուցանիշ։";
                else
                if (TestEclecticAttentionTablePage.second <= 190)
                    LabelResult3.Content = $"Ձեր ցուցանիշն է - {TestEclecticAttentionTablePage.second} վրկ, որը համարվում է լավ ցուցանիշ։";
                else
                if (TestEclecticAttentionTablePage.second <= 211)
                    LabelResult3.Content = $"Ձեր ցուցանիշ է - {TestEclecticAttentionTablePage.second} վրկ, որը համարվում է նորմալ ցուցանիշ։";
                else
                    LabelResult3.Content = $"Ձեր ցուցանիշը է - {TestEclecticAttentionTablePage.second} վրկ, որը համարվում է վատ ցուցանիշ, կարող եք \nկրկնել թեստը ։";
            }
        }

        private void Button_Click_Try_Again(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TestEclecticAttentionRulePage());
        }

        private void Button_Click_Exit_Main(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
        }
    }
}
