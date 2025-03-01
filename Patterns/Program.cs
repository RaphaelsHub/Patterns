using Patterns.CreationalPatterns.AbstractFactory;
using Patterns.CreationalPatterns.Singleton;

namespace Patterns;

class Program
{
    static void Main()
    {
        var model = ConfigurationManager.Instance.DeviceModel;
        Console.WriteLine($"The name of the device is {model.DeviceName}" +
                          $" and the operating system is {model.OperatingSystem}" +
                          $" and the storage capacity is {model.Storage}");

        Application app = new();
        app.CreateDirectory("\\Users\\Public\\Documents\\MyFolder");
        app.DeleteDirectory("\\Users\\Public\\Documents\\MyFolder");
    }
}