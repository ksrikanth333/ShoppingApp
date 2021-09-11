using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Products.Core;
using Products.Data;

namespace Shopping_App.Pages.Products
{
    public class ListModel : PageModel
    {
        public string Message { get; set; }
        private readonly IConfiguration config;
        private readonly IProductList products;
        public IEnumerable<Product> ProductList { get; set; }
        public ListModel(IConfiguration config,IProductList products)
        {
            this.config = config;
            this.products = products;
        }
        public void OnGet()
        {
            Message = config["Message"];
            ProductList = products.GetAll();
        }
    }
}
