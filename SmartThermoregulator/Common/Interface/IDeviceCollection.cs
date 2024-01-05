using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interface
{
    public interface IDeviceCollection
    {
        bool AddDevice(Device.Device mr);

        List<Device.Device> GetDevices();
    }
}
