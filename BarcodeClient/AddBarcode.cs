using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarcodeClient
{
    
    public partial class AddBarcode : Form
    {
        public bool is_listening = false;
        private string token="";
        public AddBarcode(string token)
        {
            this.token = token;
            if(token.Trim() == "")
            {
                this.Dispose();
                return;
            }
            
            InitializeComponent();
        }

        private void AddBarcode_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {// txt_details.Text.Trim() == "" ||
            if (txt_name.Text.Trim() == "" || txt_id.Text.Trim() == "" || txt_code.Text.Trim() == "" || txt_user_id.Text.Trim() == "" )
            {
                MessageBox.Show("please fill all the fields");
                return;
            }    
            HttpWebRequest webRequest;
            //Alhessan use String.Format
            string requestParams = "{" +
                "\"id\": \"" + txt_id.Text.Trim() + "\"," +
                "\"name\": \"" + txt_name.Text.Trim() + "\"," +
                 (txt_details.Text.Trim() == "" ? "" : "\"details\": \"" + txt_details.Text.Trim() + "\",") +
                "\"code\": " + int.Parse(txt_code.Text) + " ," +
                "\"userId\": 0" + //int.Parse(txt_user_id.Text) +
                " }";
            

        webRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/api/barcodes");

            webRequest.Method = "POST";
            webRequest.ContentType = "application/json";
            webRequest.Headers.Add("Authorization", "Bearer " + token);


            byte[] byteArray = Encoding.UTF8.GetBytes(requestParams);
            webRequest.ContentLength = byteArray.Length;
            using (Stream requestStream = webRequest.GetRequestStream())
            {
                requestStream.Write(byteArray, 0, byteArray.Length);
            }

            // Get the response.
            using (WebResponse response = webRequest.GetResponse())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader rdr = new StreamReader(responseStream, Encoding.UTF8);
                    string Json = rdr.ReadToEnd(); // response from server
                    if (Json.Trim() != "")
                    {
                        MessageBox.Show(Json);
                        this.Close();
                    }
                   /* int found = Json.IndexOf(": ");
                    token = Json.Substring(found + 2);*/
                }
            }
            /*if (token.Trim() != "")
            {
                MessageBox.Show(token);
                this.is_verified = true;
                this.Close();
            }*/

        }

        private void txt_code_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        SerialPort port = new SerialPort();
        private void btn_serial_port_Click(object sender, EventArgs e)
        {
            if(is_listening)
            {
                StopPortListening();
                btn_serial_port.Text = "Read From Serial";
                is_listening = false;
                return;
            }
            port = new SerialPort();
            port.DataReceived += new SerialDataReceivedEventHandler(portTriggerAvail);
            port.BaudRate = 4800; // baud rate 9600
            port.Parity = Parity.Even;
            port.DataBits = 8;
            port.ParityReplace = 63;
            port.ReadBufferSize = 4096;
            port.PortName = "COM1";
            port.WriteTimeout = -1;
            port.ReadTimeout = -1;
            port.ReceivedBytesThreshold = 1;
            port.WriteBufferSize = 2048;
            port.DiscardNull = false;
            port.DtrEnable = false;
            port.RtsEnable = false;
            port.StopBits = StopBits.One;

            //port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            port.Open();
            btn_serial_port.Text = "Stop Listening ...";
            is_listening = true;
        }

        public void portTriggerAvail(object sender, SerialDataReceivedEventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("log.log", true))
            {
                byte current = 0;
                List<byte> byteList = new List<byte>();
                while (true)
                {
                    current = (byte)port.ReadByte();
                    byteList.Add(current);
                    if (current == 13)
                    {
                        port.DiscardInBuffer();
                        port.DiscardOutBuffer();
                        break;
                    }
                }

                sw.Write(Encoding.ASCII.GetString(byteList.ToArray()));
                //txt_id.Text += Encoding.ASCII.GetString(byteList.ToArray());
                SetText(Encoding.ASCII.GetString(byteList.ToArray()));
                //SetText("------------");
                //SetText(Environment.NewLine);
            }
        }

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            if (this.txt_id.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txt_id.Text += text;
            }
        }

        private void AddBarcode_FormClosed(object sender, FormClosedEventArgs e)
        {
            StopPortListening();
        }
        private void StopPortListening()
        {
            port.Close();
            port.Dispose();
        }
    }

    
}
