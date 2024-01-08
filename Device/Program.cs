using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Device
{
    class Program
    {
        static void Main(string[] args)
        {
            Device server = new Device();
            TcpChannel channel = new TcpChannel(int.Parse(args[0]));
            ChannelServices.RegisterChannel(channel, false);
            string uri = "Device";
            RemotingServices.Marshal(server, uri, server.GetType());

            Console.WriteLine("Device pocinje sa radom");

            Console.WriteLine("Port: " + args[0]);
            while (true)
            {
                Console.WriteLine("\nInformacija\n\tID: {0}\n\tTemperatura: {1}°C", server.DeviceID, server.Temperature);
                Thread.Sleep(2000); 

                Thread.Sleep(new Random().Next(1500, 8000)); 
                server.Temperature = Math.Round((new Random().Next((int)(server.Temperature - 8), (int)(server.Temperature + 4)) + (new Random().NextDouble())), 2);
            }
        }
    }
}
