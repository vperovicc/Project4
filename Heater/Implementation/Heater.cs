using Heater.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heater
{
    public class Heater : IHeater
    {

        public bool IsHeaterOn { get; set; }
        public List<Device.Device> devices { get; set; }



        public void PokreniZagrevanje()
        {
            throw new NotImplementedException();
        }
    }
}
