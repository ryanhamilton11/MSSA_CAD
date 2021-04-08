using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public interface IProductRepository
    {
        //CREATE
        Product Create(Product product);

        //READ
        public IQueryable<Product> GetAllProducts();
        public Product GetProductById(int productId);
        public IQueryable<Product> GetProductsByKeyword(string keyword);

        //UPDATE
        public Product UpdateProduct(Product product);

        //DELETE
        public bool DeleteProduct(int id);
    }
}
