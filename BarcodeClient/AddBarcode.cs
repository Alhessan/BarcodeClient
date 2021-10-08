using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarcodeClient
{
    public partial class AddBarcode : Form
    {
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
        {
            HttpWebRequest webRequest;
            //Alhessan use String.Format
            string requestParams = "{" +
                "\"id\": \"" + txt_id.Text + "\"," +
                "\"name\": \"" + txt_name.Text + "\"," +
                "\"details\": \"" + txt_details.Text + "\"," +
                "\"code\": " + int.Parse(txt_code.Text) + " ," +
                "\"userId\": " + int.Parse(txt_user_id.Text) + " }";
            

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
    }
}
