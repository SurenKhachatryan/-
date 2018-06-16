using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using System.Windows.Threading;
using System.Windows.Media;

namespace M.B.N.G.B.T.ConcentrationDefinitionTest
{
    /// <summary>
    /// Логика взаимодействия для ConcentrationDefinitionTestTablePage.xaml
    /// </summary>
    public partial class ConcentrationDefinitionTestTablePage : Page
    {
        private List<int> lsRndDigite { get; set; } = new List<int>();
        private Label[] arrAllLabels { get; set; } = new Label[25];

        public static int[] arrAllDigitsInTextBox { get; private set; } = new int[5];
        public static int[] arrAllRightNumbers { get; private set; } = new int[5];
        private static int[] arrBigNumbers = new int[0];
        private static int[] arrAllRandomDigits = new int[5];
        private static int[] arrAllAbsentNumbers = new int[5];
        private static int[] arrAllExtraNumbers = new int[5];

        public static bool IsEmptyTextBox { get; private set; } = true;
        public static bool IsBigNumbersInTextBox { get; private set; } = false;
        public static int countBigNambers { get; private set; } = 0;

        public int[] ArrBigNumbers { get { return arrBigNumbers; } }
        public int[] ArrAllRandomDigits { get { return arrAllRandomDigits; } }
        public int[] ArrAllAbsentNumbers { get { return arrAllAbsentNumbers; } }
        public int[] ArrAllExtraNumbers { get { return arrAllExtraNumbers; } }

        private Random rnd = new Random();
        private ClassLibraryMBNGBT cl = new ClassLibraryMBNGBT();
        private DispatcherTimer dispatcherTimer = new DispatcherTimer();

        private int index { get; set; } = 0;
        private int second { get; set; } = 0;
        private int minute { get; set; } = 0;
        private int secondCTRL { get; set; } = 0;

        public ConcentrationDefinitionTestTablePage()
        {
            InitializeComponent();

            arrAllRandomDigits = new int[5];
            arrAllDigitsInTextBox = new int[5];
            arrAllRightNumbers = new int[5];
            arrAllAbsentNumbers = new int[5];
            arrAllExtraNumbers = new int[5];
            IsEmptyTextBox = true;
            IsBigNumbersInTextBox = false;
            countBigNambers = 0;
            arrBigNumbers = new int[0];

            dispatcherTimer.Tick += new EventHandler(LabelTimer);
            dispatcherTimer.Start();

            textBox.Focus();
            ChangeContentButtonRandom();

            arrAllRightNumbers = cl.SortingAndSerchInArrMissingNumbers(lsRndDigite.ToArray(), 40).ToArray();
        }

        private void Button_Exit_The_Test(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
            NavigationService.Navigate(new ConcentrationDefinitionTestRulePage());
        }

        private void LabelTimer(object sender, EventArgs e)
        {
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);

            if (second == 60)
            {
                second = 0;
                minute++;
                timer.Foreground = Brushes.Yellow;
            }

            if (minute == 1 && second == 15)
                timer.Foreground = Brushes.Red;

            if (second < 10)
                timer.Content = $"{minute}:0{second}";
            else
                timer.Content = $"{minute}:{second}";

            if (minute == 1 && second == 30)
            {
                IsEmptyTextBox = (textBox.Text == string.Empty) ? true : false;
                IsBigNumbersInTextBox = (cl.SearchBigNumberInArr(cl.GetArrFiltringNumbersInTheText(textBox.Text), 40)) ? true : false;
                countBigNambers = cl.GetCountAndArrBigNumbers(cl.GetArrFiltringNumbersInTheText(textBox.Text), 40, out arrBigNumbers);

                if (!IsBigNumbersInTextBox && !IsEmptyTextBox)
                {
                    dispatcherTimer.Stop();
                    textBox.IsEnabled = false;
                    timer.Foreground = Brushes.Black;
                    buttonFinishTest.Visibility = Visibility.Visible;
                }
                else
                    NavigationService.Navigate(new ConcentrationDefinitionTestResultPage());
            }

            if (secondCTRL == 1)
            {
                textBox.IsEnabled = true;
                textBox.Focus();
            }
            second++;
        }

        private void Button_Finish_Test(object sender, RoutedEventArgs e)
        {
            arrAllDigitsInTextBox = cl.GetArrFiltringNumbersInTheText(textBox.Text);
            arrAllExtraNumbers = cl.GetArrayMissingNumbersInAnArray(arrAllDigitsInTextBox, arrAllRightNumbers);
            arrAllAbsentNumbers = cl.GetArrayMissingNumbersInAnArray(arrAllRightNumbers, arrAllDigitsInTextBox);

            cl.SortingArr(ref arrAllAbsentNumbers);
            cl.SortingArr(ref arrAllExtraNumbers);

            NavigationService.Navigate(new ConcentrationDefinitionTestResultPage());
        }

        private void ChangeContentButtonRandom()
        {
            arrAllLabels = new Label[] {Label1, Label2, Label3, Label4, Label5, Label6, Label7, Label8, Label9, Label10,
                                        Label11, Label12, Label13, Label14, Label15, Label16, Label17, Label18, Label19,
                                        Label20, Label21, Label22, Label23, Label24, Label25 };
            int temp = 0;
            for (int i = 0; i < 25; i++)
            {
                temp = rnd.Next(1, 41);
                if (lsRndDigite.Count == 0 || !cl.SerchMatchingNumberInArr(lsRndDigite.ToArray(), temp))
                {
                    lsRndDigite.Add(temp);

                    if (temp >= 10)
                        arrAllLabels[i].Content = temp;
                    else
                        arrAllLabels[i].Content = $" {temp}";
                }
                else
                    i--;
            }
            arrAllRandomDigits = lsRndDigite.ToArray();
            cl.SortingArr(ref arrAllRandomDigits);
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (textBox.Text.Length <= 77 && e.Text != string.Empty)
            {
                int IndexStartSelection = textBox.SelectionStart;

                if ((!Char.IsDigit(e.Text, 0)))
                {
                    e.Handled = true;
                    string tamp = cl.CopyTheText(textBox.Text, textBox.SelectionStart, textBox.Text.Length);

                    if (textBox.Text != string.Empty && IndexStartSelection != 0)
                    {
                        if ((textBox.SelectionStart != textBox.Text.Length)
                            && textBox.Text[(IndexStartSelection - 1)] != ','
                            && textBox.Text[(IndexStartSelection)] != ',')
                        {
                            textBox.Text = textBox.Text.Remove(textBox.SelectionStart, tamp.Length);
                            textBox.Text = textBox.Text + "," + tamp;
                            textBox.SelectionStart = IndexStartSelection + 1;
                        }
                        else
                        if (textBox.Text[(textBox.Text.Length - 1)] != ',' && IndexStartSelection == textBox.Text.Length)
                        {
                            textBox.Text = textBox.Text + ",";
                            textBox.SelectionStart = textBox.Text.Length;
                        }
                    }
                }
            }
            else
                e.Handled = true;
        }

        private void textBox_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            if (cl.SearchBigNumberInArr(cl.GetArrFiltringNumbersInTheText(textBox.Text), 40))
                ViewboxWarning.Visibility = Visibility.Visible;
            else
                ViewboxWarning.Visibility = Visibility.Hidden;

            int countNumbers = cl.GetCountNumbersAfterSimbols(textBox.Text);

            textBox.Text = cl.DeleteExtraCommaInText(textBox.Text);
            LabelCountNumbers.Content = $"{countNumbers}/15";

            if (countNumbers > 15)
                LabelCountNumbers.Foreground = Brushes.Red;
            else
                LabelCountNumbers.Foreground = Brushes.Snow;

            if (e.Key == Key.Back && textBox.Text != string.Empty)
                textBox.SelectionStart = (index - 1);
        }

        private void textBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            index = textBox.SelectionStart;
            if (e.Key == Key.Space)
                e.Handled = true;

            if (e.Key == Key.LeftCtrl || e.Key == Key.RightCtrl
                || e.Key == Key.LeftShift || e.Key == Key.RightShift)
            {
                textBox.IsEnabled = false;
                secondCTRL = 0;
            }
        }

        private void textBox_PreviewMouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;
        }
    }
}
