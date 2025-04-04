namespace WinFormsMiniGame;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        string inputFilePath = @"C:\Users\Алина\RiderProjects\EvenDrivenPractice\MiniGame\WinFormsMiniGame\map.txt";
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1(inputFilePath));
    }
}