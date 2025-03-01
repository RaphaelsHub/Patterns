using Patterns.CreationalPatterns.AbstractFactory.Interfaces;

namespace Patterns.CreationalPatterns.AbstractFactory.FileSystems;

public class AppleFileSystem : IFileSystem
{
    public void CreateDirectory(string path)
    {
        Console.WriteLine($"Creating directory {path} on Apple");
    }

    public void DeleteDirectory(string path)
    {
        Console.WriteLine($"Deleting directory {path} on Apple");
    }
}