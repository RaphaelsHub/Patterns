using Patterns.CreationalPatterns.AbstractFactory.Interfaces;

namespace Patterns.CreationalPatterns.AbstractFactory.FileSystems;

public class WindowsAntivirusSystem : IAntivirusSystem
{
    // This method just simulates the process of checking if a file is safe or not
    public bool CheckIfIsSave(string path)
    {
        Console.WriteLine($"Checking {path} on Windows");
        Task.Delay(1000).Wait();
        Console.WriteLine($"Checked {path} on Windows and it's safe");
        return true;
    }
}