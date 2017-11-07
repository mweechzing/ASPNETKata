using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNETKata.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public int Reload { get; set; }
        public double Profits { get; set; }
        public DateTime StartDateTime { get; set; }
        public int ProductDev { get; set; }
    }
}