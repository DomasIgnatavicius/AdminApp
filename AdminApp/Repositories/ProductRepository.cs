using AdminApp.Data;
using AdminApp.Models;
using AdminApp.Repositories.IRepositories;

namespace AdminApp.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ShopContext _db;
        public ProductRepository(ShopContext db) : base(db)
        {
            _db = db;
        }
        public Product Update(Product product)
        {
            product.UpdateDateTime = DateTime.Now;
            _db.Products.Update(product);
            _db.SaveChanges();
            return product;
        }
    }
}
