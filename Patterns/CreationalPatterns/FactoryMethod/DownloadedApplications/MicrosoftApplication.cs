using Patterns.CreationalPatterns.FactoryMethod.Interfaces;

namespace Patterns.CreationalPatterns.FactoryMethod.DownloadedApplications;

public class MicrosoftApplication : IApplication
{
    public void InstallApp()
    {
        Console.WriteLine("Installing Application on Windows");
        Task.Delay(3000).Wait();
        Console.WriteLine("Application installed on Windows");
    }

    public void UninstallApp()
    {
        Console.WriteLine("Uninstalling Application on Windows");
        Task.Delay(3000).Wait();
        Console.WriteLine("Application uninstalled on Windows");
    }
}