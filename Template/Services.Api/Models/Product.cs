using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Services.Api.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}