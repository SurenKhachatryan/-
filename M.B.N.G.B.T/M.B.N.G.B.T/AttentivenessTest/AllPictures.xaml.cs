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
    /// Логика взаимодействия для AllPictures.xaml
    /// </summary>
    public partial class AllPictures : Page
    {

        private ClassLibraryMBNGBT cl = new ClassLibraryMBNGBT();
        private DispatcherTimer dispatcherTimer = new DispatcherTimer();
        
        private int picCountChackted = 0;
        private int second = 0;
        private bool door = false;

        public AllPictures()
        {
            InitializeComponent();
            dispatcherTimer.Tick += new EventHandler(LabelTimer);
            StartStage.Content = $"{RandomPicturesPage.stage}/10";
            dispatcherTimer.Start();
        }

        private void LabelTimer(object sender, EventArgs e)
        {
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            second++;
            if (second == 1 && picCountChackted == RandomPicturesPage.picturesCount && picCountChackted != 20)
            {
                RandomPicturesPage.picturesCount += 2;
                RandomPicturesPage.stage += 1;
                NavigationService.Navigate(new RandomPicturesPage());
                dispatcherTimer.Stop();
            }
            else
            if (second == 2 && door || picCountChackted == 20)
            {
                NavigationService.Navigate(new ResultPage());
                dispatcherTimer.Stop();
            }
        }

        private void Button_Exit_The_Test_And_View_Result(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ResultPage());
            dispatcherTimer.Stop();
        }

        private void Pic1_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 1))
            {
                picCountChackted++;
                Pic1.IsEnabled = false;
                PicYes1.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo1.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }

        }

        private void Pic2_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 2))
            {
                picCountChackted++;
                Pic2.IsEnabled = false;
                PicYes2.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo2.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic3_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 3))
            {
                picCountChackted++;
                Pic3.IsEnabled = false;
                PicYes3.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo3.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic4_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 4))
            {
                picCountChackted++;
                Pic4.IsEnabled = false;
                PicYes4.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo4.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic5_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 5))
            {
                picCountChackted++;
                Pic5.IsEnabled = false;
                PicYes5.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo5.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic6_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 6))
            {
                picCountChackted++;
                Pic6.IsEnabled = false;
                PicYes6.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo6.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic7_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 7))
            {
                picCountChackted++;
                Pic7.IsEnabled = false;
                PicYes7.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo7.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic8_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 8))
            {
                picCountChackted++;
                Pic8.IsEnabled = false;
                PicYes8.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo8.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic9_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 9))
            {
                picCountChackted++;
                Pic9.IsEnabled = false;
                PicYes9.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo9.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic10_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 10))
            {
                picCountChackted++;
                Pic10.IsEnabled = false;
                PicYes10.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo10.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic11_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 11))
            {
                picCountChackted++;
                Pic11.IsEnabled = false;
                PicYes11.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo11.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic12_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 12))
            {
                picCountChackted++;
                Pic12.IsEnabled = false;
                PicYes12.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo12.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic13_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 13))
            {
                picCountChackted++;
                Pic13.IsEnabled = false;
                PicYes13.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo13.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic14_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 14))
            {
                picCountChackted++;
                Pic14.IsEnabled = false;
                PicYes14.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo14.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic15_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 15))
            {
                picCountChackted++;
                Pic15.IsEnabled = false;
                PicYes15.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo15.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic16_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 16))
            {
                picCountChackted++;
                Pic16.IsEnabled = false;
                PicYes16.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo16.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic17_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 17))
            {
                picCountChackted++;
                Pic17.IsEnabled = false;
                PicYes17.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo17.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic18_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 18))
            {
                picCountChackted++;
                Pic18.IsEnabled = false;
                PicYes18.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo18.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic19_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 19))
            {
                picCountChackted++;
                Pic19.IsEnabled = false;
                PicYes19.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo19.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic20_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 20))
            {
                picCountChackted++;
                Pic20.IsEnabled = false;
                PicYes20.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo20.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic21_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 21))
            {
                picCountChackted++;
                Pic21.IsEnabled = false;
                PicYes21.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo21.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic22_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 22))
            {
                picCountChackted++;
                Pic22.IsEnabled = false;
                PicYes22.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo22.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic23_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 23))
            {
                picCountChackted++;
                Pic23.IsEnabled = false;
                PicYes23.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo23.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic24_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 24))
            {
                picCountChackted++;
                Pic24.IsEnabled = false;
                PicYes24.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo24.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic25_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 25))
            {
                picCountChackted++;
                Pic25.IsEnabled = false;
                PicYes25.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo25.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic26_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 26))
            {
                picCountChackted++;
                Pic26.IsEnabled = false;
                PicYes26.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo26.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic27_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 27))
            {
                picCountChackted++;
                Pic27.IsEnabled = false;
                PicYes27.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo27.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic28_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 28))
            {
                picCountChackted++;
                Pic28.IsEnabled = false;
                PicYes28.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo28.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic29_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 29))
            {
                picCountChackted++;
                Pic29.IsEnabled = false;
                PicYes29.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo29.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic30_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 30))
            {
                picCountChackted++;
                Pic30.IsEnabled = false;
                PicYes30.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo30.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic31_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 31))
            {
                picCountChackted++;
                Pic31.IsEnabled = false;
                PicYes31.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo31.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic32_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 32))
            {
                picCountChackted++;
                Pic32.IsEnabled = false;
                PicYes32.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo32.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic33_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 33))
            {
                picCountChackted++;
                Pic33.IsEnabled = false;
                PicYes33.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo33.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic34_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 34))
            {
                picCountChackted++;
                Pic34.IsEnabled = false;
                PicYes34.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo34.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic35_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 35))
            {
                picCountChackted++;
                Pic35.IsEnabled = false;
                PicYes35.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo35.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic36_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 36))
            {
                picCountChackted++;
                Pic36.IsEnabled = false;
                PicYes36.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo36.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic37_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 37))
            {
                picCountChackted++;
                Pic37.IsEnabled = false;
                PicYes37.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo37.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic38_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 38))
            {
                picCountChackted++;
                Pic38.IsEnabled = false;
                PicYes38.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo38.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic39_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 39))
            {
                picCountChackted++;
                Pic39.IsEnabled = false;
                PicYes39.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo39.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic40_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 40))
            {
                picCountChackted++;
                Pic40.IsEnabled = false;
                PicYes40.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo40.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic41_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 41))
            {
                picCountChackted++;
                Pic41.IsEnabled = false;
                PicYes41.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo41.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic42_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 42))
            {
                picCountChackted++;
                Pic42.IsEnabled = false;
                PicYes42.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo42.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic43_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 43))
            {
                picCountChackted++;
                Pic43.IsEnabled = false;
                PicYes43.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo43.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic44_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 44))
            {
                picCountChackted++;
                Pic44.IsEnabled = false;
                PicYes44.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo44.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic45_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 45))
            {
                picCountChackted++;
                Pic45.IsEnabled = false;
                PicYes45.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo45.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic46_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 46))
            {
                picCountChackted++;
                Pic46.IsEnabled = false;
                PicYes46.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo46.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic47_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 47))
            {
                picCountChackted++;
                Pic47.IsEnabled = false;
                PicYes47.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo47.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void Pic48_Checked(object sender, RoutedEventArgs e)
        {
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), 48))
            {
                picCountChackted++;
                Pic48.IsEnabled = false;
                PicYes48.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo48.Visibility = Visibility.Visible;
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void IsEnabledAllCheckBox(bool bl)
        {
            Pic1.IsEnabled = bl;
            Pic2.IsEnabled = bl;
            Pic3.IsEnabled = bl;
            Pic4.IsEnabled = bl;
            Pic5.IsEnabled = bl;
            Pic6.IsEnabled = bl;
            Pic7.IsEnabled = bl;
            Pic8.IsEnabled = bl;
            Pic9.IsEnabled = bl;
            Pic10.IsEnabled = bl;
            Pic11.IsEnabled = bl;
            Pic12.IsEnabled = bl;
            Pic13.IsEnabled = bl;
            Pic14.IsEnabled = bl;
            Pic15.IsEnabled = bl;
            Pic16.IsEnabled = bl;
            Pic17.IsEnabled = bl;
            Pic18.IsEnabled = bl;
            Pic19.IsEnabled = bl;
            Pic20.IsEnabled = bl;
            Pic21.IsEnabled = bl;
            Pic22.IsEnabled = bl;
            Pic23.IsEnabled = bl;
            Pic24.IsEnabled = bl;
            Pic25.IsEnabled = bl;
            Pic26.IsEnabled = bl;
            Pic27.IsEnabled = bl;
            Pic28.IsEnabled = bl;
            Pic29.IsEnabled = bl;
            Pic30.IsEnabled = bl;
            Pic31.IsEnabled = bl;
            Pic32.IsEnabled = bl;
            Pic33.IsEnabled = bl;
            Pic34.IsEnabled = bl;
            Pic35.IsEnabled = bl;
            Pic36.IsEnabled = bl;
            Pic37.IsEnabled = bl;
            Pic38.IsEnabled = bl;
            Pic39.IsEnabled = bl;
            Pic40.IsEnabled = bl;
            Pic41.IsEnabled = bl;
            Pic42.IsEnabled = bl;
            Pic43.IsEnabled = bl;
            Pic44.IsEnabled = bl;
            Pic45.IsEnabled = bl;
            Pic46.IsEnabled = bl;
            Pic47.IsEnabled = bl;
            Pic48.IsEnabled = bl;
        }
    }
}
