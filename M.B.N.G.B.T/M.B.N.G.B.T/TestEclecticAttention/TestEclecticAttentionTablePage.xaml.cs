using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Threading;

namespace M.B.N.G.B.T.TestEclecticAttention
{
    public partial class TestEclecticAttentionTablePage : Page
    {
        private ClassLibraryMBNGBT cl = new ClassLibraryMBNGBT();
        private DispatcherTimer dispatcherTimer = new DispatcherTimer();

        private Label[] arrAllLabels = new Label[105];
        private Label[] arrAllLabelsTrueNumbers = new Label[10];
        private List<int> listAllLabelsContent = new List<int>();

        private byte counterVibronicTrueNumbers = 0;
        private int secondForBrushingLabels = 0;

        private static List<int> listVibronicTrueNumbers = new List<int>();
        private static List<int> listVibronicFalseNumbers = new List<int>();
        private static List<int> listTrueNumbers = new List<int>();
        private static byte counterVibronicaFalseNumbers = 0;
        private static int second = 0;
        private static int chekedRadioButton = 0;

        public static List<int> ListVibronicTrueNumbers { get { return listVibronicTrueNumbers; } }
        public static List<int> ListVibronicFalseNumbers { get { return listVibronicFalseNumbers; } }
        public static List<int> ListTrueNumbers { get { return listTrueNumbers; } }
        public static byte CounterVibronicaFalseNumbers { get { return counterVibronicaFalseNumbers; } }
        public static int Second { get { return second; } }
        public static int ChekedRadioButton { get { return chekedRadioButton; } }
        
        public TestEclecticAttentionTablePage()
        {
            listVibronicTrueNumbers.Clear();
            listVibronicFalseNumbers.Clear();
            listTrueNumbers.Clear();
            counterVibronicaFalseNumbers = 0;
            chekedRadioButton = 0;
            second = 0;

            InitializeComponent();

            InitializeLabels();

            dispatcherTimer.Tick += new EventHandler(LabelTimer);
            dispatcherTimer.Start();
        }

        private void Button_View_Result(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
            NavigationService.Navigate(new TestEclecticAttentionResultPage());
        }

        private void Button_Exit_The_Test(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
            NavigationService.Navigate(new TestEclecticAttentionRulePage());
        }

        private void LabelNumberAll_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            secondForBrushingLabels = 0;
            if (cl.SerchMatchingNumberInArr(listTrueNumbers.ToArray(), Convert.ToInt32(((Label)sender).Content))
                && !cl.SerchMatchingNumberInArr(listVibronicTrueNumbers.ToArray(), Convert.ToInt32(((Label)sender).Content)))
            {
                listVibronicTrueNumbers.Add(Convert.ToInt32(((Label)sender).Content));
                LabelVibronicTrueNumbers.Content = $"Ճիշտ {++counterVibronicTrueNumbers}/10";
                LabelVibronicTrueNumbers.Foreground = Brushes.LightGreen;
                if (counterVibronicTrueNumbers == 10)
                {
                    for (int i = 0; i < arrAllLabels.Length; i++)
                        arrAllLabels[i].IsEnabled = false;

                    dispatcherTimer.Stop();
                    Timer.Foreground = Brushes.Red;
                    AllLabels.Visibility = Visibility.Collapsed;
                    LabelLastStep.Visibility = Visibility.Visible;
                    viewBoxRadioButtonsLastStep.Visibility = Visibility.Visible;
                }
                for (int i = 0; i < arrAllLabelsTrueNumbers.Length; i++)
                {
                    if (Convert.ToInt32(arrAllLabelsTrueNumbers[i].Content) == Convert.ToInt32(((Label)sender).Content))
                    {
                        arrAllLabelsTrueNumbers[i].Foreground = Brushes.LightGreen;
                        i = arrAllLabelsTrueNumbers.Length;
                    }
                }
            }
            else
            {
                LabelVibronicFalseNumbers.Foreground = Brushes.Red;
                LabelVibronicFalseNumbers.Content = $"Սխալ {++counterVibronicaFalseNumbers}/10";
                BrushingLabels(((FrameworkElement)sender).Name, Brushes.Red);

                if (counterVibronicaFalseNumbers == 11)
                {
                    dispatcherTimer.Stop();
                    NavigationService.Navigate(new TestEclecticAttentionResultPage());
                }
            }
        }

        private void LabelTimer(object sender, EventArgs e)
        {
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            if (second == 999)
            {
                dispatcherTimer.Stop();
                NavigationService.Navigate(new TestEclecticAttentionRulePage());
            }
            if (secondForBrushingLabels == 2)
            {
                LabelVibronicFalseNumbers.Foreground = Brushes.Snow;
                LabelVibronicTrueNumbers.Foreground = Brushes.Snow;
            }
            Timer.Content = (++second);
            secondForBrushingLabels++;
        }

        private void InitializeLabels()
        {
            Random rnd = new Random();
            int temp = 0;
            arrAllLabels = new[] {  LabelNumber1, LabelNumber2, LabelNumber3, LabelNumber4, LabelNumber5, LabelNumber6, LabelNumber7, LabelNumber8, LabelNumber9, LabelNumber10,
                                    LabelNumber11, LabelNumber12, LabelNumber13, LabelNumber14, LabelNumber15, LabelNumber16, LabelNumber17, LabelNumber18, LabelNumber19, LabelNumber20,
                                    LabelNumber21, LabelNumber22, LabelNumber23, LabelNumber24, LabelNumber25, LabelNumber26, LabelNumber27, LabelNumber28, LabelNumber29, LabelNumber30,
                                    LabelNumber31, LabelNumber32, LabelNumber33, LabelNumber34, LabelNumber35, LabelNumber36, LabelNumber37, LabelNumber38, LabelNumber39, LabelNumber40,
                                    LabelNumber41, LabelNumber42, LabelNumber43, LabelNumber44, LabelNumber45, LabelNumber46, LabelNumber47, LabelNumber48, LabelNumber49, LabelNumber50,
                                    LabelNumber51, LabelNumber52, LabelNumber53, LabelNumber54, LabelNumber55, LabelNumber56, LabelNumber57, LabelNumber58, LabelNumber59, LabelNumber60,
                                    LabelNumber61, LabelNumber62, LabelNumber63, LabelNumber64, LabelNumber65, LabelNumber66, LabelNumber67, LabelNumber68, LabelNumber69, LabelNumber70,
                                    LabelNumber71, LabelNumber72, LabelNumber73, LabelNumber74, LabelNumber75, LabelNumber76, LabelNumber77, LabelNumber78, LabelNumber79, LabelNumber80,
                                    LabelNumber81, LabelNumber82, LabelNumber83, LabelNumber84, LabelNumber85, LabelNumber86, LabelNumber87, LabelNumber88, LabelNumber89, LabelNumber90,
                                    LabelNumber91, LabelNumber92, LabelNumber93, LabelNumber94, LabelNumber95, LabelNumber96, LabelNumber97, LabelNumber98, LabelNumber99, LabelNumber100,
                                    LabelNumber101, LabelNumber102, LabelNumber103, LabelNumber104, LabelNumber105, };

            arrAllLabelsTrueNumbers = new[] { LabelTrueNumber1, LabelTrueNumber2, LabelTrueNumber3, LabelTrueNumber4, LabelTrueNumber5, LabelTrueNumber6, LabelTrueNumber7, LabelTrueNumber8, LabelTrueNumber9, LabelTrueNumber10 };

            for (int i = 0; i < arrAllLabels.Length; i++)
            {
                temp = rnd.Next(100, 1000);
                if (listAllLabelsContent.Count == 0 || !cl.SerchMatchingNumberInArr(listAllLabelsContent.ToArray(), temp))
                {
                    arrAllLabels[i].Content = temp;
                    listAllLabelsContent.Add(temp);
                }
                else
                    i--;
            }

            for (int i = 0; i < 10; i++)
            {
                temp = (int)arrAllLabels[rnd.Next(1, 105)].Content;
                if (!cl.SerchMatchingNumberInArr(listTrueNumbers.ToArray(), temp))
                {
                    listTrueNumbers.Add(temp);
                    arrAllLabelsTrueNumbers[i].Content = temp;
                }
                else
                    i--;
            }
        }

        private void LabelNumberAll_MouseEnter(object sender, MouseEventArgs e)
        {
            BrushingLabels(((FrameworkElement)sender).Name, Brushes.YellowGreen);
        }

        private void LabelNumberAll_MouseLeave(object sender, MouseEventArgs e)
        {
            BrushingLabels(((FrameworkElement)sender).Name, Brushes.Snow);
            LabelVibronicTrueNumbers.Foreground = Brushes.Snow;
            LabelVibronicFalseNumbers.Foreground = Brushes.Snow;
        }

        private void BrushingLabels(string name, Brush color)
        {
            for (int i = 0; i < arrAllLabels.Length; i++)
            {
                if (arrAllLabels[i].Name == name)
                {
                    arrAllLabels[i].Foreground = color;
                    i = arrAllLabels.Length;
                }
            }
        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Name)
            {
                case "radioButton1":
                    chekedRadioButton = 1;
                    break;
                case "radioButton2":
                    chekedRadioButton = 2;
                    break;
                case "radioButton3":
                    chekedRadioButton = 3;
                    break;
            }
            buttonViewResult.Visibility = Visibility.Visible;
            buttonExitTheTest.Visibility = Visibility.Collapsed;
        }
    }
}