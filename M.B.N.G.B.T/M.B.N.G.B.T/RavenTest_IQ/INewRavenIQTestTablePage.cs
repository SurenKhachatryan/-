namespace M.B.N.G.B.T.RavenTest_IQ
{
    interface INewRavenIQTestTablePage
    {
        /// <summary>
        /// Этот метод обнулировает все данные в классе RavenTestIQTablePage для нового пользователя
        /// (как новое окно) и включает Таймер
        /// </summary>
        void CreateNewPageTestRavenForNewUserAndSrartTimer();
        /// <summary>
        /// Этот метод обнулировает все данные в классе RavenTestIQTablePage для нового пользователя
        /// (как новое окно) и отключает Таймер
        /// </summary>
        void CreateNewPageTestRavenoForNewUserAndStopTimer();
    }
}
