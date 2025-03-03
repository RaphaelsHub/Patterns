using Patterns.CreationalPatterns.Builder.ApplicationSettingsModel;
using Patterns.CreationalPatterns.Builder.Interfaces;

namespace Patterns.CreationalPatterns.Builder;

public class ApplicationBuilder : SettingsBuilder
{
    public ApplicationBuilder() => ApplicationSettings = new ApplicationSettings();

    public override string ToString()
    {
        return ApplicationSettings.ToString();
    }

    public override SettingsBuilder SetResolution(int width, int height)
    {
        ApplicationSettings.ResolutionWidth = width;
        ApplicationSettings.ResolutionHeight = height;
        return this;
    }
    
    public override SettingsBuilder SetFullscreen(bool fullscreen)
    {
        ApplicationSettings.Fullscreen = fullscreen;
        return this;
    }

    public override SettingsBuilder SetVolume(int volume)
    {
        ApplicationSettings.Volume = volume;
        return this;
    }

    public override SettingsBuilder SetBrightness(int brightness)
    {
        ApplicationSettings.Brightness = brightness;
        return this;
    }

    public override SettingsBuilder SetLanguage(string language)
    {
        ApplicationSettings.Language = language;
        return this;
    }

    public override ApplicationSettings Build() => ApplicationSettings;
}