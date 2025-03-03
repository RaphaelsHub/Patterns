using Patterns.CreationalPatterns.Builder.ApplicationSettingsModel;

namespace Patterns.CreationalPatterns.Builder.Interfaces;

public abstract class SettingsBuilder
{
    protected ApplicationSettings ApplicationSettings = null!;
    
    public abstract SettingsBuilder SetResolution(int width,int height);
    public abstract SettingsBuilder SetFullscreen(bool fullscreen);
    public abstract SettingsBuilder SetVolume(int volume);
    public abstract SettingsBuilder SetBrightness(int brightness);
    public abstract SettingsBuilder SetLanguage(string language);
    public abstract ApplicationSettings Build();
}