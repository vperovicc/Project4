using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Device.Interface;
using Device.Implementation;

namespace Device
{
    public class Device : MarshalByRefObject, IDevice, INotifyPropertyChanged
    {
        private int deviceID;
        private double temp;

        public Device()
        {
            deviceID = new Random().Next(0, 10000);
            temp = Math.Round((new Random().Next(-10, 37) + (new Random().NextDouble())),2);

            NewCalculation();
        }

        public Device(int id, double t)
        {
            deviceID = id;
            temp = t;
        }

        public int devID
        {
            get => deviceID;
            set => deviceID = value;
        }

        public double Temperature
        {
            get { return temp; }
            set
            {
                if(value!=temp)
                {
                    temp = value;
                    OnPropertyChanged("temperatura");
                }
            }
        }

        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

  
        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, e);
        }
        protected void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }
        public async void NewCalculation()
        {
            PeriodicTimer time = new PeriodicTimer();

            await time.SlanjeMerenja(devID, temp);

            temp = Math.Round((new Random().Next(-10, 37) + (new Random().NextDouble())), 2);
        }
    }
}
