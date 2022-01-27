using course1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace course1.Services
{
    public class HardCodedSampleRepository : IProductDataService
    {
        static List<ProductModel> productList = new List<ProductModel>();
        public int Delete(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> GetAllProducts()            
        {
            if (productList.Count == 0)
            {
                productList.Add(new ProductModel { ID = 1, Name = "Mouse Pad", Price = 5.99m, Description = "A Mouse Pad for a computer" });
                productList.Add(new ProductModel { ID = 2, Name = "Web Cam", Price = 45.50m, Description = "Desktop camrea" });
                productList.Add(new ProductModel { ID = 3, Name = "4TB Hard Drive", Price = 130.00m, Description = "Removable Hard Drive" });
                productList.Add(new ProductModel { ID = 4, Name = "Wireless Mouse", Price = 15.99m, Description = "Cordless Mouse for laptops" });
            }
            

            return productList;
        }

        public ProductModel GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> SearchProducts(string searchTearm)
        {
            throw new NotImplementedException();
        }

        public int Update(ProductModel product)
        {
            throw new NotImplementedException();
        }
    }
}
