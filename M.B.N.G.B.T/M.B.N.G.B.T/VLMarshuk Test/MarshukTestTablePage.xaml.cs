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

namespace M.B.N.G.B.T.V.L.Marshuk_Test
{
    /// <summary>
    /// Логика взаимодействия для V.xaml
    /// </summary>
    public partial class MarshukTestTablePage : Page
    {
        private List<int> lsRndDigite = new List<int>();

        public static int[][] arrAllStageDigitsInTextBox = new int[5][];
        public static int[][] arrAllStageRightNumbers = new int[5][];
        public static int[][] arrAllStageAbsentNumbers = new int[5][];
        public static int[][] arrAllStageExtraNumbers = new int[5][];

        private Random rnd = new Random();
        private ClassLibraryMBNGBT cl = new ClassLibraryMBNGBT();
        private DispatcherTimer dispatcherTimer = new DispatcherTimer();

        public static byte stage = 1;

        private int second = 0;
        private int minute = 0;

        public MarshukTestTablePage()
        {
            InitializeComponent();

            if (stage + 1 == 6)
            {
                buttonNextStage.Content = "Ավարտել թեսնը";
                buttonClickResult.Visibility = Visibility.Collapsed;
            }
            dispatcherTimer.Start();
            dispatcherTimer.Tick += new EventHandler(LabelTimer);

            startStage.Content = stage;
            TextBox.Focus();
            ChangeContentButtonRandom();

            arrAllStageRightNumbers[stage - 1] = cl.SortingAndSerchInArrMissingNumbers(lsRndDigite.ToArray(), 40).ToArray();
        }

        private void button_Click_Result(object sender, RoutedEventArgs e)
        {
            FinishStage();
            NavigationService.Navigate(new MarshukTestResultPage());
        }

        private void LabelTimer(object sender, EventArgs e)
        {
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            second++;
            if (second == 60)
            {
                second = 0;
                minute++;
            }
            if (second < 10)
                timer.Content = $"{minute}:0{second}";
            else
                timer.Content = $"{minute}:{second}";

            if (minute == 3 && second == 0)
            {
                FinishStage();
                NavigationService.Navigate(new MarshukTestResultPage());
            }
        }

        private void FinishStage()
        {
            dispatcherTimer.Stop();

            if (TextBox.Text == "")
            {
                arrAllStageDigitsInTextBox[stage - 1] = null;
                arrAllStageAbsentNumbers[stage - 1] = null;
                arrAllStageExtraNumbers[stage - 1] = null;
            }
            else
            {
                arrAllStageDigitsInTextBox[stage - 1] = cl.FilteringDigitsInTheText(TextBox.Text);
                arrAllStageExtraNumbers[stage - 1] = cl.GetArrayMissingNumbersInAnArray(arrAllStageDigitsInTextBox[stage - 1], arrAllStageRightNumbers[stage - 1]);
                arrAllStageAbsentNumbers[stage - 1] = cl.GetArrayMissingNumbersInAnArray(arrAllStageRightNumbers[stage - 1], arrAllStageDigitsInTextBox[stage - 1]);

                if (arrAllStageAbsentNumbers[stage - 1].Length != 0)
                    cl.SortingArr(ref arrAllStageAbsentNumbers[stage - 1]);
                if (arrAllStageExtraNumbers[stage - 1].Length != 0)
                    cl.SortingArr(ref arrAllStageExtraNumbers[stage - 1]);
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

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if ((!Char.IsDigit(e.Text, 0)))
            {
                e.Handled = true;

                string tamp = cl.CopyTheText(TextBox.Text, TextBox.SelectionStart, TextBox.Text.Length);

                if (TextBox.SelectionStart != TextBox.Text.Length)
                {
                    int IndexStartSelection = TextBox.SelectionStart;
                    TextBox.Text = TextBox.Text.Remove(TextBox.SelectionStart, tamp.Length);
                    TextBox.Text = TextBox.Text + "," + tamp;
                    TextBox.SelectionStart = IndexStartSelection + 1;
                }
                else
                {
                    TextBox.Text = TextBox.Text + ",";
                    TextBox.SelectionStart = TextBox.Text.Length;
                }

            }
        }
    }
}
