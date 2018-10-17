using ClassLibrary;
using System;
//using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using System.Windows.Threading;

namespace M.B.N.G.B.T.RavenTest_IQ
{
    /// <summary>
    /// Логика взаимодействия для RavenTestIQTablePage.xaml
    /// </summary>
    public partial class RavenTestIQTablePage : Page
    {
        private ClassLibraryMBNGBT cl = new ClassLibraryMBNGBT();
        private DispatcherTimer dispatcherTimer = new DispatcherTimer();
        //private Thread trd;

        private Image[] arrPicAllTests = new Image[60];
        private Image[][] arrPicsAllTests = new Image[60][];
        private WrapPanel[] arrWarpPanelsPicsAllTests = new WrapPanel[60];
        private Image[][] arrPics_PicChecked_6_And_8 = new Image[2][];
        private static byte[] arrAllSelectedPicsByUser = new byte[60];
        private static byte[] arrWrongSelectedUserAnswersByLevel = new byte[60];
        private static byte[] arrOfIncorrectlySelectedUserPics = new byte[60];
        public static readonly byte[] arrOfCorrectAnswersPics = new byte[] { 4, 5, 1, 2, 6, 3, 6, 2, 1, 3, 4, 2,
                                                                             5, 6, 1, 2, 1, 3, 5, 6, 4, 3, 4, 8,
                                                                             5, 3, 2, 7, 8, 4, 5, 7, 1, 1, 6, 2,
                                                                             3, 4, 3, 8, 7, 6, 5, 4, 1, 2, 5, 6,
                                                                             7, 6, 8, 2, 1, 5, 1, 3, 6, 2, 4, 5 };
        private static string finishTime = "00:00";
        private static bool isUserErrors = false;
        private static byte countOfTestsNotPassed = 0;
        private byte startPage = 0;
        private byte numberOfTestsPassed = 0;
        private short minute = 20;
        private short second = 0;

        public static bool IsUserErrors { get { return isUserErrors; } }
        public static byte[] ArrAllSelectedPicsByUser { get { return arrAllSelectedPicsByUser; } }
        public static byte[] ArrWrongSelectedUserAnswersByLevel { get { return arrWrongSelectedUserAnswersByLevel; } }
        public static byte[] ArrOfIncorrectlySelectedUserPics { get { return arrOfIncorrectlySelectedUserPics; } }
        public static string FinishTime { get { return finishTime; } }
        public static byte CountOfTestsNotPassed { get { return countOfTestsNotPassed; } }

        public RavenTestIQTablePage()
        {
            InitializeComponent();

            arrAllSelectedPicsByUser = new byte[60];
            arrWrongSelectedUserAnswersByLevel = new byte[60];
            finishTime = "00:00";
            isUserErrors = false;
            countOfTestsNotPassed = 0;

            //trd = new Thread(InitializerAllArrayAllPics);
            //trd.Start();
            InitializerAllArrayAllPics();
            CollapsedAllPicsAndVisiblityFirstTestPics();

            dispatcherTimer.Tick += new EventHandler(LabelTimer);
            dispatcherTimer.Start();
        }

        /// <summary>
        /// Этот метод из себя представляет событие Button который отвечет для выхода с класса
        /// RavenTestIQTablePage если пользователь не захател прадолжить тест.
        /// </summary>
        private void Button_Exit_The_Test(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
            NavigationService.Navigate(new RavenTestIQRulePage());
        }

        /// <summary>
        /// Этот метод из себя представляет событие Button (видеть результаты), кнопка
        /// появляется в конце когда пользовател прашел все уровни․
        /// </summary>
        private void Button_View_Result(object sender, RoutedEventArgs e)
        {
            FinishTest();
        }

        /// <summary>
        /// этот метод собирает информацию прохожденым пользователям все уровни и завершает все работы с классом "RavenTestIQTablePage"
        /// и NavigationService.Navigate()-у дает новую ссылку "RavenTestIQResultPage"․
        /// </summary>
        private void FinishTest()
        {
            dispatcherTimer.Stop();
            if (minute != 0 || second != 0)
            {
                short newMinut = (short)(19 - minute);
                short newSecond = (short)(59 - second);

                if (newMinut >= 10 && newSecond >= 10)
                    finishTime = $"{newMinut}:{newSecond}";
                else
                if (newMinut <= 9 && newSecond <= 9)
                    finishTime = $"0{newMinut}:0{newSecond}";
                else
                if (newMinut >= 10 && newSecond <= 9)
                    finishTime = $"{newMinut}:0{newSecond}";
                else
                if (newMinut <= 9 && newSecond >= 10)
                    finishTime = $"0{newMinut}:{newSecond}";
            }

            if (finishTime == "00:00")
                countOfTestsNotPassed = (byte)cl.GetCountthisNumberInArr(arrAllSelectedPicsByUser, 0);

            isUserErrors = cl.ArrItemsEqualswiThoutSorting(arrOfCorrectAnswersPics, arrAllSelectedPicsByUser);

            if (!isUserErrors)
                arrOfIncorrectlySelectedUserPics = cl.GetArraysNon_validIndexsAndNumbers(arrOfCorrectAnswersPics, arrAllSelectedPicsByUser, out arrWrongSelectedUserAnswersByLevel);
            else
            {
                arrOfIncorrectlySelectedUserPics = null;
                arrWrongSelectedUserAnswersByLevel = null;
            }
            NavigationService.Navigate(new RavenTestIQResultPage());
        }

        /// <summary>
        /// Этот метод из себя представляет событие каторый показывает время , пользователь должен успевать прайти вес 
        /// тест в пределах этого времени.
        /// </summary>
        private void LabelTimer(object sender, EventArgs e)
        {
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);

            if (second == -1)
            {
                second = 59;
                minute--;
            }

            if (minute >= 10)
            {
                if (second <= 9)
                    labelTimer.Content = $"{minute}:0{second}";
                else
                    labelTimer.Content = $"{minute}:{second}";
            }
            else
            {
                if (second <= 9)
                    labelTimer.Content = $"0{minute}:0{second}";
                else
                    labelTimer.Content = $"0{minute}:{second}";
            }

            if (minute <= 0 && second <= 0)
                FinishTest();
            else
                second--;
        }

        /// <summary>
        /// Этот метод из себя представляет событие принимает выбранный пользователем картинку,
        /// добавляет в массив выбранную картинку и пероматывает на следуйщий уровень.
        /// </summary>
        private void Pics_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
           
            arrAllSelectedPicsByUser[startPage] = byte.Parse(((Image)sender).Name.ToString()[((Image)sender).Name.Length - 1].ToString());

            if ((startPage + 1) != 60)
                startPage++;
            if (startPage > numberOfTestsPassed)
                numberOfTestsPassed++;

            CollapsedAllPicsAndVisiblityFirstTestPics();
            VisiblityOrCollapsedButtonsBackSpaseAndNext("buttonNext");

            if (arrAllSelectedPicsByUser[59] != 0)
                button_View_Result.Visibility = Visibility.Visible;

            HiddenAllPicsChecked_And_VisiblityThisCheched_PicChecked();
        }

        /// <summary>
        /// Этот метод из себя представляет событие кнопок которые перематывают вперед-назад между уровнями․
        /// </summary>
        private void Button_Backspace_And_Next(object sender, RoutedEventArgs e)
        {
            if (((Button)sender).Name == "buttonBackSpace")
            {
                startPage--;
                VisiblityOrCollapsedButtonsBackSpaseAndNext("buttonBackSpace");
            }
            else
            if (((Button)sender).Name == "buttonNext")
            {
                startPage++;
                VisiblityOrCollapsedButtonsBackSpaseAndNext("buttonNext");
            }
            HiddenAllPicsChecked_And_VisiblityThisCheched_PicChecked();
            CollapsedAllPicsAndVisiblityFirstTestPics();
        }

        /// <summary>
        /// Этот метод показывает или скрывает кнопки для перематывание уровни . 
        /// Кнопка перемотка назад ,будет видна кроме первого уровня․
        /// Кнопка перемотка вперед будет видно кроме последнего уровня.
        /// </summary>
        private void VisiblityOrCollapsedButtonsBackSpaseAndNext(string buttonName)
        {
            if (buttonName == "buttonNext")
            {
                if (startPage == numberOfTestsPassed)
                    buttonNext.Visibility = Visibility.Collapsed;
                if (startPage == 1)
                    buttonBackSpace.Visibility = Visibility.Visible;
            }
            else
            if (buttonName == "buttonBackSpace")
            {
                if (startPage == (numberOfTestsPassed - 1))
                    buttonNext.Visibility = Visibility.Visible;
                if (startPage == 0)
                    buttonBackSpace.Visibility = Visibility.Collapsed;
            }
        }

        /// <summary>
        /// Этот метод скрывает все картинки и показывает те картинки ,на 
        /// котором уровне, находится пользователь.
        /// </summary>
        private void CollapsedAllPicsAndVisiblityFirstTestPics()
        {
            for (int i = 0; i < arrPicAllTests.Length; i++)
            {
                arrPicAllTests[i].Visibility = Visibility.Collapsed;
                arrWarpPanelsPicsAllTests[i].Visibility = Visibility.Collapsed;
            }
            LabelTest.Content = $"{(startPage + 1)}/60";
            arrPicAllTests[startPage].Visibility = Visibility.Visible;
            arrWarpPanelsPicsAllTests[startPage].Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Этот метод показывает ту картинку (PicChecked) которую выбрал пользователь
        /// </summary>
        private void HiddenAllPicsChecked_And_VisiblityThisCheched_PicChecked()
        {
            HiddenAllPicsChecked();
            if (arrAllSelectedPicsByUser[startPage] != 0)
            {
                if (startPage < 23 || startPage == 24)
                    arrPics_PicChecked_6_And_8[0][(arrAllSelectedPicsByUser[startPage] - 1)].Visibility = Visibility.Visible;
                else
                    arrPics_PicChecked_6_And_8[1][(arrAllSelectedPicsByUser[startPage] - 1)].Visibility = Visibility.Visible;
            }
        }

        /// <summary>
        /// Этот метод скрывает все картинки (PicChecked)
        /// </summary>
        private void HiddenAllPicsChecked()
        {
            for (int i = 0; i < arrPics_PicChecked_6_And_8.Length; i++)
                for (int j = 0; j < arrPics_PicChecked_6_And_8[i].Length; j++)
                    arrPics_PicChecked_6_And_8[i][j].Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Этот метод заполняет все картинки в массивы
        /// </summary>
        private void InitializerAllArrayAllPics()
        {
            //Thread.Sleep(1000);
            arrPics_PicChecked_6_And_8[0] = new Image[] { PicChecked_6_1, PicChecked_6_2, PicChecked_6_3, PicChecked_6_4, PicChecked_6_5, PicChecked_6_6 };
            arrPics_PicChecked_6_And_8[1] = new Image[] { PicChecked_8_1, PicChecked_8_2, PicChecked_8_3, PicChecked_8_4, PicChecked_8_5, PicChecked_8_6, PicChecked_8_7, PicChecked_8_8 };

            arrWarpPanelsPicsAllTests = new WrapPanel[] { TestImages_1, TestImages_2, TestImages_3, TestImages_4, TestImages_5, TestImages_6,
                                                          TestImages_7, TestImages_8, TestImages_9, TestImages_10, TestImages_11, TestImages_12,
                                                          TestImages_13, TestImages_14, TestImages_15, TestImages_16, TestImages_17, TestImages_18,
                                                          TestImages_19, TestImages_20, TestImages_21, TestImages_22, TestImages_23, TestImages_24,
                                                          TestImages_25, TestImages_26, TestImages_27, TestImages_28, TestImages_29, TestImages_30,
                                                          TestImages_31, TestImages_32, TestImages_33, TestImages_34, TestImages_35, TestImages_36,
                                                          TestImages_37, TestImages_38, TestImages_39, TestImages_40, TestImages_41, TestImages_42,
                                                          TestImages_43, TestImages_44, TestImages_45, TestImages_46, TestImages_47, TestImages_48,
                                                          TestImages_49, TestImages_50, TestImages_51, TestImages_52, TestImages_53, TestImages_54,
                                                          TestImages_55, TestImages_56, TestImages_57, TestImages_58, TestImages_59, TestImages_60 };


            arrPicAllTests = new Image[] { Pic_1, Pic_2, Pic_3, Pic_4, Pic_5, Pic_6, Pic_7, Pic_8, Pic_9, Pic_10, Pic_11, Pic_12, Pic_13, Pic_14,
                                           Pic_15, Pic_16, Pic_17, Pic_18, Pic_19, Pic_20, Pic_21, Pic_22, Pic_23, Pic_24, Pic_25, Pic_26, Pic_27,
                                           Pic_28, Pic_29, Pic_30, Pic_31, Pic_32, Pic_33, Pic_34, Pic_35, Pic_36, Pic_37, Pic_38, Pic_39, Pic_40,
                                           Pic_41, Pic_42, Pic_43, Pic_44, Pic_45, Pic_46, Pic_47, Pic_48, Pic_49, Pic_50, Pic_51, Pic_52, Pic_53,
                                           Pic_54, Pic_55, Pic_56, Pic_57, Pic_58, Pic_59, Pic_60 };


            arrPicsAllTests[0] = new Image[] { PicTest_1_1, PicTest_1_2, PicTest_1_3, PicTest_1_4, PicTest_1_5, PicTest_1_6 };
            arrPicsAllTests[1] = new Image[] { PicTest_2_1, PicTest_2_2, PicTest_2_3, PicTest_2_4, PicTest_2_5, PicTest_2_6 };
            arrPicsAllTests[2] = new Image[] { PicTest_3_1, PicTest_3_2, PicTest_3_3, PicTest_3_4, PicTest_3_5, PicTest_3_6 };
            arrPicsAllTests[3] = new Image[] { PicTest_4_1, PicTest_4_2, PicTest_4_3, PicTest_4_4, PicTest_4_5, PicTest_4_6 };
            arrPicsAllTests[4] = new Image[] { PicTest_5_1, PicTest_5_2, PicTest_5_3, PicTest_5_4, PicTest_5_5, PicTest_5_6 };
            arrPicsAllTests[5] = new Image[] { PicTest_6_1, PicTest_6_2, PicTest_6_3, PicTest_6_4, PicTest_6_5, PicTest_6_6 };
            arrPicsAllTests[6] = new Image[] { PicTest_7_1, PicTest_7_2, PicTest_7_3, PicTest_7_4, PicTest_7_5, PicTest_7_6 };
            arrPicsAllTests[7] = new Image[] { PicTest_8_1, PicTest_8_2, PicTest_8_3, PicTest_8_4, PicTest_8_5, PicTest_8_6 };
            arrPicsAllTests[8] = new Image[] { PicTest_9_1, PicTest_9_2, PicTest_9_3, PicTest_9_4, PicTest_9_5, PicTest_9_6 };
            arrPicsAllTests[9] = new Image[] { PicTest_10_1, PicTest_10_2, PicTest_10_3, PicTest_10_4, PicTest_10_5, PicTest_10_6 };
            arrPicsAllTests[10] = new Image[] { PicTest_11_1, PicTest_11_2, PicTest_11_3, PicTest_11_4, PicTest_11_5, PicTest_11_6 };
            arrPicsAllTests[11] = new Image[] { PicTest_12_1, PicTest_12_2, PicTest_12_3, PicTest_12_4, PicTest_12_5, PicTest_12_6 };
            arrPicsAllTests[12] = new Image[] { PicTest_13_1, PicTest_13_2, PicTest_13_3, PicTest_13_4, PicTest_13_5, PicTest_13_6 };
            arrPicsAllTests[13] = new Image[] { PicTest_14_1, PicTest_14_2, PicTest_14_3, PicTest_14_4, PicTest_14_5, PicTest_14_6 };
            arrPicsAllTests[14] = new Image[] { PicTest_15_1, PicTest_15_2, PicTest_15_3, PicTest_15_4, PicTest_15_5, PicTest_15_6 };
            arrPicsAllTests[15] = new Image[] { PicTest_16_1, PicTest_16_2, PicTest_16_3, PicTest_16_4, PicTest_16_5, PicTest_16_6 };
            arrPicsAllTests[16] = new Image[] { PicTest_17_1, PicTest_17_2, PicTest_17_3, PicTest_17_4, PicTest_17_5, PicTest_17_6 };
            arrPicsAllTests[17] = new Image[] { PicTest_18_1, PicTest_18_2, PicTest_18_3, PicTest_18_4, PicTest_18_5, PicTest_18_6 };
            arrPicsAllTests[18] = new Image[] { PicTest_19_1, PicTest_19_2, PicTest_19_3, PicTest_19_4, PicTest_19_5, PicTest_19_6 };
            arrPicsAllTests[19] = new Image[] { PicTest_20_1, PicTest_20_2, PicTest_20_3, PicTest_20_4, PicTest_20_5, PicTest_20_6 };
            arrPicsAllTests[20] = new Image[] { PicTest_21_1, PicTest_21_2, PicTest_21_3, PicTest_21_4, PicTest_21_5, PicTest_21_6 };
            arrPicsAllTests[21] = new Image[] { PicTest_22_1, PicTest_22_2, PicTest_22_3, PicTest_22_4, PicTest_22_5, PicTest_22_6 };
            arrPicsAllTests[22] = new Image[] { PicTest_23_1, PicTest_23_2, PicTest_23_3, PicTest_23_4, PicTest_23_5, PicTest_23_6 };
            arrPicsAllTests[23] = new Image[] { PicTest_24_1, PicTest_24_2, PicTest_24_3, PicTest_24_4, PicTest_24_5, PicTest_24_6, PicTest_24_7, PicTest_24_8 };
            arrPicsAllTests[24] = new Image[] { PicTest_25_1, PicTest_25_2, PicTest_25_3, PicTest_25_4, PicTest_25_5, PicTest_25_6 };
            arrPicsAllTests[25] = new Image[] { PicTest_26_1, PicTest_26_2, PicTest_26_3, PicTest_26_4, PicTest_26_5, PicTest_26_6, PicTest_26_7, PicTest_26_8 };
            arrPicsAllTests[26] = new Image[] { PicTest_27_1, PicTest_27_2, PicTest_27_3, PicTest_27_4, PicTest_27_5, PicTest_27_6, PicTest_27_7, PicTest_27_8 };
            arrPicsAllTests[27] = new Image[] { PicTest_28_1, PicTest_28_2, PicTest_28_3, PicTest_28_4, PicTest_28_5, PicTest_28_6, PicTest_28_7, PicTest_28_8 };
            arrPicsAllTests[28] = new Image[] { PicTest_29_1, PicTest_29_2, PicTest_29_3, PicTest_29_4, PicTest_29_5, PicTest_29_6, PicTest_29_7, PicTest_29_8 };
            arrPicsAllTests[29] = new Image[] { PicTest_30_1, PicTest_30_2, PicTest_30_3, PicTest_30_4, PicTest_30_5, PicTest_30_6, PicTest_30_7, PicTest_30_8 };
            arrPicsAllTests[30] = new Image[] { PicTest_31_1, PicTest_31_2, PicTest_31_3, PicTest_31_4, PicTest_31_5, PicTest_31_6, PicTest_31_7, PicTest_31_8 };
            arrPicsAllTests[31] = new Image[] { PicTest_32_1, PicTest_32_2, PicTest_32_3, PicTest_32_4, PicTest_32_5, PicTest_32_6, PicTest_32_7, PicTest_32_8 };
            arrPicsAllTests[32] = new Image[] { PicTest_33_1, PicTest_33_2, PicTest_33_3, PicTest_33_4, PicTest_33_5, PicTest_33_6, PicTest_33_7, PicTest_33_8 };
            arrPicsAllTests[33] = new Image[] { PicTest_34_1, PicTest_34_2, PicTest_34_3, PicTest_34_4, PicTest_34_5, PicTest_34_6, PicTest_34_7, PicTest_34_8 };
            arrPicsAllTests[34] = new Image[] { PicTest_35_1, PicTest_35_2, PicTest_35_3, PicTest_35_4, PicTest_35_5, PicTest_35_6, PicTest_35_7, PicTest_35_8 };
            arrPicsAllTests[35] = new Image[] { PicTest_36_1, PicTest_36_2, PicTest_36_3, PicTest_36_4, PicTest_36_5, PicTest_36_6, PicTest_36_7, PicTest_36_8 };
            arrPicsAllTests[36] = new Image[] { PicTest_37_1, PicTest_37_2, PicTest_37_3, PicTest_37_4, PicTest_37_5, PicTest_37_6, PicTest_37_7, PicTest_37_8 };
            arrPicsAllTests[37] = new Image[] { PicTest_38_1, PicTest_38_2, PicTest_38_3, PicTest_38_4, PicTest_38_5, PicTest_38_6, PicTest_38_7, PicTest_38_8 };
            arrPicsAllTests[38] = new Image[] { PicTest_39_1, PicTest_39_2, PicTest_39_3, PicTest_39_4, PicTest_39_5, PicTest_39_6, PicTest_39_7, PicTest_39_8 };
            arrPicsAllTests[39] = new Image[] { PicTest_40_1, PicTest_40_2, PicTest_40_3, PicTest_40_4, PicTest_40_5, PicTest_40_6, PicTest_40_7, PicTest_40_8 };
            arrPicsAllTests[40] = new Image[] { PicTest_41_1, PicTest_41_2, PicTest_41_3, PicTest_41_4, PicTest_41_5, PicTest_41_6, PicTest_41_7, PicTest_41_8 };
            arrPicsAllTests[41] = new Image[] { PicTest_42_1, PicTest_42_2, PicTest_42_3, PicTest_42_4, PicTest_42_5, PicTest_42_6, PicTest_42_7, PicTest_42_8 };
            arrPicsAllTests[42] = new Image[] { PicTest_43_1, PicTest_43_2, PicTest_43_3, PicTest_43_4, PicTest_43_5, PicTest_43_6, PicTest_43_7, PicTest_43_8 };
            arrPicsAllTests[43] = new Image[] { PicTest_44_1, PicTest_44_2, PicTest_44_3, PicTest_44_4, PicTest_44_5, PicTest_44_6, PicTest_44_7, PicTest_44_8 };
            arrPicsAllTests[44] = new Image[] { PicTest_45_1, PicTest_45_2, PicTest_45_3, PicTest_45_4, PicTest_45_5, PicTest_45_6, PicTest_45_7, PicTest_45_8 };
            arrPicsAllTests[45] = new Image[] { PicTest_46_1, PicTest_46_2, PicTest_46_3, PicTest_46_4, PicTest_46_5, PicTest_46_6, PicTest_46_7, PicTest_46_8 };
            arrPicsAllTests[46] = new Image[] { PicTest_47_1, PicTest_47_2, PicTest_47_3, PicTest_47_4, PicTest_47_5, PicTest_47_6, PicTest_47_7, PicTest_47_8 };
            arrPicsAllTests[47] = new Image[] { PicTest_48_1, PicTest_48_2, PicTest_48_3, PicTest_48_4, PicTest_48_5, PicTest_48_6, PicTest_48_7, PicTest_48_8 };
            arrPicsAllTests[48] = new Image[] { PicTest_49_1, PicTest_49_2, PicTest_49_3, PicTest_49_4, PicTest_49_5, PicTest_49_6, PicTest_49_7, PicTest_49_8 };
            arrPicsAllTests[49] = new Image[] { PicTest_50_1, PicTest_50_2, PicTest_50_3, PicTest_50_4, PicTest_50_5, PicTest_50_6, PicTest_50_7, PicTest_50_8 };
            arrPicsAllTests[50] = new Image[] { PicTest_51_1, PicTest_51_2, PicTest_51_3, PicTest_51_4, PicTest_51_5, PicTest_51_6, PicTest_51_7, PicTest_51_8 };
            arrPicsAllTests[51] = new Image[] { PicTest_52_1, PicTest_52_2, PicTest_52_3, PicTest_52_4, PicTest_52_5, PicTest_52_6, PicTest_52_7, PicTest_52_8 };
            arrPicsAllTests[52] = new Image[] { PicTest_53_1, PicTest_53_2, PicTest_53_3, PicTest_53_4, PicTest_53_5, PicTest_53_6, PicTest_53_7, PicTest_53_8 };
            arrPicsAllTests[53] = new Image[] { PicTest_54_1, PicTest_54_2, PicTest_54_3, PicTest_54_4, PicTest_54_5, PicTest_54_6, PicTest_54_7, PicTest_54_8 };
            arrPicsAllTests[54] = new Image[] { PicTest_55_1, PicTest_55_2, PicTest_55_3, PicTest_55_4, PicTest_55_5, PicTest_55_6, PicTest_55_7, PicTest_55_8 };
            arrPicsAllTests[55] = new Image[] { PicTest_56_1, PicTest_56_2, PicTest_56_3, PicTest_56_4, PicTest_56_5, PicTest_56_6, PicTest_56_7, PicTest_56_8 };
            arrPicsAllTests[56] = new Image[] { PicTest_57_1, PicTest_57_2, PicTest_57_3, PicTest_57_4, PicTest_57_5, PicTest_57_6, PicTest_57_7, PicTest_57_8 };
            arrPicsAllTests[57] = new Image[] { PicTest_58_1, PicTest_58_2, PicTest_58_3, PicTest_58_4, PicTest_58_5, PicTest_58_6, PicTest_58_7, PicTest_58_8 };
            arrPicsAllTests[58] = new Image[] { PicTest_59_1, PicTest_59_2, PicTest_59_3, PicTest_59_4, PicTest_59_5, PicTest_59_6, PicTest_59_7, PicTest_59_8 };
            arrPicsAllTests[59] = new Image[] { PicTest_60_1, PicTest_60_2, PicTest_60_3, PicTest_60_4, PicTest_60_5, PicTest_60_6, PicTest_60_7, PicTest_60_8 };
        }
    }
}
