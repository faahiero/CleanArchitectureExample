using CleanArchitecture.Core.Entities;

namespace CleanArchitecture.Core.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Product GetById(int id);
        void Add(Product product);
    }
}