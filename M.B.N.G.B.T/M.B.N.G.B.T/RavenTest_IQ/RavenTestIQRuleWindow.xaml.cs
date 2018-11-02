using System.Diagnostics;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using System;
using System.Windows.Media.Imaging;

namespace M.B.N.G.B.T.RavenTest_IQ
{
    /// <summary>
    /// Логика взаимодействия для RavenTestIQRuleWindow.xaml
    /// </summary>
    public partial class RavenTestIQRuleWindow : Window
    {
        private static object ravenTestIQTablePage;
        private static string age;

        public static string Age { get { return age; } }
        public static object RavenTestIQTablePage { get { return ravenTestIQTablePage; } }
        public RavenTestIQRuleWindow()
        {
            InitializeComponent();
        }

        private void Button_Exit_The_Main(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
            Process.Start(Application.ResourceAssembly.Location);
        }

        private void Button_Start_Test(object sender, RoutedEventArgs e)
        {
            if (ravenTestIQTablePage == null)
                ravenTestIQTablePage = new RavenTestIQTablePage();
            else
                ((INewRavenIQTestTablePage)ravenTestIQTablePage).CreateNewPageTestRavenForNewUser();

            Main.NavigationService.Navigate(ravenTestIQTablePage);
        }

        private void Pic_Left_Right_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            age = LabelAge.Content.ToString();
            

            LabelAge.Content = age;
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
