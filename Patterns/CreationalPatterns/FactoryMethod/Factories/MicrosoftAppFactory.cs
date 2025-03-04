using Patterns.CreationalPatterns.FactoryMethod.DownloadedApplications;
using Patterns.CreationalPatterns.FactoryMethod.Interfaces;

namespace Patterns.CreationalPatterns.FactoryMethod.Factories;

public class MicrosoftAppFactory : ApplicationCreator
{
    public override IApplication CreateApp()
    {
        return new MicrosoftApplication();
    }
}