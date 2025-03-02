using Patterns.CreationalPatterns.AbstractFactory.FileSystems;
using Patterns.CreationalPatterns.AbstractFactory.Interfaces;

namespace Patterns.CreationalPatterns.AbstractFactory.Factories;

public class AppleFactory : IOsFactory
{
    public IFileSystem GetFileSystem() => new AppleFileSystem();
    public IAntivirusSystem GetAntivirusSystem() => new AppleAntivirusSystem();
}