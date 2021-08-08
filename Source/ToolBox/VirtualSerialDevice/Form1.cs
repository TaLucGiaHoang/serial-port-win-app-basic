///#define SELECT_CASE_1 


using System;
//using System.Collections.Generic;
//using System.ComponentModel;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;
//using System.Diagnostics;
//using System.Timers;



namespace VirtualSerialDevice
{
    public partial class Form1 : Form
    {
        static SerialPort _serialPort;

        public Form1()
        {
            InitializeComponent();
        }

        // https://stackoverflow.com/questions/39401946/serialport-readline-does-not-read-data-from-usb-com-port-sent-by-arduino
        // https://stackoverflow.com/questions/56908979/c-sharp-reading-data-from-a-serial-port-how-to-only-get-new-current-data/
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort sp = (SerialPort)sender;
                if (!sp.IsOpen) return;

                int bytes = sp.BytesToRead; // number of bytes received from UART COM port
                Console.Write("Received bytes: " + bytes + "\n"); // Debug

                // https://docs.microsoft.com/en-us/dotnet/api/system.io.ports.serialport.readline?view=netframework-4.8
                string indata = _serialPort.ReadLine();
                SetTextUart(indata);

                string []words = splitMessage(indata);
                if (words.Length >= 2)
                {
                    if(words[0] == "var1")
                    {
                        SetText1($"{words[1]}");
                    }
                }
            }
            catch (TimeoutException) { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                cbSerialPort.Items.Add(port);
            }

            if (ports.Length > 0)
            {
                cbSerialPort.SelectedIndex = 0;
            }
            else
            {
                btnConnect.Enabled = false;
            }
        }


        private void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                _serialPort = new SerialPort();  // or use with specified port SerialPort("COM7");
                _serialPort.BaudRate = Convert.ToInt32(txtBx_Speed.Text);
                _serialPort.PortName = cbSerialPort.Text;
                //_serialPort.Parity = Parity.None;
                //_serialPort.StopBits = StopBits.One;
                //_serialPort.DataBits = 8;
                //_serialPort.Handshake = Handshake.None;
                //_serialPort.RtsEnable = true;
                //_serialPort.DtrEnable = true;

                // Set the read/write timeouts
                //_serialPort.ReadTimeout = 500;
                //_serialPort.WriteTimeout = 500;

                _serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                _serialPort.Open();

                btnConnect.Enabled = false;
                btnClose.Enabled = true;
                btnOn.Enabled = true;
                btnOff.Enabled = true;
                btnToggle.Enabled = true;
                cbSerialPort.Enabled = false;

                SetTextUart("Open serial " + _serialPort.PortName + ", " + _serialPort.BaudRate + ", " + _serialPort.Parity + ", " + _serialPort.DataBits + ", " + _serialPort.StopBits + "\n");
                Console.Write("Open serial " + _serialPort.PortName + ", " + _serialPort.BaudRate + ", " + _serialPort.Parity + ", " + _serialPort.DataBits + ", " + _serialPort.StopBits + "\n");
            }
            catch (Exception) { };

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                _serialPort.Close();
                btnConnect.Enabled = true;
                btnClose.Enabled = false;
                btnOn.Enabled = false;
                btnOff.Enabled = false;
                btnToggle.Enabled = false;
                cbSerialPort.Enabled = true;

                SetTextUart("Close serial " + _serialPort.PortName);
                Console.WriteLine("Close serial " + _serialPort.PortName);
            }
            catch (Exception) { };
        }


        private void btnToggle_Click(object sender, EventArgs e)
        {
            _serialPort.WriteLine("var1:toggle");  // send command to device to turn off LED
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            _serialPort.WriteLine("var1:1");  // send command to device to turn on LED
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            _serialPort.WriteLine("var1:0");  // send command to device to toggle LED
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rTxtBx_COM.Clear();
        }

        // Callback Handler for richTextBox_uart
        // https://stackoverflow.com/questions/10775367/cross-thread-operation-not-valid-control-textbox1-accessed-from-a-thread-othe
        delegate void SetTextUartCallback(string text);
        private void SetTextUart(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.rTxtBx_COM.InvokeRequired)
            {
                SetTextUartCallback d = new SetTextUartCallback(SetTextUart);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.rTxtBx_COM.AppendText(text);
            }
        }


        // Callback Handler for txtBx_value1
        delegate void SetText1_Callback(string text);
        private void SetText1(string text)
        {
            if (this.txtBx_value1.InvokeRequired)
            {
                SetText1_Callback d = new SetText1_Callback(SetText1);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtBx_value1.Text = text;
            }
        }


        private string[] splitMessage(string text)
        {
            // https://docs.microsoft.com/vi-vn/dotnet/csharp/how-to/parse-strings-using-split
            // https://docs.microsoft.com/en-us/dotnet/api/system.stringsplitoptions?view=net-5.0#code-try-2
            //string text = "one\ttwo three:four,five six seven";
            char[] delimiterChars = { ' ', ',', '.', ':', '\t', '\r', '\n',  };
            string[] words = text.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);  // Split a string delimited by characters and return all non-empty elements.
            //System.Console.WriteLine($"DEBUG: {words.Length} words in text:");
            //foreach (var word in words)
            //{
            //    System.Console.WriteLine($"DEBUG: <{word}>");
            //}

            return words;
        }
    }
}
