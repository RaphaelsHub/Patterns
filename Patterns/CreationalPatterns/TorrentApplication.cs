using Patterns.CreationalPatterns.AbstractFactory.Factories;
using Patterns.CreationalPatterns.AbstractFactory.Interfaces;
using Patterns.CreationalPatterns.Builder;
using Patterns.CreationalPatterns.FactoryMethod.DownloadedApplications;
using Patterns.CreationalPatterns.FactoryMethod.Factories;
using Patterns.CreationalPatterns.FactoryMethod.Interfaces;
using Patterns.CreationalPatterns.Prototype;
using Patterns.CreationalPatterns.Singleton;

namespace Patterns.CreationalPatterns;

public class TorrentApplication
{
    private readonly ApplicationBuilder _aplicationBuilder = new();
    private readonly IFileSystem _fileSystem; 
    private readonly IAntivirusSystem _antivirusSystem;
    private readonly IApplication _application;

    public TorrentApplication()
    {
        // Singleton pattern - by getting device model instance from ConfigurationManager, we get some necessary information about the device, for future use.
        DeviceModel model = ConfigurationManager.Instance.DeviceModel;
        Console.WriteLine($"The name of the device is {model.DeviceName}" +
                          $" and the operating system is {model.OperatingSystem}" +
                          $" and the storage capacity is {model.Storage}");
        
        IOsFactory factory = model.OperatingSystem.Contains("Windows") ? new WindowsFactory() : new AppleFactory();
        _fileSystem = factory.GetFileSystem();
        _antivirusSystem = factory.GetAntivirusSystem();
        
        _application = model.OperatingSystem.Contains("Windows") ? new MicrosoftApplication() : new AppleApplication();
    }

    public void DownloadTorrent()
    {
        Console.WriteLine("Downloading torrent...");
        _fileSystem.CreateDirectory("\\Users\\Public\\Documents\\MyFolder");
        Task.Delay(3000).Wait();
        Console.WriteLine("Torrent downloaded successfully!");
        Task.Delay(2000).Wait();
    }
    
    public void DeleteTorrent()
    {
        Console.WriteLine("Deleting torrent...");
        _fileSystem.DeleteDirectory("\\Users\\Public\\Documents\\MyFolder");
        Task.Delay(3000).Wait();
        Console.WriteLine("Torrent deleted successfully!");
        Task.Delay(2000).Wait();
    }
    
    public void InstallApplication()
    {
        Console.WriteLine("Installing Application...");
        _antivirusSystem.CheckIfIsSave("\\Users\\Public\\Documents\\MyFolder");
        _application.InstallApp();
        Console.WriteLine("Application installed successfully!");
        Task.Delay(2000).Wait();
    }
    
    public void UninstallApplication()
    {
        Console.WriteLine("Uninstalling Application...");
        _application.UninstallApp();
        Console.WriteLine("Application uninstalled successfully!");
        Task.Delay(2000).Wait();
    }
    
    public void OpenApplication()
    {
        Console.WriteLine("Opening Application...");
        Console.WriteLine("Setting Up Default Settings...");
        var director = new ApplicationDirector();
        //var builder = new AplicationBuilder();
        director.SetDefault(_aplicationBuilder);
        Task.Delay(5000).Wait();
        Console.WriteLine("Game settings: " + _aplicationBuilder);
        Console.WriteLine("Default settings applied!");
        Console.WriteLine("Application opened successfully!");
        Task.Delay(2000).Wait();
    }
    
    public void SetApplicationSettings()
    {
        Console.WriteLine("Setting Application Settings By User...");
        // var builder = new AplicationBuilder();
        _aplicationBuilder.SetFullscreen(true)
            .SetBrightness(3)
            .SetVolume(20)
            .SetLanguage("English")
            .SetResolution(100, 100)
            .Build();
        Console.WriteLine("Game settings: " + _aplicationBuilder);
        Task.Delay(2000).Wait();
    }
    
    public void CloneRobot()
    {
        AndroidRobot robot = new AndroidRobot
        {
            Data = new AndroidRobotDataModel(1, "Robot A", "Model A", "Android A", "Cpu A", "Gpu A")
        };
        
        Console.WriteLine("First robot: " + robot);
        
        AndroidRobotDataModel dataSecond = new AndroidRobotDataModel(2, "Robot B", "Model B", "Android B", "Cpu B", "Gpu B");
        
        AndroidRobot robotClone = robot.Clone();
        robotClone.Data = dataSecond;
        Console.WriteLine("Second robot: " + robotClone);
        
        Task.Delay(2000).Wait();
    }
}