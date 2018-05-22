using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
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

        private List<int> listThisStageRandomPicsPositionLeft { get; set; } = new List<int>() { 167, 285 };
        private List<int> listThisStageRandomPicsPositionTop { get; set; } = new List<int>() { 10, 10 };

        public static List<int> listPicVisibility { get; private set; } = new List<int>();

        public static byte picturesCount { get; set; } = 2;
        public static byte stage { get; set; } = 1;

        public VisualMemoryTestRandomPicturesPage()
        {
            InitializeComponent();

            if (stage != 1)
                IsInitializedListNewValues();

            listPicVisibility.Clear();
            PicRandomVisibility();
            StartStage.Content = $"{stage}/10";
        }


        private void Button_Exit_The_Test_And_View_Result(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new VisualMemoryTestResultPage());
        }

        private void Button_Start_Stage(object sender, RoutedEventArgs e)
        {
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

                    switch (number)
                    {
                        case 1:
                            Pic1.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic1, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic1, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 2:
                            Pic2.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic2, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic2, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 3:
                            Pic3.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic3, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic3, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 4:
                            Pic4.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic4, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic4, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 5:
                            Pic5.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic5, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic5, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 6:
                            Pic6.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic6, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic6, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 7:
                            Pic7.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic7, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic7, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 8:
                            Pic8.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic8, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic8, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 9:
                            Pic9.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic9, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic9, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 10:
                            Pic10.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic10, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic10, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 11:
                            Pic11.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic11, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic11, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 12:
                            Pic12.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic12, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic12, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 13:
                            Pic13.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic13, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic13, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 14:
                            Pic14.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic14, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic14, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 15:
                            Pic15.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic15, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic15, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 16:
                            Pic16.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic16, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic16, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 17:
                            Pic17.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic17, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic17, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 18:
                            Pic18.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic18, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic18, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 19:
                            Pic19.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic19, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic19, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 20:
                            Pic20.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic20, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic20, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 21:
                            Pic21.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic21, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic21, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 22:
                            Pic22.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic22, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic22, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 23:
                            Pic23.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic23, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic23, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 24:
                            Pic24.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic24, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic24, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 25:
                            Pic25.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic25, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic25, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 26:
                            Pic26.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic26, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic26, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 27:
                            Pic27.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic27, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic27, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 28:
                            Pic28.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic28, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic28, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 29:
                            Pic29.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic29, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic29, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 30:
                            Pic30.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic30, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic30, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 31:
                            Pic31.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic31, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic31, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 32:
                            Pic32.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic32, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic32, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 33:
                            Pic33.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic33, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic33, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 34:
                            Pic34.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic34, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic34, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 35:
                            Pic35.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic35, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic35, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 36:
                            Pic36.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic36, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic36, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 37:
                            Pic37.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic37, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic37, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 38:
                            Pic38.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic38, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic38, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 39:
                            Pic39.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic39, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic39, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 40:
                            Pic40.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic40, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic40, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 41:
                            Pic41.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic41, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic41, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 42:
                            Pic42.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic42, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic42, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 43:
                            Pic43.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic43, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic43, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 44:
                            Pic44.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic44, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic44, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 45:
                            Pic45.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic45, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic45, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 46:
                            Pic46.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic46, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic46, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 47:
                            Pic47.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic47, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic47, listThisStageRandomPicsPositionTop[i]);
                            break;
                        case 48:
                            Pic48.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic48, listThisStageRandomPicsPositionLeft[i]);
                            Canvas.SetTop(Pic48, listThisStageRandomPicsPositionTop[i]);
                            break;
                    }
                }
                else
                {
                    i--;
                }
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
