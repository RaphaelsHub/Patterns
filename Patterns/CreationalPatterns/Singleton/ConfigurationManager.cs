namespace Patterns.CreationalPatterns.Singleton;

// What's are the benefits of using a singleton like this?
// 1. We have lazy initialization.
// 2. We have thread safety, because of the static readonly field and the Lazy class, which blocks the thread until some other thread has finished initializing the instance.
// 3. Only one instance of the class can be created, and it's not allowed to create by the user.
// 4. No one can inherit from the class, because it's sealed.
public sealed class ConfigurationManager
{
    private static readonly Lazy<ConfigurationManager> _instance =
        new Lazy<ConfigurationManager>(() => new ConfigurationManager());

    private ConfigurationManager()
    {
        DeviceInfoProvider deviceInfoProvider = new DeviceInfoProvider();
        DeviceModel = deviceInfoProvider.GetDeviceInfo();
    }

    public static ConfigurationManager Instance => _instance.Value;
    
    public DeviceModel DeviceModel { get; private set; }
}