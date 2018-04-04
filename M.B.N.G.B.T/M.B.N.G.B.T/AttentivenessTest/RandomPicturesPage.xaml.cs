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
using ClassLibrary;

namespace M.B.N.G.B.T.AttentivenessTest
{
    /// <summary>
    /// Логика взаимодействия для RandomPicturesPage.xaml
    /// </summary>
    public partial class RandomPicturesPage : Page
    {
        private ClassLibraryMBNGBT cl = new ClassLibraryMBNGBT();
        private Random rnd = new Random();

        private byte stage = 1;

        public RandomPicturesPage()
        {
            InitializeComponent();
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

            Canvas.SetTop(Pic36, 100);
            Canvas.SetLeft(Pic37, 210);
            Canvas.SetLeft(Pic38, 320);
            Canvas.SetLeft(Pic39, 430);
            Canvas.SetLeft(Pic40, 540);
            Canvas.SetLeft(Pic41, 650);
            Canvas.SetLeft(Pic42, 760);
            Canvas.SetLeft(Pic43, 870);
            Canvas.SetLeft(Pic44, 980);
            Canvas.SetLeft(Pic45, 1090);
            Canvas.SetLeft(Pic46, 1200);
            Canvas.SetLeft(Pic47, 1310);
            Canvas.SetLeft(Pic38, 1420);
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            int number = 0;

            for (int i = 0; i < stage; i++)
            {
                 number = rnd.Next(1, 48);
            }

            switch (number)
            {
                case 1:
                    Pic1.Visibility = Visibility.Visible;
                    break;
                case 2:
                    Pic2.Visibility = Visibility.Visible;
                    break;
                case 3:
                    Pic3.Visibility = Visibility.Visible;
                    break;
                case 4:
                    Pic4.Visibility = Visibility.Visible;
                    break;
                case 5:
                    Pic5.Visibility = Visibility.Visible;
                    break;
                case 6:
                    Pic6.Visibility = Visibility.Visible;
                    break;
                case 7:
                    Pic7.Visibility = Visibility.Visible;
                    break;
                case 8:
                    Pic8.Visibility = Visibility.Visible;
                    break;
                case 9:
                    Pic9.Visibility = Visibility.Visible;
                    break;
                case 10:
                    Pic10.Visibility = Visibility.Visible;
                    break;
                case 11:
                    Pic11.Visibility = Visibility.Visible;
                    break;
                case 12:
                    Pic12.Visibility = Visibility.Visible;
                    break;
                case 13:
                    Pic13.Visibility = Visibility.Visible;
                    break;
                case 14:
                    Pic14.Visibility = Visibility.Visible;
                    break;
                case 15:
                    Pic15.Visibility = Visibility.Visible;
                    break;
                case 16:
                    Pic16.Visibility = Visibility.Visible;
                    break;
                case 17:
                    Pic17.Visibility = Visibility.Visible;
                    break;
                case 18:
                    Pic18.Visibility = Visibility.Visible;
                    break;
                case 19:
                    Pic19.Visibility = Visibility.Visible;
                    break;
                case 20:
                    Pic20.Visibility = Visibility.Visible;
                    break;
                case 21:
                    Pic21.Visibility = Visibility.Visible;
                    break;
                case 22:
                    Pic22.Visibility = Visibility.Visible;
                    break;
                case 23:
                    Pic23.Visibility = Visibility.Visible;
                    break;
                case 24:
                    Pic24.Visibility = Visibility.Visible;
                    break;
                case 25:
                    Pic25.Visibility = Visibility.Visible;
                    break;
                case 26:
                    Pic26.Visibility = Visibility.Visible;
                    break;
                case 27:
                    Pic27.Visibility = Visibility.Visible;
                    break;
                case 28:
                    Pic28.Visibility = Visibility.Visible;
                    break;
                case 29:
                    Pic29.Visibility = Visibility.Visible;
                    break;
                case 30:
                    Pic30.Visibility = Visibility.Visible;
                    break;
                case 31:
                    Pic31.Visibility = Visibility.Visible;
                    break;
                case 32:
                    Pic32.Visibility = Visibility.Visible;
                    break;
                case 33:
                    Pic33.Visibility = Visibility.Visible;
                    break;
                case 34:
                    Pic34.Visibility = Visibility.Visible;
                    break;
                case 35:
                    Pic35.Visibility = Visibility.Visible;
                    break;
                case 36:
                    Pic36.Visibility = Visibility.Visible;
                    break;
                case 37:
                    Pic37.Visibility = Visibility.Visible;
                    break;
                case 38:
                    Pic38.Visibility = Visibility.Visible;
                    break;
                case 39:
                    Pic39.Visibility = Visibility.Visible;
                    break;
                case 40:
                    Pic40.Visibility = Visibility.Visible;
                    break;
                case 41:
                    Pic41.Visibility = Visibility.Visible;
                    break;
                case 42:
                    Pic42.Visibility = Visibility.Visible;
                    break;
                case 43:
                    Pic43.Visibility = Visibility.Visible;
                    break;
                case 44:
                    Pic44.Visibility = Visibility.Visible;
                    break;
                case 45:
                    Pic45.Visibility = Visibility.Visible;
                    break;
                case 46:
                    Pic46.Visibility = Visibility.Visible;
                    break;
                case 47:
                    Pic47.Visibility = Visibility.Visible;
                    break;
                case 48:
                    Pic48.Visibility = Visibility.Visible;
                    break;
            }
        }
    }
}
