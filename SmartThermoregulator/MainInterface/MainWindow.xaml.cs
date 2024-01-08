using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Heater;
using Common.Implementation;
using System.IO;
using System.Diagnostics;
using System.Runtime.Remoting;
using System.Threading;

namespace MainInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Regulator reg = null;
        DeviceCollection devices = new DeviceCollection();
        int[] port = new int[100];
        int instance = 0;
        List<Device.Device> display = new List<Device.Device>();

        public MainWindow()
        {
            InitializeComponent();

            for (int i = 0; i < 100; i++)
                port[i] = 8500 + i;
        }

        private void btnDodaj_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                string dir = Environment.CurrentDirectory;
                dir = Directory.GetParent(dir).Parent.Parent.FullName;

                Process process = new Process();

                process.StartInfo.FileName = dir + "\\bin\\Debug\\Device.exe";
                process.StartInfo.Arguments = port[instance].ToString();
                process.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;

                process.Start();

                string stringConn = "tcp://localhost:" + port[instance].ToString() + "/Device";
                Device.Device mr = RemotingServices.Connect(typeof(Device.Device), stringConn) as Device.Device;

                if (devices.AddDevice(mr))
                {
                    MessageBox.Show("Uređaj je uspešno dodat!", "Informacija", MessageBoxButton.OK, MessageBoxImage.Information);
                    instance++; 

                    
                    var tmp = new Device.Device(mr.DeviceID, mr.Temperature);
                    display.Add(tmp);
                }
                else
                {
                    MessageBox.Show("Prekoračili ste granicu za dodavanje uredjaja!", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Warning);

            }

        }

        private void btnSacuvaj_Click(object sender, RoutedEventArgs e)
        {
            if(devices.GetDevices().Count<4)
            {
                MessageBox.Show("Minimum je 4 uredjaja!","Warning", MessageBoxButton.OK,MessageBoxImage.Warning);
                return;
            }

            if(odDnevni.SelectedIndex != -1 && doDnevni.SelectedIndex != -1 && !TempDnevna.Text.Equals(""))
            {
                try
                {
                    activeDevices.ItemsSource = display;

                    int pd = Int32.Parse(odDnevni.Text);
                    int kd = Int32.Parse(doDnevni.Text);

                    if(pd>kd)
                    {
                        MessageBox.Show("Nevalidne vrednosti!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                        return;
                    }

                    checking(pd, kd);
                    baseMode();
                }
                catch(Exception)
                {
                    MessageBox.Show("Niste uneli broj!", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                MessageBox.Show("Uneli ste nevalidne vrednosti!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private async void btnPocetak_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                reg.ZeljenaNocnaTemperatura = Double.Parse(TempNocna.Text);

                TempNocna.IsEnabled = false;
                btnPocetak.IsEnabled = false;

                MessageBox.Show("Regulator počinje rad!", "Informacija", MessageBoxButton.OK, MessageBoxImage.Information);

                reg.InstanceCnt = instance;   
                reg.Regulation();

                statusRegulatora.Content = "Stanje: Radi";
                statusRegulatora.Foreground = Brushes.Blue;
                avgTempCheck();

                await checkLeftTempr();
            }
            catch (Exception)
            {
                MessageBox.Show("Treba da unesete broj!", "Greška", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }

        private void btnKraj_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

          private void baseMode()
          {
              reg = new Regulator();

              reg.Uredjaji = devices.GetDevices();
              reg.ZeljenaDnevnaTemperatura = Double.Parse(TempDnevna.Text);
              reg.PocetakDnevniRezim = Int32.Parse(odDnevni.Text);
              reg.KrajDnevniRezim = Int32.Parse(doDnevni.Text);

              btnDodaj.IsEnabled = false;
          }

          private void checking(int pd, int kd)
          {
              odDnevni.IsEnabled = false;
              doDnevni.IsEnabled = false;
              btnSacuvaj.IsEnabled = false;
              TempDnevna.IsEnabled = false;
              btnPocetak.IsEnabled = true;
              TempNocna.IsEnabled = true;

              odNocni.Items.Clear();
              doNocni.Items.Clear();

              odNocni.Items.Add(kd);
              doNocni.Items.Add(pd);
              odNocni.SelectedIndex = 0;
              doNocni.SelectedIndex = 0;

          }

        public async Task periodicTest(TimeSpan i, CancellationToken ct)
        {
            await Task.Delay(i, ct);
        }

        private async Task checkLeftTempr()
        {
            CancellationToken c = new CancellationToken();
            TimeSpan time = new TimeSpan(0, 0, 2); 

            for (; !c.IsCancellationRequested;)
            {
                await periodicTest(time, c);

                avgTempCheck();
            }
      
        }

        private void avgTempCheck()
        {
            try
            {
                double sum = 0;

                foreach (Device.Device d in devices.GetDevices())
                {
                    sum += d.Temperature;
                }

                sum /= devices.GetDevices().Count;

                double left = Double.Parse(TempDnevna.Text) - Math.Round(sum, 2);

                if(left>0)
                {
                    statusRegulatora.Content = "Stanje: Radi";
                    statusRegulatora.Foreground = Brushes.Blue;
                    tempLeft.Content = "Preostalo: " + left.ToString().Replace(',', '.') + "°C";
                }
                else
                {
                    statusRegulatora.Content = "Stanje: Idle";
                    statusRegulatora.Foreground = Brushes.DarkCyan;

                    tempLeft.Content = "Preostalo: " + "0.0" + "°C";
                    tempLeft.Foreground = Brushes.DarkCyan;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Greška u temperaturi zagrevanja!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


    }
}
