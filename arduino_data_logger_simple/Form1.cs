using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace arduino_data_logger_simple
{
    public partial class Form1 : Form
    {
        bool isConnected = false;
        string[] ports;
        SerialPort port;

        private DateTime dt;
        private string in_data;

        public Form1()
        {
            InitializeComponent();

            ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                comboBox_serialPort.Items.Add(port);
            }
            if (ports != null && ports.Length != 0 && ports[0] != null)
            {
                comboBox_serialPort.SelectedItem = ports[0];
            }
        }

        private void clicked_button_connect(object sender, EventArgs e)
        {
            if (ports == null || ports.Length == 0 || ports[0] == null || comboBox_serialPort.SelectedItem == null)
            {
                MessageBox.Show("Please select a serial port for connection", "Unable to connect");
            }
            else if (!isConnected)
            {
                comboBox_serialPort.Enabled = false;
                string selectedPort = comboBox_serialPort.GetItemText(comboBox_serialPort.SelectedItem);
                port = new SerialPort(selectedPort, 9600);
                port.DataReceived += port_dataReceived;
                port.Open();

                isConnected = true;
                button_connect.Text = "Disconnect";
            }
            else
            {
                isConnected = false;
                port.Close();
                comboBox_serialPort.Enabled = true;

                button_connect.Text = "Connect";
            }
        }

        private void port_dataReceived(object sender, SerialDataReceivedEventArgs args)
        {
            if (isConnected)
            {
                in_data = port.ReadLine();
                this.Invoke(new EventHandler(display_event));
            }
        }

        private void display_event(object sender, EventArgs e)
        {
            dt = DateTime.Now;
            textBox_display.AppendText(dt.Hour + ":" + dt.Minute + ":" + dt.Second + "\t\t" + in_data + "\n");
        }
    }
}
