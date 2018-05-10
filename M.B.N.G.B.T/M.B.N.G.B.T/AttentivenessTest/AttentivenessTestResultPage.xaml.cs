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

namespace M.B.N.G.B.T.AttentivenessTest
{
    /// <summary>
    /// Логика взаимодействия для AttentivenessTestResultPage.xaml
    /// </summary>
    public partial class AttentivenessTestResultPage : Page
    {
        public AttentivenessTestResultPage()
        {
            InitializeComponent();
            switch (AttentivenessTestTablePage.stage)
            {
                case 1:
                    LabelResult.Content = "Ձեզ մոտ զարգացած է նորմալ կարճաժամկետ հիշողություն";
                    break;
                case 2:
                    LabelResult.Content = "հիշողությունը գերազանց է";
                    break;
                case 3:
                    LabelResult.Content = "հիշողության հետ ամեն ինչ նորմալ է";
                    break;
                case 4:
                    LabelResult.Content = "խնդիրը ուշադրության հետ է կապված , այլ ոչ հիշողության";
                    break;
                case 5:
                    LabelResult.Content = "կարճաժամկետ հիշողությունը զարգացած չէ";
                    break;
            }
        }

        private void button_Click_try_again(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AttentivenessTestRulePage());
        }

        private void button_Click_Exit_Main(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
        }
    }
}
