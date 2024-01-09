using Heater;
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
using Common;
using Common.Implementation;

namespace InterfaceMain
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Regulator regulator = null;
        DeviceCollection devices = new DeviceCollection();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void basePosition()
        {
            dodajBTN.IsEnabled = false;

            regulator = new Regulator();

            regulator.Uredjaji = devices.GetDevices();
            regulator.ZeljenaDnevnaTemperatura = Double.Parse(dnevnaTemp.Text);
            regulator.PocetakDnevniRezim = Int32.Parse(pocetakDnevna.Text);
            regulator.KrajDnevniRezim = Int32.Parse(krajDnevna.Text);
        }

        private void checkAll(int pd, int kd)
        {
            saveBTN.IsEnabled = false;
            dnevnaTemp.IsEnabled = false;
            startBTN.IsEnabled = true;
            pocetakDnevna.IsEnabled = false;
            krajDnevna.IsEnabled = false;

            nocnaTemp.IsEnabled = true;
            pocetakNocna.Items.Clear();
            krajNocna.Items.Clear();

            pocetakNocna.Items.Add(kd);
            krajNocna.Items.Add(pd);
            pocetakNocna.SelectedIndex = 0;
            krajNocna.SelectedIndex = 0;

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dodajBTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void saveBTN_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
