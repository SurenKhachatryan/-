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
        private Image[] arrAllPicsSubject = new Image[48];
        private Image[] arrAllPicsYes1 = new Image[48];
        private Image[] arrAllPicsYes2 = new Image[48];
        private Image[] arrAllPicsNo = new Image[48];

        private ClassLibraryMBNGBT cl = new ClassLibraryMBNGBT();
        private DispatcherTimer dispatcherTimer = new DispatcherTimer();

        private int picCountChackted { get; set; } = 0;
        private int second { get; set; } = 0;
        private bool door { get; set; } = false;
        private bool isEnabledPics { get; set; } = true;

        public VisualMemoryTestAllPicturesPage()
        {
            InitializeComponent();
            arrAllPicsSubject = new Image[] {Pic1,Pic2,Pic3,Pic4,Pic5,Pic6,Pic7,Pic8,Pic9,Pic10,Pic11,Pic12,Pic13,Pic14,Pic15,Pic16,Pic17,
                                             Pic18,Pic19,Pic20,Pic21,Pic22,Pic23,Pic24,Pic25,Pic26,Pic27,Pic28,Pic29,Pic30,Pic31,Pic32,
                                             Pic33,Pic34,Pic35,Pic36,Pic37,Pic38,Pic39,Pic40,Pic41,Pic42,Pic43,Pic44,Pic45,Pic46,Pic47,Pic48};

            arrAllPicsYes1 = new Image[] { PicYes1, PicYes2, PicYes3, PicYes4, PicYes5, PicYes6, PicYes7, PicYes8, PicYes9, PicYes10, PicYes11,
                                           PicYes12,PicYes13,PicYes14,PicYes15,PicYes16,PicYes17,PicYes18,PicYes19,PicYes20,PicYes21,PicYes22,
                                           PicYes23,PicYes24,PicYes25,PicYes26,PicYes27,PicYes28,PicYes29,PicYes30,PicYes31,PicYes32,PicYes33,
                                           PicYes34,PicYes35,PicYes36,PicYes37,PicYes38,PicYes39,PicYes40,PicYes41,PicYes42,PicYes43,PicYes44,
                                           PicYes45,PicYes46,PicYes47,PicYes48};

            arrAllPicsYes2 = new Image[] { PicYes2_1, PicYes2_2, PicYes2_3, PicYes2_4, PicYes2_5, PicYes2_6, PicYes2_7, PicYes2_8, PicYes2_9, PicYes2_10, PicYes2_11,
                                           PicYes2_12,PicYes2_13,PicYes2_14,PicYes2_15,PicYes2_16,PicYes2_17,PicYes2_18,PicYes2_19,PicYes2_20,PicYes2_21,PicYes2_22,
                                           PicYes2_23,PicYes2_24,PicYes2_25,PicYes2_26,PicYes2_27,PicYes2_28,PicYes2_29,PicYes2_30,PicYes2_31,PicYes2_32,PicYes2_33,
                                           PicYes2_34,PicYes2_35,PicYes2_36,PicYes2_37,PicYes2_38,PicYes2_39,PicYes2_40,PicYes2_41,PicYes2_42,PicYes2_43,PicYes2_44,
                                           PicYes2_45,PicYes2_46,PicYes2_47,PicYes2_48};

            arrAllPicsNo = new Image[] { PicNo1, PicNo2, PicNo3, PicNo4, PicNo5, PicNo6, PicNo7, PicNo8, PicNo9, PicNo10, PicNo11, PicNo12, PicNo13, PicNo14, PicNo15,
                                         PicNo16,PicNo17,PicNo18,PicNo19,PicNo20,PicNo21,PicNo22,PicNo23,PicNo24,PicNo25,PicNo26,PicNo27,PicNo28,PicNo29,PicNo30,PicNo31,
                                         PicNo32,PicNo33,PicNo34,PicNo35,PicNo36,PicNo37,PicNo38,PicNo39,PicNo40,PicNo41,PicNo42,PicNo43,PicNo44,PicNo45,PicNo46,PicNo47,PicNo48};

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
                isEnabledPics = false;
        }

        private void Pics_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (isEnabledPics)
            {
                int index = 0;
                for (int i = 0; i < arrAllPicsSubject.Length; i++)
                {
                    if (((Image)sender).Name == arrAllPicsSubject[i].Name)
                    {
                        index = i;
                        i = arrAllPicsSubject.Length;
                    }
                }
                second = 0;
                if (cl.SerchMatchingNumberInArr(VisualMemoryTestRandomPicturesPage.listPicVisibility.ToArray(), (index + 1)))
                {
                    picCountChackted++;
                    listCorrectSelectedPictures.Add((index + 1));
                    arrAllPicsYes1[index].Visibility = Visibility.Visible;
                    IsenabledPics();
                }
                else
                {
                    arrAllPicsNo[index].Visibility = Visibility.Visible;
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
                arrAllPicsYes2[arr[i] - 1].Visibility = Visibility.Visible;
        }
    }
}

