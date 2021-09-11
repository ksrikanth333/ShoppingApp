using Products.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Products.Data
{
    public interface IProductList
    {
        IEnumerable<Product> GetAll();
    }

    public class ProductListData : IProductList
    {
        readonly List<Product> Products;
        public ProductListData()
        {
            Products = new List<Product>() 
            { 
            new Product{Id=1,PoductName="LapTop",ProductCategory=ProductCategory.Electronics,ProductPrice=22000.25},
            new Product{Id=2,PoductName="Shirt",ProductCategory=ProductCategory.Cloths,ProductPrice=500.0},
            new Product{Id=3,PoductName="Sofa",ProductCategory=ProductCategory.Furniture,ProductPrice=25000.0},


            };
        }
        public IEnumerable<Product> GetAll()
        {
            return from prod in Products orderby prod.Id ascending select prod;
        }
    }
}
