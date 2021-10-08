using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarcodeClient
{
    public partial class Form1 : Form
    {
        public string token="";
        public Form1()
        {
            Login login_form = new Login();
            login_form.ShowDialog();
            if(!login_form.is_verified)
            {
                this.Dispose();

            }
            else
            {
                token = login_form.token;
                InitializeComponent();
            }
            
        }

        private void btn_add_barcode_Click(object sender, EventArgs e)
        {
            AddBarcode addBarcodeForm = new AddBarcode(token);
            addBarcodeForm.Show();
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            this.GetBarcodes("http://localhost:8080/api/barcodes/my");
        }

        //private string URL = "http://localhost:8080/api/barcodes/my";
       

        public async void GetBarcodes(string URL)
        {
            if (token.Trim() == "")
                return;
            using (var Client = new HttpClient())
            {
                Client.BaseAddress = new Uri(URL);
                Client.DefaultRequestHeaders.Accept.Clear();
                Client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue( "Bearer" , token);
                Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage responce = await Client.GetAsync("");
                if (responce.IsSuccessStatusCode)
                {
                    var Json = await responce.Content.ReadAsStringAsync();
                    var Items = JsonConvert.DeserializeObject<List<Barcode>>(Json);

                    // now use you have the date on Items !
                    dgv_barcodes.Rows.Clear();
                    foreach (Barcode item in Items)
                    {
                        ArrayList row = new ArrayList();
                        row.Add(item.Id);
                        row.Add(item.Name);
                        row.Add(item.Details);
                        row.Add(item.Code);
                        row.Add(item.userID);

                        dgv_barcodes.Rows.Add(row.ToArray());
                    }
                    

                    dgv_barcodes.Refresh();
                    //return Items;
                }
                else
                {
                    // deal with error or here ...
                    //return null;
                }
            }

        }

       /* private static async Task<Barcode> RetriveDataWithGetAsync()
        {
            using (var Client = new HttpClient())
            {
                
                HttpResponseMessage response = await Client.GetAsync("PUT URL HERE");
                if (response.IsSuccessStatusCode)
                {
                    var str = await response.Content.ReadAsStringAsync();
                    var t = JsonConvert.DeserializeObject<Barcode>(str);
                    return t;
                }
                
            }

            return null;
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {
            this.GetBarcodes("http://localhost:8080/api/barcodes/my");
        }

        private void btn_get_all_Click(object sender, EventArgs e)
        {
            this.GetBarcodes("http://localhost:8080/api/barcodes");
        }
    }
}
