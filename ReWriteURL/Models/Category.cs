using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReWriteURL.Models
{
    public class Category
    {
        public Category(string category_code, string category_name, int status)
        {
            this.category_code = category_code;
            this.category_name = category_name;
            this.status = status;
        }

        public Category()
        {
        }

        [Key]
        public string category_code { get; set; }
        public string category_name { get; set; }
        public int status { get; set; }
    }
}