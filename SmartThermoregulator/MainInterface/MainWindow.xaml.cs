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

namespace MainInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Regulator reg = null;
        DeviceCollection devices = new DeviceCollection();
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void baseMode()
        {
            reg = new Regulator();

            reg.Uredjaji = devices.GetDevices();
            reg.ZeljenaDnevnaTemperatura = Double.Parse(tbTempDnevna.Text);
            reg.PocetakDnevniRezim = Int32.Parse(cbOdDnevni.Text);
            reg.KrajDnevniRezim = Int32.Parse(cbDoDnevni.Text);

            btnDodaj.IsEnabled = false;
        }

        private void checking(int pd, int kd)
        {
            cbOdDnevni.IsEnabled = false;
            cbDoDnevni.IsEnabled = false;
            btnSacuvaj.IsEnabled = false;
            tbTempDnevna.IsEnabled = false;
            btnPocetak.IsEnabled = true;
            tbTempNocna.IsEnabled = true;

            cbOdNocni.Items.Clear();
            cbDoNocni.Items.Clear();

            cbOdNocni.Items.Add(kd);
            cbDoNocni.Items.Add(pd);
            cbOdNocni.SelectedIndex = 0;
            cbDoNocni.SelectedIndex = 0;

        }

        private void btnKraj_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
