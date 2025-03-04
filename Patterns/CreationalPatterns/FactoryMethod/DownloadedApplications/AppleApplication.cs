using Patterns.CreationalPatterns.FactoryMethod.Interfaces;

namespace Patterns.CreationalPatterns.FactoryMethod.DownloadedApplications;

public class AppleApplication : IApplication
{
    public void InstallApp()
    {
        Console.WriteLine("Installing application on Apple");
        Task.Delay(3000).Wait();
        Console.WriteLine("Application installed");
    }

    public void UninstallApp()
    {
        Console.WriteLine("Uninstalling application on Apple");
        Task.Delay(3000).Wait();
        Console.WriteLine("Application uninstalled");
    }
}