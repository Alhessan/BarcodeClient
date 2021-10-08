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
    public partial class Login : Form
    {
        public bool is_verified = false;
        public string token = "";
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            HttpWebRequest webRequest;
            //Alhessan use String.Format
            string requestParams = "{ \"user_name\":\""+ txt_user_name.Text +"\", \"password\":\""+ txt_password.Text +"\" }" ; //format information you need to pass into that string ('info={ "EmployeeID": [ "1234567", "7654321" ], "Salary": true, "BonusPercentage": 10}');

            webRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/api/auth");
            
            webRequest.Method = "POST";
            webRequest.ContentType = "application/json";

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
                    int found = Json.IndexOf("\":\""); 
                    token = Json.Substring(found + 3, Json.Length - (found + 5));
                }
            }
            if (token.Trim() != "")
            {
                MessageBox.Show(token);
                this.is_verified = true;
                this.Close();
            }

        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                btn_login_Click(btn_login, e);
        }
    }
}
