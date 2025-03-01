using Patterns.CreationalPatterns.Singleton;

namespace Patterns;

class Program
{
    static void Main()
    {
        Console.WriteLine(ConfigurationManager.Instance.DeviceModel.DeviceName);
        Console.WriteLine(ConfigurationManager.Instance.DeviceModel.OperatingSystem);
        Console.WriteLine(ConfigurationManager.Instance.DeviceModel.Storage);
    }
}