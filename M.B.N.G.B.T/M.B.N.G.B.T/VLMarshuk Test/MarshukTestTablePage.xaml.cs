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

namespace M.B.N.G.B.T.V.L.Marshuk_Test
{
    /// <summary>
    /// Логика взаимодействия для V.xaml
    /// </summary>
    public partial class MarshukTestTablePage : Page
    {
        private List<int> lsRndDigite = new List<int>();
        private static ulong[][] arrAllStageDigits = new ulong[5][];
        private static int[][] arrAllStageAbsentDisgits = new int[5][];

        private Random rnd = new Random();
        private ClassLibraryMBNGBT cl = new ClassLibraryMBNGBT();

        public static byte stage = 1;


        public MarshukTestTablePage()
        {
            InitializeComponent();
            
            if (stage + 1 == 6)
            {
                buttonNextStage.Content = "Ավարտել թեսնը";
                buttonClickResult.Visibility = Visibility.Collapsed;
            }

            startStage.Content = stage;
            TextBox.Focus();
            ChangeContentButtonRandom();
        }

        private void button_Click_Result(object sender, RoutedEventArgs e)
        {
            FinishStage();
            NavigationService.Navigate(new MarshukTestResultPage());
        }

        private void FinishStage()
        {
            arrAllStageAbsentDisgits[stage - 1] = cl.SortingAndSerchInArrMissingNumbers(lsRndDigite.ToArray(), 40).ToArray();
            if (TextBox.Text == "")
            {
                arrAllStageDigits[stage - 1] = null;
            }
            else
            {
                arrAllStageDigits[stage - 1] = cl.FilteringDigitsInTheText(TextBox.Text);
            }
        }

        private void ButtonNextStage(object sender, RoutedEventArgs e)
        {
            FinishStage();
            stage++;
            if (stage != 6)
            {
                NavigationService.Navigate(new MarshukTestTablePage());
            }
            else
            {
                NavigationService.Navigate(new MarshukTestResultPage());
            }
        }

        private void ChangeContentButtonRandom()
        {
            int temp = 0;
            for (int i = 1; i <= 25; i++)
            {
                temp = rnd.Next(1, 41);
                if (lsRndDigite.Count == 0 || !cl.SerchMatchingNumberInArr(lsRndDigite.ToArray(), temp))
                {
                    lsRndDigite.Add(temp);

                    switch (i)
                    {
                        case 1:
                            if (temp >= 10)
                                Label1.Content = temp;
                            else
                                Label1.Content = $" {temp}";
                            break;
                        case 2:
                            if (temp >= 10)
                                Label2.Content = temp;
                            else
                                Label2.Content = $" {temp}";
                            break;
                        case 3:
                            if (temp >= 10)
                                Label3.Content = temp;
                            else
                                Label3.Content = $" {temp}";
                            break;
                        case 4:
                            if (temp >= 10)
                                Label4.Content = temp;
                            else
                                Label4.Content = $" {temp}";
                            break;
                        case 5:
                            if (temp >= 10)
                                Label5.Content = temp;
                            else
                                Label5.Content = $" {temp}";
                            break;
                        case 6:
                            if (temp >= 10)
                                Label6.Content = temp;
                            else
                                Label6.Content = $" {temp}";
                            break;
                        case 7:
                            if (temp >= 10)
                                Label7.Content = temp;
                            else
                                Label7.Content = $" {temp}";
                            break;
                        case 8:
                            if (temp >= 10)
                                Label8.Content = temp;
                            else
                                Label8.Content = $" {temp}";
                            break;
                        case 9:
                            if (temp >= 10)
                                Label9.Content = temp;
                            else
                                Label9.Content = $" {temp}";
                            break;
                        case 10:
                            if (temp >= 10)
                                Label10.Content = temp;
                            else
                                Label10.Content = $" {temp}";
                            break;
                        case 11:
                            if (temp >= 10)
                                Label11.Content = temp;
                            else
                                Label11.Content = $" {temp}";
                            break;
                        case 12:
                            if (temp >= 10)
                                Label12.Content = temp;
                            else
                                Label12.Content = $" {temp}";
                            break;
                        case 13:
                            if (temp >= 10)
                                Label13.Content = temp;
                            else
                                Label13.Content = $" {temp}";
                            break;
                        case 14:
                            if (temp >= 10)
                                Label14.Content = temp;
                            else
                                Label14.Content = $" {temp}";
                            break;
                        case 15:
                            if (temp >= 10)
                                Label15.Content = temp;
                            else
                                Label15.Content = $" {temp}";
                            break;
                        case 16:
                            if (temp >= 10)
                                Label16.Content = temp;
                            else
                                Label16.Content = $" {temp}";
                            break;
                        case 17:
                            if (temp >= 10)
                                Label17.Content = temp;
                            else
                                Label17.Content = $" {temp}"; ;
                            break;
                        case 18:
                            if (temp >= 10)
                                Label18.Content = temp;
                            else
                                Label18.Content = $" {temp}";
                            break;
                        case 19:
                            if (temp >= 10)
                                Label19.Content = temp;
                            else
                                Label19.Content = $" {temp}";
                            break;
                        case 20:
                            if (temp >= 10)
                                Label20.Content = temp;
                            else
                                Label20.Content = $" {temp}";
                            break;
                        case 21:
                            if (temp >= 10)
                                Label21.Content = temp;
                            else
                                Label21.Content = $" {temp}";
                            break;
                        case 22:
                            if (temp >= 10)
                                Label22.Content = temp;
                            else
                                Label22.Content = $" {temp}";
                            break;
                        case 23:
                            if (temp >= 10)
                                Label23.Content = temp;
                            else
                                Label23.Content = $" {temp}";
                            break;
                        case 24:
                            if (temp >= 10)
                                Label24.Content = temp;
                            else
                                Label24.Content = $" {temp}";
                            break;
                        case 25:
                            if (temp >= 10)
                                Label25.Content = temp;
                            else
                                Label25.Content = $" {temp}";
                            break;
                    }
                }
                else
                {
                    i--;
                }
            }
        }
    }
}
