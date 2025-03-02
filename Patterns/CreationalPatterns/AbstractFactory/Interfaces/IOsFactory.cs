namespace Patterns.CreationalPatterns.AbstractFactory.Interfaces;

public interface IOsFactory
{
    IFileSystem GetFileSystem();
    IAntivirusSystem GetAntivirusSystem();
}