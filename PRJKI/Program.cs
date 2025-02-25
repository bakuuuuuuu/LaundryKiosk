namespace PRJKI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //// 임시 전화번호 설정 (나중에 로그인 시스템에서 전화번호를 받게 됨)
            //string phoneNumber = "010-1234-5678";  // 테스트용 전화번호

            //// Form4 생성자에 phoneNumber 전달
            //Application.Run(new Form4(phoneNumber));
            Application.Run(new Form1());
        }
    }
}