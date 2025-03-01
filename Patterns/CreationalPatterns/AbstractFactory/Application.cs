using Patterns.CreationalPatterns.AbstractFactory.Factories;
using Patterns.CreationalPatterns.AbstractFactory.Interfaces;
using Patterns.CreationalPatterns.Singleton;

namespace Patterns.CreationalPatterns.AbstractFactory;

public class Application
{
    private readonly IFileSystem _fileSystem;

    public Application()
    {
        IOsFactory factory = ConfigurationManager.Instance.DeviceModel.OperatingSystem.Contains("Windows")
            ? new WindowsFactory()
            : new AppleFactory();
        
        _fileSystem = factory.GetFileSystem();
    }
    
    public void CreateDirectory(string path) =>
        _fileSystem.CreateDirectory(path);
    
    public void DeleteDirectory(string path) =>
        _fileSystem.DeleteDirectory(path);
}