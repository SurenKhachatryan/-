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

namespace M.B.N.G.B.T.TestEclecticAttention
{
    public partial class TestEclecticAttentionTablePage : Page
    {
        private ClassLibraryMBNGBT cl = new ClassLibraryMBNGBT();
        private DispatcherTimer dispatcherTimer = new DispatcherTimer();

        private Label[] arrAllLabels { get; set; } = new Label[105];
        private List<int> listAllLabelsContent { get; set; } = new List<int>();

        private byte counterVibronicNumbers { get; set; } = 0;
        private int second { get; set; } = 0;

        public TestEclecticAttentionTablePage()
        {
            InitializeComponent();
            InitializeLabels();
            dispatcherTimer.Tick += new EventHandler(LabelTimer);
            dispatcherTimer.Start();
        }

        private void Button_View_Result(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
        }

        private void Button_Exit_The_Test(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
        }

        private void LabelNumberAll_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

            LabelVibronicNumbers.Content = $"{++counterVibronicNumbers}/10";
            if (counterVibronicNumbers == 10)
            {
                buttonViewResult.Visibility = Visibility.Visible;
                for (int i = 0; i < arrAllLabels.Length; i++)
                {
                    arrAllLabels[i].IsEnabled = false;
                }
                dispatcherTimer.Stop();
                LabelVibronicNumbers.Foreground = Brushes.Red;
                Timer.Foreground = Brushes.Red;
            }
        }

        private void LabelTimer(object sender, EventArgs e)
        {
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            if (second == 999)
            {
                dispatcherTimer.Stop();
            }
            Timer.Content = (++second);
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

            for (int i = 0; i < arrAllLabels.Length; i++)
            {
                temp = rnd.Next(100, 1000);
                if (listAllLabelsContent.Count == 0 || !cl.SerchMatchingNumberInArr(listAllLabelsContent.ToArray(), temp))
                {
                    arrAllLabels[i].Content = temp;
                    listAllLabelsContent.Add(temp);
                }
                else
                {
                    i--;
                }
            }
        }

        private void LabelNumberAll_MouseEnter(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < arrAllLabels.Length; i++)
            {
                if (arrAllLabels[i].Name == ((FrameworkElement)sender).Name)
                {
                    arrAllLabels[i].Foreground = Brushes.YellowGreen;
                    i = arrAllLabels.Length;
                }
            }
        }

        private void LabelNumberAll_MouseLeave(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < arrAllLabels.Length; i++)
            {
                if (arrAllLabels[i].Name == ((FrameworkElement)sender).Name)
                {
                    arrAllLabels[i].Foreground = Brushes.Snow;
                    i = arrAllLabels.Length;
                }
            }
        }
    }
}