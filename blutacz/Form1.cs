using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;

namespace blutacz
{
    public partial class Form1 : Form
    {
        public BluetoothRadio[] adapters { get; set; }
        public BluetoothClient client = new BluetoothClient();
        public BluetoothDeviceInfo[] devices { get; set; }
        public BluetoothDeviceInfo devChosen { get; set; }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void szukajAdaptBt_Click(object sender, EventArgs e)
        {
            adapterBox.Items.Clear();
            adapters = BluetoothRadio.AllRadios;
            foreach (var adapter in adapters)
            {
                adapterBox.Items.Add(adapter.Name);
            }

            
        }

        private void deviceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MAC;
            foreach (BluetoothDeviceInfo dev in deviceBox.SelectedItems)
            {
                MAC = dev.DeviceAddress.ToString();
                macAdressLabel.Text = MAC;
                devChosen = dev;
            }
        }

        private void szukajUrzBt_Click(object sender, EventArgs e)
        {
            deviceBox.Items.Clear();
            devices = client.DiscoverDevices();
            foreach (BluetoothDeviceInfo device in devices)
            {
                deviceBox.Items.Add(device);
            }
            deviceBox.DisplayMember = "device.DeviceName";
        }

        private void wybierzBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2(this);
            form2.device = devChosen;
            form2.Show();
        }
    }
}
