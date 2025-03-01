using Patterns.CreationalPatterns.AbstractFactory.FileSystems;
using Patterns.CreationalPatterns.AbstractFactory.Interfaces;

namespace Patterns.CreationalPatterns.AbstractFactory.Factories;

public class WindowsFactory : IOsFactory
{
    public IFileSystem GetFileSystem() => new WindowsFileSystem();
}