using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_App.Models
{
    public class ShoppingCartItem
    {
        [JsonProperty("name")]
        public string ItemName{ get; set; }
        public double Price { get; set; }
        [JsonProperty("image")]
        public string icon { get; set; }
        public string Description { get; set; }

        public int Code { get; set; }


    }
}
