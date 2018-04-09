using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace M.B.N.G.B.T.AttentivenessTest
{
    /// <summary>
    /// Логика взаимодействия для RandomPicturesPage.xaml
    /// </summary>
    public partial class RandomPicturesPage : Page
    {
        private ClassLibraryMBNGBT cl = new ClassLibraryMBNGBT();
        private Random rnd = new Random();
        private DispatcherTimer dispatcherTimer = new DispatcherTimer();

        public static List<int> listPicVisibility = new List<int>();
        public static byte startstage = 4;
        private byte second = 16;

        public RandomPicturesPage()
        {
            InitializeComponent();

            dispatcherTimer.Tick += new EventHandler(LabelTimer);
            PicCollapsed();
            dispatcherTimer.Start();
            listPicVisibility.Clear();
            PicRandomVisibility();
        }

        private void LabelTimer(object sender, EventArgs e)
        {
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);

            if (second != 0)
            {
                second--;
                Timer.Content = second;
                if (second == 8)
                {
                    Timer.Foreground = Brushes.Yellow;
                }
                else
                if (second == 5)
                {
                    Timer.Foreground = Brushes.Red;
                }
            }
            else
            {
                dispatcherTimer.Stop();
                MainRandomPicturesPage.Content = new AllPictures();
            }

        }

        public void RndPicPageGridCollapsed()
        {
            RandomPicturesPage1.Visibility = Visibility.Collapsed;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
            MainRandomPicturesPage.Content = new ResultPage();
        }

       

        private void PicRandomVisibility()
        {
            int number = 0;
            int picpositiondigit = -110;
            byte top = 150;

            for (int i = 0; i < startstage; i++)
            {
                number = rnd.Next(1, 48);

                if (listPicVisibility.Count == 0 || !cl.SerchMatchingNumberInArr(listPicVisibility.ToArray(), number))
                {
                    listPicVisibility.Add(number);

                    if (listPicVisibility.Count == 11)
                    {
                        picpositiondigit = -110;
                    }

                    picpositiondigit += 110;
                    switch (number)
                    {
                        case 1:
                            Pic1.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic1, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic1, top);
                            break;
                        case 2:
                            Pic2.Visibility = Visibility.Visible;
                            Canvas.SetLeft(Pic2, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic2, top);
                            break;
                        case 3:
                            Pic3.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic3, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic3, top);
                            break;
                        case 4:
                            Pic4.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic4, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic4, top);
                            break;
                        case 5:
                            Pic5.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic5, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic5, top);
                            break;
                        case 6:
                            Pic6.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic6, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic6, top);
                            break;
                        case 7:
                            Pic7.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic7, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic7, top);
                            break;
                        case 8:
                            Pic8.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic8, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic8, top);
                            break;
                        case 9:
                            Pic9.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic9, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic9, top);
                            break;
                        case 10:
                            Pic10.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic10, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic10, top);
                            break;
                        case 11:
                            Pic11.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic11, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic11, top);
                            break;
                        case 12:
                            Pic12.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic12, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic12, top);
                            break;
                        case 13:
                            Pic13.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic13, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic13, top);
                            break;
                        case 14:
                            Pic14.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic14, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic14, top);
                            break;
                        case 15:
                            Pic15.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic15, picpositiondigit);
                            if (listPicVisibility.Count >10)
                                Canvas.SetTop(Pic15, top);
                            break;
                        case 16:
                            Pic16.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic16, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic16, top);
                            break;
                        case 17:
                            Pic17.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic17, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic17, top);
                            break;
                        case 18:
                            Pic18.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic18, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic18, top);
                            break;
                        case 19:
                            Pic19.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic19, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic19, top);
                            break;
                        case 20:
                            Pic20.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic20, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic20, top);
                            break;
                        case 21:
                            Pic21.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic21, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic21, top);
                            break;
                        case 22:
                            Pic22.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic22, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic22, top);
                            break;
                        case 23:
                            Pic23.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic23, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic23, top);
                            break;
                        case 24:
                            Pic24.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic24, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic24, top);
                            break;
                        case 25:
                            Pic25.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic25, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic25, top);
                            break;
                        case 26:
                            Pic26.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic26, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic26, top);
                            break;
                        case 27:
                            Pic27.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic27, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic27, top);
                            break;
                        case 28:
                            Pic28.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic28, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic28, top);
                            break;
                        case 29:
                            Pic29.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic29, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic29, top);
                            break;
                        case 30:
                            Pic30.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic30, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic30, top);
                            break;
                        case 31:
                            Pic31.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic31, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic31, top);
                            break;
                        case 32:
                            Pic32.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic32, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic32, top);
                            break;
                        case 33:
                            Pic33.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic33, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic33, top);
                            break;
                        case 34:
                            Pic34.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic34, picpositiondigit);
                            if (listPicVisibility.Count >10)
                                Canvas.SetTop(Pic34, top);
                            break;
                        case 35:
                            Pic35.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic35, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic35, top);
                            break;
                        case 36:
                            Pic36.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic36, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic36, top);
                            break;
                        case 37:
                            Pic37.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic37, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic37, top);
                            break;
                        case 38:
                            Pic38.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic38, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic38, top);
                            break;
                        case 39:
                            Pic39.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic39, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic39, top);
                            break;
                        case 40:
                            Pic40.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic40, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic40, top);
                            break;
                        case 41:
                            Pic41.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic41, picpositiondigit);
                            if (listPicVisibility.Count >= 10)
                                Canvas.SetTop(Pic41, top);
                            break;
                        case 42:
                            Pic42.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic42, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic42, top);
                            break;
                        case 43:
                            Pic43.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic43, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic43, top);
                            break;
                        case 44:
                            Pic44.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic44, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic44, top);
                            break;
                        case 45:
                            Pic45.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic45, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic45, top);
                            break;
                        case 46:
                            Pic46.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic46, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic46, top);
                            break;
                        case 47:
                            Pic47.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic47, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic47, top);
                            break;
                        case 48:
                            Pic48.Visibility = Visibility.Visible;
                                Canvas.SetLeft(Pic48, picpositiondigit);
                            if (listPicVisibility.Count > 10)
                                Canvas.SetTop(Pic48, top);
                            break;
                    }
                }
                else
                {
                    i--;
                }
            }
        }
        private void PicCollapsed()
        {
            Pic1.Visibility = Visibility.Collapsed;
            Pic2.Visibility = Visibility.Collapsed;
            Pic3.Visibility = Visibility.Collapsed;
            Pic4.Visibility = Visibility.Collapsed;
            Pic5.Visibility = Visibility.Collapsed;
            Pic6.Visibility = Visibility.Collapsed;
            Pic7.Visibility = Visibility.Collapsed;
            Pic8.Visibility = Visibility.Collapsed;
            Pic9.Visibility = Visibility.Collapsed;
            Pic10.Visibility = Visibility.Collapsed;
            Pic11.Visibility = Visibility.Collapsed;
            Pic12.Visibility = Visibility.Collapsed;
            Pic13.Visibility = Visibility.Collapsed;
            Pic14.Visibility = Visibility.Collapsed;
            Pic15.Visibility = Visibility.Collapsed;
            Pic16.Visibility = Visibility.Collapsed;
            Pic17.Visibility = Visibility.Collapsed;
            Pic18.Visibility = Visibility.Collapsed;
            Pic19.Visibility = Visibility.Collapsed;
            Pic20.Visibility = Visibility.Collapsed;
            Pic21.Visibility = Visibility.Collapsed;
            Pic22.Visibility = Visibility.Collapsed;
            Pic23.Visibility = Visibility.Collapsed;
            Pic24.Visibility = Visibility.Collapsed;
            Pic25.Visibility = Visibility.Collapsed;
            Pic26.Visibility = Visibility.Collapsed;
            Pic27.Visibility = Visibility.Collapsed;
            Pic28.Visibility = Visibility.Collapsed;
            Pic29.Visibility = Visibility.Collapsed;
            Pic30.Visibility = Visibility.Collapsed;
            Pic31.Visibility = Visibility.Collapsed;
            Pic32.Visibility = Visibility.Collapsed;
            Pic33.Visibility = Visibility.Collapsed;
            Pic34.Visibility = Visibility.Collapsed;
            Pic35.Visibility = Visibility.Collapsed;
            Pic36.Visibility = Visibility.Collapsed;
            Pic37.Visibility = Visibility.Collapsed;
            Pic38.Visibility = Visibility.Collapsed;
            Pic39.Visibility = Visibility.Collapsed;
            Pic40.Visibility = Visibility.Collapsed;
            Pic41.Visibility = Visibility.Collapsed;
            Pic42.Visibility = Visibility.Collapsed;
            Pic43.Visibility = Visibility.Collapsed;
            Pic44.Visibility = Visibility.Collapsed;
            Pic45.Visibility = Visibility.Collapsed;
            Pic46.Visibility = Visibility.Collapsed;
            Pic47.Visibility = Visibility.Collapsed;
            Pic48.Visibility = Visibility.Collapsed;

        }
       
    }
}
