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
                ViewboxResult3.Visibility = Visibility.Visible;
                switch (TestEclecticAttentionTablePage.chekedRadioButton)
                {
                    case 1:
                        LabelResult2.Content = "Դուք աշխատել եք համակարգված ոճով։";
                        break;
                    case 2:
                        LabelResult2.Content = "Դուք աշխատել եք օպտիմալ ոճով։";
                        break;
                    case 3:
                        LabelResult2.Content = "Դուք աշխատել եք քաոսաին ոճով։";
                        break;
                }
                LabelResult3.Content += $"Ձեր ցուցանիշը  {TestEclecticAttentionTablePage.second} վրկ";
                if (TestEclecticAttentionTablePage.second <= 100)
                {
                    LabelResult3.Content += ", որը համարվում է գերազանց ցուցանիշ։";
                }
                else
                if(TestEclecticAttentionTablePage.second <= 150)
                {
                    LabelResult3.Content += ", որը համարվում է լավ ցուցանիշ։";
                }
                else
                if (TestEclecticAttentionTablePage.second <= 211)
                {
                    LabelResult3.Content += ", որը համարվում է նորմալ ցուցանիշ։";
                }
                else
                {
                    LabelResult3.Content += ", որը համարվում է վատ ցուցանիշ, կարող եք կրկին \nփորցել ձեր ուժերը։";
                }
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
