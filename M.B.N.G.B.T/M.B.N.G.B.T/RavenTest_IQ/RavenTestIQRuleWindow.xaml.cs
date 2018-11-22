using System.Diagnostics;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using System;
using System.Windows.Media.Imaging;
using System.Threading.Tasks;

namespace M.B.N.G.B.T.RavenTest_IQ
{
    /// <summary>
    /// Логика взаимодействия для RavenTestIQRuleWindow.xaml
    /// </summary>
    public partial class RavenTestIQRuleWindow : Window
    {

        private double startAge;

        private static RavenTestIQTablePage ravenTestIQTablePage;
        private static string age = "16";

        public static string Age { get { return age; } }
        public static RavenTestIQTablePage RavenTestIQTablePage { get { return ravenTestIQTablePage; } }

        public RavenTestIQRuleWindow()
        {
            InitializeComponent();
            LabelAge.Content = age;
            startAge = Convert.ToDouble(age);
            Loaded += LoadImagesTablePageInList;
        }

        private void Button_Exit_The_Main(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
            Process.Start(Application.ResourceAssembly.Location);
        }

        async void LoadImagesTablePageInList(object sender, RoutedEventArgs e)
        {
            progress.Visibility = Visibility.Visible;
            await Task.Delay(1000);
            ravenTestIQTablePage = new RavenTestIQTablePage();
            await Task.Delay(2000);
            progress.Visibility = Visibility.Hidden;
            button_Start_Test.Visibility = Visibility.Visible;
        }

        private void Button_Start_Test(object sender, RoutedEventArgs e)
        {
            if (ravenTestIQTablePage == null)
                ravenTestIQTablePage = new RavenTestIQTablePage();
            else
                ((INewRavenIQTestTablePage)ravenTestIQTablePage).CreateNewPageTestRavenForNewUserAndSrartTimer();

            Main.NavigationService.Navigate(ravenTestIQTablePage);
        }

        private void Pic_Left_Right_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (((Image)sender).Name == "Pic_Left" && startAge != 8 && startAge <= 14)
                LabelAge.Content = (age = (startAge = startAge - 0.5d).ToString());
            else
            if (((Image)sender).Name == "Pic_Right" && startAge <= 13.5)
                LabelAge.Content = (age = (startAge = startAge + 0.5d).ToString());
            else
            if (((Image)sender).Name == "Pic_Left" && startAge != 8)
                LabelAge.Content = (age = (Convert.ToInt16(--startAge)).ToString());
            else
            if (((Image)sender).Name == "Pic_Right" && startAge != 99)
                LabelAge.Content = (age = (Convert.ToInt16(++startAge)).ToString());
            else
            if (((Image)sender).Name == "Pic_Left_Length" && (startAge - 10) >= 8)
                LabelAge.Content = (age = Convert.ToInt16(startAge -= 10).ToString());
            else
            if (((Image)sender).Name == "Pic_Right_Length" && (startAge + 10) <= 99)
                LabelAge.Content = (age = Convert.ToInt16(startAge += 10).ToString());
        }

        private void Pic_Left_Right_MouseEnter(object sender, MouseEventArgs e)
        {
            if (((Image)sender).Name == "Pic_Right")
                Pic_Right.Source = new BitmapImage(new Uri(@"pack://siteoforigin:,,,/Resources/Static/Buttons Right and Left/Right_Color.png"));
            else
            if (((Image)sender).Name == "Pic_Left")
                Pic_Left.Source = new BitmapImage(new Uri(@"pack://siteoforigin:,,,/Resources/Static/Buttons Right and Left/Left_Color.png"));
            else
            if (((Image)sender).Name == "Pic_Right_Length")
                Pic_Right_Length.Source = new BitmapImage(new Uri(@"pack://siteoforigin:,,,/Resources/Static/Buttons Right and Left/Right_Lenght_Color.png"));
            else
            if (((Image)sender).Name == "Pic_Left_Length")
                Pic_Left_Length.Source = new BitmapImage(new Uri(@"pack://siteoforigin:,,,/Resources/Static/Buttons Right and Left/Left_Length_Color.png"));
        }

        private void Pic_Left_Right_MouseLeave(object sender, MouseEventArgs e)
        {
            if (((Image)sender).Name == "Pic_Right")
                Pic_Right.Source = new BitmapImage(new Uri(@"pack://siteoforigin:,,,/Resources/Static/Buttons Right and Left/Right.png"));
            else
            if (((Image)sender).Name == "Pic_Left")
                Pic_Left.Source = new BitmapImage(new Uri(@"pack://siteoforigin:,,,/Resources/Static/Buttons Right and Left/Left.png"));
            else
            if (((Image)sender).Name == "Pic_Right_Length")
                Pic_Right_Length.Source = new BitmapImage(new Uri(@"pack://siteoforigin:,,,/Resources/Static/Buttons Right and Left/Right_Lenght.png"));
            else
            if (((Image)sender).Name == "Pic_Left_Length")
                Pic_Left_Length.Source = new BitmapImage(new Uri(@"pack://siteoforigin:,,,/Resources/Static/Buttons Right and Left/Left_Length.png"));
        }
    }
}
