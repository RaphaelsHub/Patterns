using Patterns.CreationalPatterns.FactoryMethod.DownloadedApplications;
using Patterns.CreationalPatterns.FactoryMethod.Interfaces;

namespace Patterns.CreationalPatterns.FactoryMethod.Factories;

public class AppleAppFactory : ApplicationCreator
{
    public override IApplication CreateApp()
    {
        return new AppleApplication();
    }
}