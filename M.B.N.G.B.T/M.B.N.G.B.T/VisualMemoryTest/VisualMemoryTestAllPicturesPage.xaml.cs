using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace M.B.N.G.B.T.VisualMemoryTest
{
    /// <summary>
    /// Логика взаимодействия для AllPictures.xaml
    /// </summary>
    public partial class VisualMemoryTestAllPicturesPage : Page
    {
        private List<int> listCorrectSelectedPictures { get; set; } = new List<int>();

        private ClassLibraryMBNGBT cl = new ClassLibraryMBNGBT();
        private DispatcherTimer dispatcherTimer = new DispatcherTimer();

        private int picCountChackted { get; set; } = 0;
        private int second { get; set; } = 0;
        private bool door { get; set; } = false;
        private bool isEnabledPics { get; set; } = true;

        public VisualMemoryTestAllPicturesPage()
        {
            InitializeComponent();
            dispatcherTimer.Tick += new EventHandler(LabelTimer);
            StartStage.Content = $"{VisualMemoryTestRandomPicturesPage.stage}/10";
            dispatcherTimer.Start();
        }

        private void LabelTimer(object sender, EventArgs e)
        {
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            
            if (picCountChackted == VisualMemoryTestRandomPicturesPage.picturesCount && picCountChackted != 20)
            {
                VisualMemoryTestRandomPicturesPage.picturesCount += 2;
                VisualMemoryTestRandomPicturesPage.stage += 1;
                NavigationService.Navigate(new VisualMemoryTestRandomPicturesPage());
                dispatcherTimer.Stop();
            }
            else
            if ((second == 60 && door) || (picCountChackted == 20))
            {
                if (picCountChackted == 20)
                    VisualMemoryTestRandomPicturesPage.stage += 1;

                NavigationService.Navigate(new VisualMemoryTestResultPage());
                dispatcherTimer.Stop();
            }
            second++;
        }

        private void Button_Exit_The_Test_And_View_Result(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new VisualMemoryTestResultPage());
            dispatcherTimer.Stop();
        }

        private void IsenabledPics()
        {
            if (picCountChackted == VisualMemoryTestRandomPicturesPage.picturesCount && picCountChackted != 20)
            {
                isEnabledPics = false;
            }
        }

        private void Pic1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 1))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(1);
                    PicYes1.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo1.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 2))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(2);
                    PicYes2.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo2.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 3))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(3);
                    PicYes3.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo3.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 4))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(4);
                    PicYes4.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo4.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 5))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(5);
                    PicYes5.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo5.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 6))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(6);
                    PicYes6.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo6.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic7_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 7))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(7);
                    PicYes7.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo7.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic8_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 8))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(8);
                    PicYes8.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo8.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic9_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 9))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(9);
                    PicYes9.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo9.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic10_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 10))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(10);
                    PicYes10.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo10.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic11_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 11))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(11);
                    PicYes11.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo11.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic12_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 12))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(12);
                    PicYes12.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo12.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic13_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 13))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(13);
                    PicYes13.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo13.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic14_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 14))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(14);
                    PicYes14.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo14.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic15_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 15))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(15);
                    PicYes15.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo15.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic16_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 16))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(16);
                    PicYes16.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo16.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic17_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 17))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(17);
                    PicYes17.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo17.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic18_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 18))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(18);
                    PicYes18.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo18.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic19_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 19))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(19);
                    PicYes19.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo19.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic20_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 20))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(20);
                    PicYes20.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo20.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic21_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 21))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(21);
                    PicYes21.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo21.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic22_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 22))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(22);
                    PicYes22.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo22.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic23_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 23))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(23);
                    PicYes23.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo23.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic24_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 24))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(24);
                    PicYes24.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo24.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic25_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 25))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(25);
                    PicYes25.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo25.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic26_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 26))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(26);
                    PicYes26.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo26.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic27_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 27))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(27);
                    PicYes27.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo27.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic28_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 28))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(28);
                    PicYes28.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo28.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic29_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 29))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(29);
                    PicYes29.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo29.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic30_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 30))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(30);
                    PicYes30.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo30.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic31_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 31))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(31);
                    PicYes31.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo31.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic32_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 32))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(32);
                    PicYes32.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo32.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic33_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 33))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(33);
                    PicYes33.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo33.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic34_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 34))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(34);
                    PicYes34.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo34.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic35_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 35))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(35);
                    PicYes35.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo35.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic36_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 36))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(36);
                    PicYes36.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo36.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic37_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 37))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(37);
                    PicYes37.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo37.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic38_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 38))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(38);
                    PicYes38.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo38.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic39_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 39))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(39);
                    PicYes39.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo39.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic40_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 40))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(40);
                    PicYes40.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo40.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic41_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 41))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(41);
                    PicYes41.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo41.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic42_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 42))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(42);
                    PicYes42.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo42.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic43_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 43))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(43);
                    PicYes43.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo43.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic44_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 44))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(44);
                    PicYes44.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo44.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic45_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 45))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(45);
                    PicYes45.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo45.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic46_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 46))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(46);
                    PicYes46.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo46.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic47_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 47))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(47);
                    PicYes47.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo47.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void Pic48_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), 48))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add(48);
                    PicYes48.Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    PicNo48.Visibility = Visibility.Visible;
                    VisiblуNotSelected();
                    door = true;
                }
            }
        }

        private void VisiblуNotSelected()
        {
            isEnabledPics = false;
            int[] arr;

            if (listCorrectSelectedPictures.Count != 0)
                arr = cl.GetArrayMissingNumbersInAnArray(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), listCorrectSelectedPictures.ToArray());
            else
                arr = VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                switch (arr[i])
                {
                    case 1:
                        PicYes2_1.Visibility = Visibility.Visible;
                        break;
                    case 2:
                        PicYes2_2.Visibility = Visibility.Visible;
                        break;
                    case 3:
                        PicYes2_3.Visibility = Visibility.Visible;
                        break;
                    case 4:
                        PicYes2_4.Visibility = Visibility.Visible;
                        break;
                    case 5:
                        PicYes2_5.Visibility = Visibility.Visible;
                        break;
                    case 6:
                        PicYes2_6.Visibility = Visibility.Visible;
                        break;
                    case 7:
                        PicYes2_7.Visibility = Visibility.Visible;
                        break;
                    case 8:
                        PicYes2_8.Visibility = Visibility.Visible;
                        break;
                    case 9:
                        PicYes2_9.Visibility = Visibility.Visible;
                        break;
                    case 10:
                        PicYes2_10.Visibility = Visibility.Visible;
                        break;
                    case 11:
                        PicYes2_11.Visibility = Visibility.Visible;
                        break;
                    case 12:
                        PicYes2_12.Visibility = Visibility.Visible;
                        break;
                    case 13:
                        PicYes2_13.Visibility = Visibility.Visible;
                        break;
                    case 14:
                        PicYes2_14.Visibility = Visibility.Visible;
                        break;
                    case 15:
                        PicYes2_15.Visibility = Visibility.Visible;
                        break;
                    case 16:
                        PicYes2_16.Visibility = Visibility.Visible;
                        break;
                    case 17:
                        PicYes2_17.Visibility = Visibility.Visible;
                        break;
                    case 18:
                        PicYes2_18.Visibility = Visibility.Visible;
                        break;
                    case 19:
                        PicYes2_19.Visibility = Visibility.Visible;
                        break;
                    case 20:
                        PicYes2_20.Visibility = Visibility.Visible;
                        break;
                    case 21:
                        PicYes2_21.Visibility = Visibility.Visible;
                        break;
                    case 22:
                        PicYes2_22.Visibility = Visibility.Visible;
                        break;
                    case 23:
                        PicYes2_23.Visibility = Visibility.Visible;
                        break;
                    case 24:
                        PicYes2_24.Visibility = Visibility.Visible;
                        break;
                    case 25:
                        PicYes2_25.Visibility = Visibility.Visible;
                        break;
                    case 26:
                        PicYes2_26.Visibility = Visibility.Visible;
                        break;
                    case 27:
                        PicYes2_27.Visibility = Visibility.Visible;
                        break;
                    case 28:
                        PicYes2_28.Visibility = Visibility.Visible;
                        break;
                    case 29:
                        PicYes2_29.Visibility = Visibility.Visible;
                        break;
                    case 30:
                        PicYes2_30.Visibility = Visibility.Visible;
                        break;
                    case 31:
                        PicYes2_31.Visibility = Visibility.Visible;
                        break;
                    case 32:
                        PicYes2_32.Visibility = Visibility.Visible;
                        break;
                    case 33:
                        PicYes2_33.Visibility = Visibility.Visible;
                        break;
                    case 34:
                        PicYes2_34.Visibility = Visibility.Visible;
                        break;
                    case 35:
                        PicYes2_35.Visibility = Visibility.Visible;
                        break;
                    case 36:
                        PicYes2_36.Visibility = Visibility.Visible;
                        break;
                    case 37:
                        PicYes2_37.Visibility = Visibility.Visible;
                        break;
                    case 38:
                        PicYes2_38.Visibility = Visibility.Visible;
                        break;
                    case 39:
                        PicYes2_39.Visibility = Visibility.Visible;
                        break;
                    case 40:
                        PicYes2_40.Visibility = Visibility.Visible;
                        break;
                    case 41:
                        PicYes2_41.Visibility = Visibility.Visible;
                        break;
                    case 42:
                        PicYes2_42.Visibility = Visibility.Visible;
                        break;
                    case 43:
                        PicYes2_43.Visibility = Visibility.Visible;
                        break;
                    case 44:
                        PicYes2_44.Visibility = Visibility.Visible;
                        break;
                    case 45:
                        PicYes2_45.Visibility = Visibility.Visible;
                        break;
                    case 46:
                        PicYes2_46.Visibility = Visibility.Visible;
                        break;
                    case 47:
                        PicYes2_47.Visibility = Visibility.Visible;
                        break;
                    case 48:
                        PicYes2_48.Visibility = Visibility.Visible;
                        break;
                }
            }
        }
    }
}

