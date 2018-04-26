using M.B.N.G.B.T.V.L.Marshuk_Test;
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

namespace M.B.N.G.B.T.V.L.Marshukov_Test
{
    /// <summary>
    /// Логика взаимодействия для MarshukTestRulePage.xaml
    /// </summary>
    public partial class MarshukTestRulePage : Page
    {
        public MarshukTestRulePage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            MarshukTestTablePage.stage = 1;
            NavigationService.Navigate(new MarshukTestTablePage());
        }
    }
}
