using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Core
{
    public class Product
    {
        public int Id { get; set; }
        public string PoductName { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public double ProductPrice { get; set; }
    }
}
