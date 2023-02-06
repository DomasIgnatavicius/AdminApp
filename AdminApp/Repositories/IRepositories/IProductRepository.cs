using AdminApp.Models;

namespace AdminApp.Repositories.IRepositories
{
    public interface IProductRepository: IRepository<Product>
    {
        Product Update(Product product);
    }
}
