using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace NEOPicTest
{
    public partial class Form1 : Form
    {
        //USB stats
        int USBBytesRead = 0;

        //Bluetooth stats
        int BluetoothBytesRead = 0;

        //USB Connect
        SerialPort COM;
        bool usbConnected = false;
        Thread usbReadThread;

        public Form1()
        {
            InitializeComponent();

            //USB Connect
            comboBoxParity.DataSource = Enum.GetValues(typeof(Parity));
            comboBoxParity.SelectedIndex = 0;
            comboBoxStopBits.DataSource = Enum.GetValues(typeof(StopBits));
            comboBoxStopBits.SelectedIndex = 1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (chkBoxClearUSB.Checked)
            {
                richTextBoxUSB.Clear();
                richTextBoxUSB.SelectionStart = 0;
                richTextBoxUSB.ScrollToCaret();

                USBBytesRead = 0;
            }

            if (chkBoxClearBluetooth.Checked)
            {
                richTextBoxBluetooth.Clear();
                richTextBoxBluetooth.SelectionStart = 0;
                richTextBoxBluetooth.ScrollToCaret();

                BluetoothBytesRead = 0;
            }
        }

        private void ToggleUSBConnect()
        {
            if (!usbConnected)
            {
                COM = new SerialPort(
                    txtBoxPortName.Text,
                    int.Parse(txtBoxBaudRate.Text),
                    (Parity)Enum.Parse(typeof(Parity), comboBoxParity.Text),
                    int.Parse(txtBoxDataBits.Text),
                    (StopBits)Enum.Parse(typeof(StopBits), comboBoxStopBits.Text)
                    );
                COM.ReadTimeout = int.Parse(txtBoxReadTimeout.Text);
                COM.WriteTimeout = int.Parse(txtBoxWriteTimeout.Text);

                usbReadThread = new Thread(USBRead);

                COM.Open();
                usbReadThread.Start();

                btnUSBConnect.Text = "Disconnect";
                usbConnected = true;
            }
            else
            {
                usbConnected = false;
                btnUSBConnect.Text = "Connect";

                usbReadThread.Join();
                COM.Close();
            }
        }

        private void btnUSBConnect_Click(object sender, EventArgs e)
        {
            ToggleUSBConnect();
        }

        private void USBRead()
        {
            byte[] buffer = new byte[25];
            int bytesRead;

            while (usbConnected)
            {
                try
                {
                    bytesRead = COM.Read(buffer, 0, buffer.Length);
                    USBBytesRead += bytesRead;
                    OverwriteText(USBBytesRead.ToString(), lblUSBBytesRead);

                    for (int i = 0; i < bytesRead; i++)
                    {
                        AppendText("" + Convert.ToChar(buffer[i]), richTextBoxUSB);
                    }
                }
                catch (TimeoutException) { }
            }
        }

        public void AppendText(string value, RichTextBox rtb)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string, RichTextBox>(AppendText), new object[] { value, rtb });
                return;
            }

            rtb.Text += value;
            rtb.SelectionStart = rtb.Text.Length;
            rtb.ScrollToCaret();
        }

        public void OverwriteText(string value, Label lbl)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string, Label>(OverwriteText), new object[] { value, lbl });
                return;
            }

            lbl.Text = value;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (usbConnected)
            {
                ToggleUSBConnect();
            }
        }
    }
}
