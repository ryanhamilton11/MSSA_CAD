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
        
        //CREATE
        public Product Create(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        //READ
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

        public IQueryable<string> GetAllCategories()
        {
            IQueryable<string> categories = _context.Products
                                                    .Select(p => p.Category)
                                                    .Distinct();
            return categories;
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

        //UPDATE
        public Product UpdateProduct(Product p)
        {
            Product productToUpdate = _context.Products.Find(p.ProductId);
            if(productToUpdate != null)
            {
                productToUpdate.Category = p.Category;
                productToUpdate.Description = p.Description;
                productToUpdate.Name = p.Name;
                productToUpdate.Price = p.Price;
                _context.SaveChanges();
            }
            return productToUpdate;
        }


        //DELETE


    }
}
