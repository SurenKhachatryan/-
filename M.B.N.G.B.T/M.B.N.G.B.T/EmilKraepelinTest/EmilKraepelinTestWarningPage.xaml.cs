using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace M.B.N.G.B.T.EmilKraepelinTest
{
    /// <summary>
    /// Логика взаимодействия для EmilKraepelinTestWarningPage.xaml
    /// </summary>
    public partial class EmilKraepelinTestWarningPage : Page
    {
        public EmilKraepelinTestWarningPage()
        {
            InitializeComponent();
            if (EmilKraepelinTestTablePage.IsIncreasedErrors)
                Label_1.Visibility = Visibility.Visible;
            else
            if (EmilKraepelinTestTablePage.IsZeroLabelFalseAndTrue)
                Label_2.Visibility = Visibility.Visible;
            else
            if (EmilKraepelinTestTablePage.IsSeriousness)
                Label_3.Visibility = Visibility.Visible;
         
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
