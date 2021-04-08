using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class FakeProductRespository : IProductRepository
    {


        //FIELDS & PROPERTIES


        //CONSTRUCTORS


        //METHODS
        public IQueryable<Product> GetAllProducts()
        {
            Product[] products = new Product[3];

            products[0] = new Product
            {
                Name = "Football",
                Description = "Genuine Pigskin",
                Price = 25,
                Category = "Team Sports"
            };

            products[1] = new Product
            {
                Name = "Surf Board",
                Price = 179
            };

            products[2] = new Product
            {
                Name = "Running Shoes",
                Price = 95
            };

            return products.AsQueryable<Product>();
        }

        public Product GetProductById(int productId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Product> GetProductsByKeyword(string keyword)
        {
            throw new NotImplementedException();
        }

        public Product UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Create(Product product)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }
    }
}
