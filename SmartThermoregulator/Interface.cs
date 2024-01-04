using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SmartThermoregulator
{
    public partial class Interface : Form
    {
        

        public Interface()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void positioningStart()
        {
            dodajBTN.Enabled = false;
        }

        private void Interface_Load(object sender, EventArgs e)
        {

        }
    }
}
