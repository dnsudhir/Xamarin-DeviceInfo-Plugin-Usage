using Plugin.DeviceInfo;
using Plugin.DeviceInfo.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Device_Details.ViewModels
{
    class DeviceInfoViewModel:IDeviceInfo
{
        IDeviceInfo deviceInfo;
        public DeviceInfoViewModel()
        {
            deviceInfo = Plugin.DeviceInfo.CrossDeviceInfo.Current;
        }

        public string Id => deviceInfo.Id;

        public string Model => deviceInfo.Model;

        public string Manufacturer => deviceInfo.Manufacturer;

        public string DeviceName => deviceInfo.DeviceName;

        public string Version => deviceInfo.Version;

        public Version VersionNumber => deviceInfo.VersionNumber;

        public string AppVersion => deviceInfo.AppVersion;

        public string AppBuild => deviceInfo.AppBuild;

        public Platform Platform => deviceInfo.Platform;

        public Idiom Idiom => deviceInfo.Idiom;

        public bool IsDevice => deviceInfo.IsDevice;

        public string GenerateAppId(bool usingPhoneId = false, string prefix = null, string suffix = null)
        {
            throw new NotImplementedException();
        }
    }
}
