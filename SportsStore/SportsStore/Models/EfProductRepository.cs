using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class EfProductRepository : IProductRepository
    {
        //FIELDS & PROPERTIES
        private AppDbContext _context;


        //CONSTRUCTORS
        public EfProductRepository(AppDbContext context)
        {
            _context = context;
        }

        //METHODS
        public Product Create(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }
        public bool DeleteProduct(int id)
        {
            Product productToDelete = _context.Products.Find(id);
            if (productToDelete == null)
            {
                return false;
            }
            _context.Products.Remove(productToDelete);
            _context.SaveChanges();
            return true;
        }


        public IQueryable<Product> GetAllProducts() => _context.Products;

        public Product GetProductById(int productId)
        {
            return _context.Products
               .Where(p => p.ProductId == productId)
               .FirstOrDefault();
        }

        public IQueryable<Product> GetProductsByKeyword(string keyword)
        {
            return _context.Products
               .Where(p => p.Name.Contains(keyword));
        }

        public Product UpdateProduct(Product product)
        {
            Product productToUpdate = _context.Products.SingleOrDefault(p => p.ProductId == product.ProductId);
            if (productToUpdate != null)
            {
                productToUpdate.Category = product.Category;
                productToUpdate.Description = product.Description;
                productToUpdate.Name = product.Name;
                productToUpdate.Price = product.Price;
                _context.SaveChanges();
            }
            return productToUpdate;
        }


    }
}
