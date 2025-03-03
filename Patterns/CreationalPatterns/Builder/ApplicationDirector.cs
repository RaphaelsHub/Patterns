using Patterns.CreationalPatterns.Builder.ApplicationSettingsModel;
using Patterns.CreationalPatterns.Builder.Interfaces;

namespace Patterns.CreationalPatterns.Builder;

public class ApplicationDirector
{
    public ApplicationSettings SetDefault(SettingsBuilder builder)
    {
        return builder
            .SetLanguage("Russian")
            .SetResolution(1920, 1080)
            .SetFullscreen(true)
            .SetVolume(50)
            .SetBrightness(50)
            .Build();
    }
}
