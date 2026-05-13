using FEShop.Domain.Entities;

namespace FEShop.Domain.Interfaces;

public interface IProductRepository
{
    Task<int> CreateAsync(Product product, CancellationToken ct);
    Task<Product?> GetByIdAsync(int id, CancellationToken ct);
    Task<IEnumerable<Product>> GetAllAsync(CancellationToken ct);
}