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

        private List<int> listChecked = new List<int>();
        private byte second = 16;

        public AllPictures()
        {
            InitializeComponent();

            dispatcherTimer.Tick += new EventHandler(LabelTimer);
            listChecked.Clear();
            dispatcherTimer.Start();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
            this.NavigationService.Navigate(new ResultPage());
        }

        public void AllPicturesCollapsed()
        {
            AllPictures1.Visibility = Visibility.Collapsed;
        }

        private void LabelTimer(object sender, EventArgs e)
        {
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);

            if (second != 0)
            {
                second--;
                timer.Content = second;
                if (second == 8)
                {
                    timer.Foreground = Brushes.Yellow;
                }
                else
                if (second == 5)
                {
                    timer.Foreground = Brushes.Red;
                }
            }
            else
            {
                dispatcherTimer.Stop();
                if (RandomPicturesPage.startstage < 15 && cl.ArrItemsEquals(RandomPicturesPage.listPicVisibility.ToArray(), listChecked.ToArray()))
                {
                    RandomPicturesPage.startstage += 1;
                    this.NavigationService.Navigate(new RandomPicturesPage());

                }
                else
                {
                    this.NavigationService.Navigate(new ResultPage());
                }
            }
        }

        private void Pic1_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(1);
        }

        private void Pic2_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(2);
        }

        private void Pic3_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(3);
        }

        private void Pic4_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(4);
        }

        private void Pic5_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(5);
        }

        private void Pic6_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(6);
        }

        private void Pic7_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(7);
        }

        private void Pic8_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(8);
        }

        private void Pic9_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(9);
        }

        private void Pic10_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(10);
        }

        private void Pic11_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(11);
        }

        private void Pic12_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(12);
        }

        private void Pic13_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(13);
        }

        private void Pic14_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(14);
        }

        private void Pic15_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(15);
        }

        private void Pic16_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(16);
        }

        private void Pic17_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(17);
        }

        private void Pic18_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(18);
        }

        private void Pic19_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(19);
        }

        private void Pic20_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(20);
        }

        private void Pic21_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(21);
        }

        private void Pic22_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(22);
        }

        private void Pic23_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(23);
        }

        private void Pic24_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(24);
        }

        private void Pic25_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(25);
        }

        private void Pic26_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(26);
        }

        private void Pic27_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(27);
        }

        private void Pic28_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(28);
        }

        private void Pic29_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(29);
        }

        private void Pic30_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(30);
        }

        private void Pic31_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(31);
        }

        private void Pic32_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(32);
        }

        private void Pic33_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(33);
        }

        private void Pic34_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(34);
        }

        private void Pic35_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(35);
        }

        private void Pic36_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(36);
        }

        private void Pic37_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(37);
        }

        private void Pic38_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(38);
        }

        private void Pic39_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(39);
        }

        private void Pic40_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(40);
        }

        private void Pic41_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(41);
        }

        private void Pic42_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(42);
        }

        private void Pic43_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(43);
        }

        private void Pic44_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(44);
        }

        private void Pic45_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(45);
        }

        private void Pic46_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(46);
        }

        private void Pic47_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(47);
        }

        private void Pic48_Checked(object sender, RoutedEventArgs e)
        {
            listChecked.Add(48);
        }
    }
}
