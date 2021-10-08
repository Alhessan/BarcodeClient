using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeClient
{
    class Barcode
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("details")]
        public string Details { get; set; }
        [JsonProperty("code")]
        public long Code { get; set; }
        [JsonProperty("user_id")]
        public string userID { get; set; }
    }
}
