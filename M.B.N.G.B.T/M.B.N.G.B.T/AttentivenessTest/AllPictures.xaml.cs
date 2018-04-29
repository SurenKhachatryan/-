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

        private int tamp = 0;
        private int picCountChackted = 0;
        private int second = 0;


        public AllPictures()
        {
            InitializeComponent();
            dispatcherTimer.Tick += new EventHandler(LabelTimer);
        }

        private void LabelTimer(object sender, EventArgs e)
        {
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            second++;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
            }

            if (second == 1 && picCountChackted == RandomPicturesPage.picturesCount)
            {
                RandomPicturesPage.picturesCount += 2;
                NavigationService.Navigate(new RandomPicturesPage());
            }
        }

        private void Button_Exit_The_Test_And_View_Result(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ResultPage());
        }

        private void Pic1_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 1;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes1.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo1.Visibility = Visibility.Visible;
            }
            
        }

        private void Pic2_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 2;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes2.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo2.Visibility = Visibility.Visible;
            }
        }

        private void Pic3_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 3;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes3.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo3.Visibility = Visibility.Visible;
            }
        }

        private void Pic4_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 4;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes4.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo4.Visibility = Visibility.Visible;
            }
        }

        private void Pic5_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 5;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes5.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo5.Visibility = Visibility.Visible;
            }
        }

        private void Pic6_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 6;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes6.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo6.Visibility = Visibility.Visible;
            }
        }

        private void Pic7_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 7;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes7.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo7.Visibility = Visibility.Visible;
            }
        }

        private void Pic8_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 8;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes8.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo8.Visibility = Visibility.Visible;
            }
        }

        private void Pic9_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 9;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes9.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo9.Visibility = Visibility.Visible;
            }
        }

        private void Pic10_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 10;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes10.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo10.Visibility = Visibility.Visible;
            }
        }

        private void Pic11_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 11;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes11.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo11.Visibility = Visibility.Visible;
            }
        }

        private void Pic12_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 12;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes12.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo12.Visibility = Visibility.Visible;
            }
        }

        private void Pic13_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 13;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes13.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo13.Visibility = Visibility.Visible;
            }
        }

        private void Pic14_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 14;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes14.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo14.Visibility = Visibility.Visible;
            }
        }

        private void Pic15_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 15;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes15.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo15.Visibility = Visibility.Visible;
            }
        }

        private void Pic16_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 16;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes16.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo16.Visibility = Visibility.Visible;
            }
        }

        private void Pic17_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 17;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes17.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo17.Visibility = Visibility.Visible;
            }
        }

        private void Pic18_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 18;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes18.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo18.Visibility = Visibility.Visible;
            }
        }

        private void Pic19_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 19;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes19.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo19.Visibility = Visibility.Visible;
            }
        }

        private void Pic20_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 20;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes20.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo20.Visibility = Visibility.Visible;
            }
        }

        private void Pic21_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 21;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes21.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo21.Visibility = Visibility.Visible;
            }
        }

        private void Pic22_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 22;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes22.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo22.Visibility = Visibility.Visible;
            }
        }

        private void Pic23_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 23;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes23.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo23.Visibility = Visibility.Visible;
            }
        }

        private void Pic24_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 24;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes24.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo24.Visibility = Visibility.Visible;
            }
        }

        private void Pic25_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 25;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes25.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo25.Visibility = Visibility.Visible;
            }
        }

        private void Pic26_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 26;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes26.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo26.Visibility = Visibility.Visible;
            }
        }

        private void Pic27_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 27;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes27.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo27.Visibility = Visibility.Visible;
            }
        }

        private void Pic28_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 28;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes28.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo28.Visibility = Visibility.Visible;
            }
        }

        private void Pic29_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 29;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes29.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo29.Visibility = Visibility.Visible;
            }
        }

        private void Pic30_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 30;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes30.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo30.Visibility = Visibility.Visible;
            }
        }

        private void Pic31_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 31;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes31.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo31.Visibility = Visibility.Visible;
            }
        }

        private void Pic32_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 32;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes32.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo32.Visibility = Visibility.Visible;
            }
        }

        private void Pic33_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 33;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes33.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo33.Visibility = Visibility.Visible;
            }
        }

        private void Pic34_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 34;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes34.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo34.Visibility = Visibility.Visible;
            }
        }

        private void Pic35_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 35;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes35.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo35.Visibility = Visibility.Visible;
            }
        }

        private void Pic36_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 36;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes36.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo36.Visibility = Visibility.Visible;
            }
        }

        private void Pic37_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 37;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes37.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo37.Visibility = Visibility.Visible;
            }
        }

        private void Pic38_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 38;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes38.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo38.Visibility = Visibility.Visible;
            }
        }

        private void Pic39_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 39;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes39.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo39.Visibility = Visibility.Visible;
            }
        }

        private void Pic40_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 40;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes40.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo40.Visibility = Visibility.Visible;
            }
        }

        private void Pic41_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 41;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes41.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo41.Visibility = Visibility.Visible;
            }
        }

        private void Pic42_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 42;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes42.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo42.Visibility = Visibility.Visible;
            }
        }

        private void Pic43_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 43;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes43.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo43.Visibility = Visibility.Visible;
            }
        }

        private void Pic44_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 44;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes44.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo44.Visibility = Visibility.Visible;
            }
        }

        private void Pic45_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 45;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes45.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo45.Visibility = Visibility.Visible;
            }
        }

        private void Pic46_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 46;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes46.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo46.Visibility = Visibility.Visible;
            }
        }

        private void Pic47_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 47;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes47.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo47.Visibility = Visibility.Visible;
            }
        }

        private void Pic48_Checked(object sender, RoutedEventArgs e)
        {
            tamp = 48;
            second = 0;
            if (cl.SerchMatchingNumberInArr(RandomPicturesPage.listPicVisibility.ToArray(), tamp))
            {
                picCountChackted++;
                tamp = 0;
                PicYes48.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo48.Visibility = Visibility.Visible;
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
