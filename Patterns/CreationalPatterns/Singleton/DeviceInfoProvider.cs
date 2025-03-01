namespace Patterns.CreationalPatterns.Singleton
{
    public class DeviceInfoProvider
    {
        public DeviceModel GetDeviceInfo()
        {
            return new DeviceModel(
                Environment.MachineName, 
                Environment.OSVersion.VersionString, 
                GetTotalStorageSpaceInGb());
        }
    
        private int GetTotalStorageSpaceInGb()
        {
            long totalSpace = 0;
            foreach (var drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    totalSpace += drive.TotalSize;
                }
            }
            return (int)(totalSpace / (1024 * 1024 * 1024)); 
        }
    }
}