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

        public static int[] arrAllDigitsInTextBox { get; private set; } = new int[0];
        public static string TextBoxText { get; private set; } = string.Empty;
        public static int[] arrAllRightNumbers { get; private set; } = new int[0];
        private static int[] arrBigNumbers = new int[0];
        private static int[] arrAllRandomDigits = new int[0];
        private static int[] arrAllAbsentNumbers = new int[0];
        private static int[] arrAllExtraNumbers = new int[0];
        private static int[] arrAllRightNumbersUser = new int[0];

        public static bool IsEmptyTextBox { get; private set; } = true;
        public static bool IsBigNumbersInTextBox { get; private set; } = false;
        public static int CountBigNumbers { get; private set; } = 0;
        public static int CountNumberOfEqualDigits { get; private set; }

        public static int[] ArrBigNumbers { get { return arrBigNumbers; } }
        public static int[] ArrAllRandomDigits { get { return arrAllRandomDigits; } }
        public static int[] ArrAllAbsentNumbers { get { return arrAllAbsentNumbers; } }
        public static int[] ArrAllExtraNumbers { get { return arrAllExtraNumbers; } }
        public static int[] ArrAllRightNumbersUser { get { return arrAllRightNumbersUser; } }

        private Random rnd = new Random();
        private ClassLibraryMBNGBT cl = new ClassLibraryMBNGBT();
        private DispatcherTimer dispatcherTimer = new DispatcherTimer();

        private int Index { get; set; } = 0;
        private int Second { get; set; } = 0;
        private int Minute { get; set; } = 0;
        private int secondCTRL { get; set; } = 0;
        private int repeatNumbersSecond { get; set; } = 0;

        public ConcentrationDefinitionTestTablePage()
        {
            InitializeComponent();

            arrAllRandomDigits = new int[0];
            arrAllDigitsInTextBox = new int[0];
            arrAllRightNumbers = new int[0];
            arrAllAbsentNumbers = new int[0];
            arrAllExtraNumbers = new int[0];
            arrAllRightNumbersUser = new int[0];
            IsEmptyTextBox = true;
            IsBigNumbersInTextBox = false;
            CountBigNumbers = 0;
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

            if (Second == 60)
            {
                Second = 0;
                Minute++;
                timer.Foreground = Brushes.Yellow;
            }

            if (cl.SearchEqualNumbersInALineAfterAComma(textBox.Text))
            {
                if (repeatNumbersSecond == 2)
                {
                    if (cl.SearchBigNumberInArr(cl.GetArrFiltringNumbersInTheText(textBox.Text), 40) && cl.SearchEqualNumbersInALineAfterAComma(textBox.Text))
                        LabelWarning.Content = "Տեքստում կա 40-ից մեծ թիվ և կրկնվող թիվ:";
                    else
                        LabelWarning.Content = "Տեքստում կա կրկնվող թիվ:";
                }
                if (repeatNumbersSecond != 2)
                    repeatNumbersSecond++;
            }

            if (Minute == 1 && Second == 15)
                timer.Foreground = Brushes.Red;

            if (Second < 10)
                timer.Content = $"{Minute}:0{Second}";
            else
                timer.Content = $"{Minute}:{Second}";

            if (Minute == 1 && Second == 30)
            {
                int[] arr = cl.GetArrFiltringNumbersInTheText(textBox.Text);
                IsEmptyTextBox = (textBox.Text == string.Empty) ? true : false;
                IsBigNumbersInTextBox = (cl.SearchBigNumberInArr(cl.GetArrFiltringNumbersInTheText(textBox.Text), 40)) ? true : false;
                CountBigNumbers = cl.GetCountAndArrBigNumbers(cl.GetArrFiltringNumbersInTheText(textBox.Text), 40, out arrBigNumbers);
                CountNumberOfEqualDigits = cl.GetCountNumberOfEqualDigits(arr);

                if (!IsEmptyTextBox && Char.IsDigit(Convert.ToChar(textBox.Text[textBox.Text.Length - 1])) &&
                    !Char.IsDigit(Convert.ToChar(textBox.Text[textBox.Text.Length - 2])) &&
                    !IsBigNumbersInTextBox &&  textBox.Text.Length > 5 && CountNumberOfEqualDigits <= 1)
                {
                    int[] arrNew = cl.DeleteItmesInArr(arr, arr.Length - 1);
                    int temp = arr[arr.Length - 1];
                    arr[arr.Length - 1] = -1;

                    if (temp == 4 && cl.SerchMatchingNumberInArr(arrAllRightNumbers, 40) && arr.Length >= 5)
                        textBox.Text += "0";
                    else
                    if (cl.SerchMatchingNumberInArr(arr, temp) &&
                        (temp == 1 || temp == 2 || temp == 3))
                        textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    else
                    if (!cl.SerchMatchingNumberInArr(arrAllRightNumbers, temp)
                        && cl.SerchMatchingNumberInArr(arr, temp) &&
                        (temp == 1 || temp == 2 || temp == 3))
                        textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    else
                    if (cl.IsSortedNumbers(arrNew) &&
                        (temp == 1 || temp == 2 || temp == 3) &&
                       !cl.SerchMatchingNumberInArr(arrAllRightNumbers, temp))
                        textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                }
                CountNumberOfEqualDigits = cl.GetCountNumberOfEqualDigits(cl.GetArrFiltringNumbersInTheText(textBox.Text));
                LabelCountNumbers.Content = $"{cl.GetCountNumbersAfterSimbols(textBox.Text)}/15";
                if (!IsBigNumbersInTextBox && !IsEmptyTextBox && CountNumberOfEqualDigits == 0)
                {
                    dispatcherTimer.Stop();
                    textBox.IsEnabled = false;
                    timer.Foreground = Brushes.Black;
                    buttonFinishTest.Visibility = Visibility.Visible;
                    LabelWarning.Visibility = Visibility.Hidden;
                }
                else
                {
                    TextBoxText = textBox.Text;
                    NavigationService.Navigate(new ConcentrationDefinitionTestResultPage());
                }
            }

            if (secondCTRL == 2)
            {
                textBox.IsEnabled = true;
                textBox.Focus();
            }
            Second++;
            secondCTRL++;
        }

        private void Button_Finish_Test(object sender, RoutedEventArgs e)
        {
            arrAllDigitsInTextBox = cl.GetArrFiltringNumbersInTheText(textBox.Text);
            arrAllExtraNumbers = cl.GetArrayMissingNumbersInAnArray(arrAllDigitsInTextBox, arrAllRightNumbers);
            arrAllAbsentNumbers = cl.GetArrayMissingNumbersInAnArray(arrAllRightNumbers, arrAllDigitsInTextBox);
            arrAllRightNumbersUser = cl.GetRightNumbersInAnArray(arrAllRightNumbers, arrAllDigitsInTextBox);

            if (arrAllAbsentNumbers.Length != 0)
                cl.SortingArr(ref arrAllAbsentNumbers);
            if (arrAllExtraNumbers.Length != 0)
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
            if (cl.GetCountNumbersAfterSimbols(textBox.Text) == 15 && !Char.IsDigit(Convert.ToChar(e.Text)))
                e.Handled = true;
            else
            if (textBox.Text.Length <= 70 && e.Text != string.Empty)
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
            int countNumbers = cl.GetCountNumbersAfterSimbols(textBox.Text);
            bool bigNumbers = cl.SearchBigNumberInArr(cl.GetArrFiltringNumbersInTheText(textBox.Text), 40);
            bool repeatNumbers = cl.SearchEqualNumbersInALineAfterAComma(textBox.Text);

            if (repeatNumbers != true)
                repeatNumbersSecond = 0;

            if (!bigNumbers && !repeatNumbers)
                LabelWarning.Content = string.Empty;
            else
            if (bigNumbers && repeatNumbers && repeatNumbersSecond == 2)
                LabelWarning.Content = "Տեքստում կա 40-ից մեծ թիվ և կրկնվող թիվ:";
            else
            if (bigNumbers)
                LabelWarning.Content = "Տեքստում կա 40-ից մեծ թիվ:";
            else
            if (repeatNumbers && repeatNumbersSecond == 2)
                LabelWarning.Content = "Տեքստում կա կրկնվող թիվ:";

            textBox.Text = cl.DeleteExtraCommaInText(textBox.Text);
            LabelCountNumbers.Content = $"{countNumbers}/15";

            if (e.Key == Key.Back && textBox.Text != string.Empty)
                textBox.SelectionStart = (Index - 1);
        }

        private void textBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            Index = textBox.SelectionStart;
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
