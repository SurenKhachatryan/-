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

namespace M.B.N.G.B.T.AttentivenessTest
{
    /// <summary>
    /// Логика взаимодействия для AllPictures.xaml
    /// </summary>
    public partial class AllPictures : Page
    {
        private byte second = 16;
        private DispatcherTimer dispatcherTimer = new DispatcherTimer();

        public AllPictures()
        {
            InitializeComponent();
            dispatcherTimer.Tick += new EventHandler(LabelTimer);
            dispatcherTimer.Start();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

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
                if (RandomPicturesPage.stage < 5)
                {
                    RandomPicturesPage.stage += 1;
                    Main.Content = new RandomPicturesPage();

                }
                else
                {
                    Main.Content = new ResultPage();
                }

            }

        }
    }
}
