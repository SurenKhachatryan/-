using ClassLibrary;
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
using System.Windows.Threading;

namespace M.B.N.G.B.T.Schulte_Test
{
    /// <summary>
    /// Логика взаимодействия для SchulteTestTablePage2.xaml
    /// </summary>
    public partial class SchulteTestTablePage2 : Page
    {
        private List<int> lsRndDigite = new List<int>();
        private Random rnd = new Random();
        private ClassLibraryMBNGBT cl = new ClassLibraryMBNGBT();

        public SchulteTestTablePage2()
        {
            InitializeComponent();

        }
        

        private void button_Click_Result(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SchulteResultPage());
        }

        private void ChangeContentButtonRandom()
        {
            int temp = 0;
            for (int i = 1; i <= 25; i++)
            {
                temp = rnd.Next(1, 26);
                if (lsRndDigite.Count == 0 || !cl.SerchMatchingNumberInArr(lsRndDigite.ToArray(), temp))
                {
                    lsRndDigite.Add(temp);

                    switch (i)
                    {
                        case 1:
                            button1.Content = temp;
                            break;
                        case 2:
                            button2.Content = temp;
                            break;
                        case 3:
                            button3.Content = temp;
                            break;
                        case 4:
                            button4.Content = temp;
                            break;
                        case 5:
                            button5.Content = temp;
                            break;
                        case 6:
                            button6.Content = temp;
                            break;
                        case 7:
                            button7.Content = temp;
                            break;
                        case 8:
                            button8.Content = temp;
                            break;
                        case 9:
                            button9.Content = temp;
                            break;
                        case 10:
                            button10.Content = temp;
                            break;
                        case 11:
                            button11.Content = temp;
                            break;
                        case 12:
                            button12.Content = temp;
                            break;
                        case 13:
                            button13.Content = temp;
                            break;
                        case 14:
                            button14.Content = temp;
                            break;
                        case 15:
                            button15.Content = temp;
                            break;
                        case 16:
                            button16.Content = temp;
                            break;
                        case 17:
                            button17.Content = temp;
                            break;
                        case 18:
                            button18.Content = temp;
                            break;
                        case 19:
                            button19.Content = temp;
                            break;
                        case 20:
                            button20.Content = temp;
                            break;
                        case 21:
                            button21.Content = temp;
                            break;
                        case 22:
                            button22.Content = temp;
                            break;
                        case 23:
                            button23.Content = temp;
                            break;
                        case 24:
                            button24.Content = temp;
                            break;
                        case 25:
                            button25.Content = temp;
                            break;
                    }
                }
                else
                {
                    i--;
                }
            }
        }


        private void Button_Click1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click7(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click8(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click9(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click10(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click11(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click12(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click13(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click14(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click15(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click16(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click17(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click18(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click19(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click20(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click21(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click22(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click23(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click24(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click25(object sender, RoutedEventArgs e)
        {


        }
    }
}
