using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using System.Windows.Threading;

namespace M.B.N.G.B.T.ConcentrationDefinitionTest
{
    /// <summary>
    /// Логика взаимодействия для ConcentrationDefinitionTestTablePage.xaml
    /// </summary>
    public partial class ConcentrationDefinitionTestTablePage : Page
    {
        private List<int> lsRndDigite { get; set; } = new List<int>();
        private Label[] arrAllLabels { get; set; } = new Label[25];

        public static int[][] arrAllStageRandomDigits { get; private set; } = new int[5][];
        public static int[][] arrAllStageDigitsInTextBox { get; private set; } = new int[5][];
        public static int[][] arrAllStageRightNumbers { get; private set; } = new int[5][];
        public static int[][] arrAllStageAbsentNumbers { get; private set; } = new int[5][];
        public static int[][] arrAllStageExtraNumbers { get; private set; } = new int[5][];
        public static string[] AllStageTime { get; private set; } = new string[5];
        public static byte stage { get; set; } = 1;

        private Random rnd = new Random();
        private ClassLibraryMBNGBT cl = new ClassLibraryMBNGBT();
        private DispatcherTimer dispatcherTimer = new DispatcherTimer();

        private int second { get; set; } = 0;
        private int minute { get; set; } = 0;
        private int warningSecond { get; set; } = 0;
        private bool warningDoor { get; set; } = false;

        public ConcentrationDefinitionTestTablePage()
        {
            InitializeComponent();
            if (stage == 5)
                buttonNextStage.Content = "Ավարտել թեսնը";

            if (stage == 1)
            {
                arrAllStageRandomDigits = new int[5][];
                arrAllStageDigitsInTextBox = new int[5][];
                arrAllStageRightNumbers = new int[5][];
                arrAllStageAbsentNumbers = new int[5][];
                arrAllStageExtraNumbers = new int[5][];
                AllStageTime = new string[5];
            }
            dispatcherTimer.Start();
            dispatcherTimer.Tick += new EventHandler(LabelTimer);

            startStage.Content = $"{stage}/5";
            textBox.Focus();
            ChangeContentButtonRandom();

            arrAllStageRightNumbers[stage - 1] = cl.SortingAndSerchInArrMissingNumbers(lsRndDigite.ToArray(), 40).ToArray();
        }
        private void Button_Exit_The_Test(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
            NavigationService.Navigate(new ConcentrationDefinitionTestRulePage());
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

            if (minute == 5 && second == 0)
            {
                dispatcherTimer.Stop();
                NavigationService.Navigate(new ConcentrationDefinitionTestResultPage());
            }
            if (warningSecond == 10 && warningDoor)
            {
                warningDoor = false;
                ViewboxWarning.Visibility = Visibility.Hidden;
            }
            warningSecond++;
        }

        private void ButtonNextStage(object sender, RoutedEventArgs e)
        {
            textBox.Focus();
            int[] temp = cl.FilteringDigitsInTheText(textBox.Text);
            if (!cl.SearchBigNumberInArr(temp, 40))
            {
                dispatcherTimer.Stop();
                arrAllStageDigitsInTextBox[stage - 1] = temp;
                arrAllStageExtraNumbers[stage - 1] = cl.GetArrayMissingNumbersInAnArray(arrAllStageDigitsInTextBox[stage - 1], arrAllStageRightNumbers[stage - 1]);
                arrAllStageAbsentNumbers[stage - 1] = cl.GetArrayMissingNumbersInAnArray(arrAllStageRightNumbers[stage - 1], arrAllStageDigitsInTextBox[stage - 1]);

                if (second < 10)
                    AllStageTime[stage - 1] = $"{minute}:0{second}";
                else
                    AllStageTime[stage - 1] = $"{minute}:0{second}";

                if (arrAllStageAbsentNumbers[stage - 1].Length != 0)
                    cl.SortingArr(ref arrAllStageAbsentNumbers[stage - 1]);
                if (arrAllStageExtraNumbers[stage - 1].Length != 0)
                    cl.SortingArr(ref arrAllStageExtraNumbers[stage - 1]);

                stage++;
                if (stage != 6)
                    NavigationService.Navigate(new ConcentrationDefinitionTestTablePage());
                else
                    NavigationService.Navigate(new ConcentrationDefinitionTestResultPage());
            }
            else
            {
                ViewboxWarning.Visibility = Visibility.Visible;
                warningSecond = 0;
                warningDoor = true;
            }
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
            arrAllStageRandomDigits[stage - 1] = lsRndDigite.ToArray();
            cl.SortingArr(ref arrAllStageRandomDigits[stage - 1]);
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (textBox.Text.Length <= 77)
            {
                if (textBox.Text.Length == 29)
                    buttonNextStage.Visibility = Visibility.Visible;

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
            if (textBox.Text.Length < 29)
                buttonNextStage.Visibility = Visibility.Hidden;
        }

        private void textBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }
    }
}
