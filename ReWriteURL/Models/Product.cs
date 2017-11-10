using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReWriteURL.Models
{
    public class Product
    {
        public Product(string product_code, string product_name, string product_price)
        {
            this.product_code = product_code;
            this.product_name = product_name;
            this.product_price = product_price;
        }

        public Product()
        {
        }
        [Key]
        public string product_code { get; set; }
        public string product_name { get; set; }
        public string product_price { get; set; }
    }
}