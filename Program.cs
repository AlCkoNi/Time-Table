namespace Time_Table
{
    internal static class Program
    {
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new StartPage());
        }
    }
}
