using Common.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Implementation
{
    [Serializable]

    public class DeviceCollection : IDeviceCollection
    {
        private List<Device.Device> devices = new List<Device.Device>();

        public bool AddDevice(Device.Device marshalRef)
        {
            if(devices.Count>9)
            {
                return false;
            }
            else
            {
                devices.Add(marshalRef);

                return true;
            }
        }

        public List<Device.Device> GetDevices()
        {
            return devices;
        }

        public bool AddDevice()
        {
            if( devices.Count>9 )
            { 
                return false;
            }
            else
            {
                devices.Add(new Device.Device());
                return true;
            }
        }
    }
}
