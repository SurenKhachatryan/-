using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace M.B.N.G.B.T.AttentivenessTest
{
    /// <summary>
    /// Логика взаимодействия для AllPictures.xaml
    /// </summary>
    public partial class AllPictures : Page
    {
        private List<int> listCorrectSelectedPictures = new List<int>();

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
            if (second == 5 && door || picCountChackted == 20)
            {
                if (picCountChackted == 20)
                    RandomPicturesPage.stage += 1;

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
                listCorrectSelectedPictures.Add(1);
                PicYes1.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo1.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(2);
                PicYes2.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo2.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(3);
                PicYes3.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo3.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(4);
                PicYes4.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo4.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(5);
                PicYes5.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo5.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(6);
                PicYes6.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo6.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(7);
                PicYes7.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo7.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(8);
                PicYes8.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo8.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(9);
                PicYes9.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo9.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(10);
                PicYes10.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo10.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(11);
                PicYes11.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo11.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(12);
                PicYes12.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo12.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(13);
                PicYes13.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo13.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(14);
                PicYes14.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo14.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(15);
                PicYes15.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo15.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(16);
                PicYes16.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo16.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(17);
                PicYes17.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo17.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(18);
                PicYes18.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo18.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(19);
                PicYes19.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo19.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(20);
                PicYes20.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo20.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(21);
                PicYes21.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo21.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(22);
                PicYes22.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo22.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(23);
                PicYes23.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo23.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(24);
                PicYes24.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo24.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(25);
                PicYes25.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo25.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(26);
                PicYes26.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo26.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(27);
                PicYes27.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo27.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(28);
                PicYes28.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo28.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(29);
                PicYes29.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo29.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(30);
                PicYes30.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo30.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(31);
                PicYes31.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo31.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(32);
                PicYes32.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo32.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(33);
                PicYes33.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo33.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(34);
                PicYes34.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo34.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(35);
                PicYes35.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo35.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(36);
                PicYes36.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo36.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(37);
                PicYes37.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo37.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(38);
                PicYes38.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo38.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(39);
                PicYes39.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo39.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(40);
                PicYes40.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo40.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(41);
                PicYes41.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo41.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(42);
                PicYes42.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo42.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(43);
                PicYes43.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo43.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(44);
                PicYes44.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo44.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(45);
                PicYes45.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo45.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(46);
                PicYes46.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo46.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(47);
                PicYes47.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo47.Visibility = Visibility.Visible;
                VisiblуNotSelected();
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
                listCorrectSelectedPictures.Add(48);
                PicYes48.Visibility = Visibility.Visible;
            }
            else
            {
                PicNo48.Visibility = Visibility.Visible;
                VisiblуNotSelected();
                IsEnabledAllCheckBox(false);
                door = true;
            }
        }

        private void VisiblуNotSelected()
        {
            int[] arr;

            if (listCorrectSelectedPictures.Count != 0)
                arr = cl.GetArrayMissingNumbersInAnArray(RandomPicturesPage.listPicVisibility.ToArray(), listCorrectSelectedPictures.ToArray());
            else
                arr = RandomPicturesPage.listPicVisibility.ToArray();

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
