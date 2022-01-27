using course1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace course1.Services
{
    interface IProductDataService
    {
        List<ProductModel> GetAllProducts();
        List<ProductModel> SearchProducts(string searchTearm);
        ProductModel GetProductById(int id);
        int Insert(ProductModel product);
        int Delete(ProductModel product);
        int Update(ProductModel product);
    }
}
