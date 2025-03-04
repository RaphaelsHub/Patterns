using Patterns.CreationalPatterns;

namespace Patterns
{
    class Program
    {
        static void Main()
        {
            var torrentApp = new TorrentApplication();
            Console.WriteLine("==================================");
            torrentApp.DownloadTorrent();
            Console.WriteLine("==================================\n");
            
            Console.WriteLine("==================================");
            torrentApp.InstallApplication();
            Console.WriteLine("==================================\n");
            
            Console.WriteLine("==================================");
            torrentApp.OpenApplication();
            Console.WriteLine("==================================\n");
            
            Console.WriteLine("==================================");
            torrentApp.SetApplicationSettings();
            Console.WriteLine("==================================\n");
            
            Console.WriteLine("==================================");
            torrentApp.UninstallApplication();
            Console.WriteLine("==================================\n");
            
            Console.WriteLine("==================================");
            torrentApp.DeleteTorrent();
            Console.WriteLine("==================================\n");
            
            Console.WriteLine("==================================");
            torrentApp.CloneRobot();
            Console.WriteLine("==================================\n");
        }
    }
}