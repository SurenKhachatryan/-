using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace M.B.N.G.B.T.VisualMemoryTest
{
    /// <summary>
    /// Логика взаимодействия для RandomPicturesPage.xaml
    /// </summary>
    public partial class VisualMemoryTestRandomPicturesPage : Page
    {
        private ClassLibraryMBNGBT cl = new ClassLibraryMBNGBT();
        private Random rnd = new Random();
        private DispatcherTimer dispatcherTimer = new DispatcherTimer();

        private int[] arrAllSrageIntervalSecondViewPics = { 15, 30, 60, 35, 40, 45, 50, 00, 00, 30 };
        private int[] arrAllSrageIntervalMinuteViewPics = { 0, 0, 0, 1, 1, 1, 1, 2, 2, 2 };

        private List<int> listThisStageRandomPicsPositionLeft { get; set; } = new List<int>() { 167, 285 };
        private List<int> listThisStageRandomPicsPositionTop { get; set; } = new List<int>() { 10, 10 };
        private Image[] arrAllPicsSubject = new Image[48];

        public static List<int> listPicVisibility { get; private set; } = new List<int>();

        public static byte picturesCount { get; set; } = 2;
        public static byte stage { get; set; } = 1;

        private int second { get; set; } = 0;
        private int minute { get; set; } = 0;

        public VisualMemoryTestRandomPicturesPage()
        {
            InitializeComponent();

            arrAllPicsSubject = new Image[] {Pic1,Pic2,Pic3,Pic4,Pic5,Pic6,Pic7,Pic8,Pic9,Pic10,Pic11,Pic12,Pic13,Pic14,Pic15,Pic16,Pic17,
                                             Pic18,Pic19,Pic20,Pic21,Pic22,Pic23,Pic24,Pic25,Pic26,Pic27,Pic28,Pic29,Pic30,Pic31,Pic32,
                                             Pic33,Pic34,Pic35,Pic36,Pic37,Pic38,Pic39,Pic40,Pic41,Pic42,Pic43,Pic44,Pic45,Pic46,Pic47,Pic48};

            minute = arrAllSrageIntervalMinuteViewPics[stage - 1];
            second = arrAllSrageIntervalSecondViewPics[stage - 1];

            if (stage != 1)
                IsInitializedListNewValues();

            dispatcherTimer.Tick += new EventHandler(LabelTimer);
            listPicVisibility.Clear();
            PicRandomVisibility();
            StartStage.Content = $"{stage}/10";
            dispatcherTimer.Start();
        }

        private void LabelTimer(object sender, EventArgs e)
        {
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            if (second == 0 && minute != 0)
            {
                Timer.Content = $"{minute--}:00";
                second = 60;
            }
            else
            if (second <= 9)
                Timer.Content = $"{minute}:0{second}";
            else
                Timer.Content = $"{minute}:{second}";

            if ((stage == 1 && second == 7) || (stage == 2 && second == 15) || (stage > 2 && second == 30 && minute == 0))
                Timer.Foreground = Brushes.Yellow;
            else
            if ((stage == 1 && second == 4) || (stage == 2 && second == 7) || (stage > 2 && second == 15 && minute == 0))
                Timer.Foreground = Brushes.Red;

            if (second == -1 && minute == 0)
            {
                dispatcherTimer.Stop();
                NavigationService.Navigate(new VisualMemoryTestAllPicturesPage());
            }
            second--;
        }

        private void Button_Exit_The_Test_And_View_Result(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
            NavigationService.Navigate(new VisualMemoryTestResultPage());
        }

        private void Button_Start_Stage(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
            NavigationService.Navigate(new VisualMemoryTestAllPicturesPage());
        }

        private void PicRandomVisibility()
        {
            int number = 0;

            for (int i = 0; i < picturesCount; i++)
            {
                number = rnd.Next(1, 49);

                if (listPicVisibility.Count == 0 || !cl.SerchMatchingNumberInArr(listPicVisibility.ToArray(), number))
                {
                    listPicVisibility.Add(number);
                    arrAllPicsSubject[number - 1].Visibility = Visibility.Visible;
                    Canvas.SetLeft(arrAllPicsSubject[number - 1], listThisStageRandomPicsPositionLeft[i]);
                    Canvas.SetTop(arrAllPicsSubject[number - 1], listThisStageRandomPicsPositionTop[i]);
                }
                else
                    i--;
            }
        }

        private void IsInitializedListNewValues()
        {
            switch (stage)
            {
                case 2:
                    listThisStageRandomPicsPositionLeft = new List<int>() { 21, 157, 291, 423 };
                    listThisStageRandomPicsPositionTop = new List<int>() { 10, 10, 10, 10 };
                    break;
                case 3:
                    listThisStageRandomPicsPositionLeft = new List<int>() { 117, 225, 333, 117, 225, 333 };
                    listThisStageRandomPicsPositionTop = new List<int>() { 10, 10, 10, 118, 118, 118 };
                    break;
                case 4:
                    listThisStageRandomPicsPositionLeft = new List<int>() { 65, 173, 281, 389, 65, 173, 281, 389 };
                    listThisStageRandomPicsPositionTop = new List<int>() { 10, 10, 10, 10, 118, 118, 118, 118 };
                    break;
                case 5:
                    listThisStageRandomPicsPositionLeft = new List<int>() { 9, 117, 225, 333, 441, 9, 117, 225, 333, 441 };
                    listThisStageRandomPicsPositionTop = new List<int>() { 10, 10, 10, 10, 10, 118, 118, 118, 118, 118 };
                    break;
                case 6:
                    listThisStageRandomPicsPositionLeft = new List<int>() { 9, 117, 225, 333, 441, 9, 117, 225, 333, 441, 171, 279 };
                    listThisStageRandomPicsPositionTop = new List<int>() { 10, 10, 10, 10, 10, 118, 118, 118, 118, 118, 226, 226 };
                    break;
                case 7:
                    listThisStageRandomPicsPositionLeft = new List<int>() { 9, 117, 225, 333, 441, 9, 117, 225, 333, 441, 63, 171, 279, 387 };
                    listThisStageRandomPicsPositionTop = new List<int>() { 10, 10, 10, 10, 10, 118, 118, 118, 118, 118, 226, 226, 226, 226 };
                    break;
                case 8:
                    listThisStageRandomPicsPositionLeft = new List<int>() { 9, 117, 225, 333, 441, 9, 117, 225, 333, 441, 63, 171, 279, 387, 171, 279 };
                    listThisStageRandomPicsPositionTop = new List<int>() { 10, 10, 10, 10, 10, 118, 118, 118, 118, 118, 226, 226, 226, 226, 333, 333 };
                    break;
                case 9:
                    listThisStageRandomPicsPositionLeft = new List<int>() { 9, 117, 225, 333, 441, 9, 117, 225, 333, 441, 63, 171, 279, 387, 63, 171, 279, 387 };
                    listThisStageRandomPicsPositionTop = new List<int>() { 10, 10, 10, 10, 10, 118, 118, 118, 118, 118, 226, 226, 226, 226, 333, 333, 333, 333 };
                    break;
                case 10:
                    listThisStageRandomPicsPositionLeft = new List<int>() { 9, 117, 225, 333, 441, 9, 117, 225, 333, 441, 9, 117, 225, 333, 441, 9, 117, 225, 333, 441 };
                    listThisStageRandomPicsPositionTop = new List<int>() { 10, 10, 10, 10, 10, 118, 118, 118, 118, 118, 226, 226, 226, 226, 226, 333, 333, 333, 333, 333 };
                    break;
            }
        }
    }
}
