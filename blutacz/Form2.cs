using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
    public partial class Form2 : Form
    {
        Thread nasluchuj = new Thread(nasluch);
        public BluetoothDeviceInfo device;
        private Form1 f1;

        static private void nasluch()
        {
            while (true)
            {
                var listener = new ObexListener(ObexTransport.Bluetooth);
                listener.Start();
                ObexListenerContext con = listener.GetContext();
                ObexListenerRequest req = con.Request;
                String[] pathSplits = req.RawUrl.Split('/');
                String filename = pathSplits[pathSplits.Length - 1];
                req.WriteFile(filename);
                listener.Stop();
            }
        }

        public Form2(Form1 parentForm)
        {
            InitializeComponent();
            f1 = parentForm;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            device = f1.devChosen;
            label2.Text = device.DeviceAddress.ToString();
            if (BluetoothSecurity.PairRequest(device.DeviceAddress, "1234"))
            {
                nasluchuj.Start();
                label3.Text = "Sparowano";
            }
            else
                label3.Text = "Błąd parowania";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                }
                catch (IOException)
                {
                }

                var fileToSend = new Uri("obex://" + device.DeviceAddress + "/" + file);
                var obexReq = new ObexWebRequest(fileToSend);
                obexReq.ReadFile(file);
                var obexResp = obexReq.GetResponse();
                obexResp.Close();
            }
        }
    }
}
