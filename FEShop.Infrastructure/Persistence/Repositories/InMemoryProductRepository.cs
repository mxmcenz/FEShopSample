using FEShop.Domain.Entities;
using FEShop.Domain.Interfaces;

namespace FEShop.Infrastructure.Persistence.Repositories;

public class InMemoryProductRepository : IProductRepository
{
    private static readonly List<Product> Products = new();
    private static int _currentId = 1;
    
    public async Task<int> CreateAsync(Product product, CancellationToken ct)
    {
        product.Id = _currentId++;
        Products.Add(product);

        await Task.CompletedTask;
        return product.Id;
    }

    public async Task<Product?> GetByIdAsync(int id, CancellationToken ct)
    {
        var product = Products.FirstOrDefault(p => p.Id == id);
        return await Task.FromResult(product);
    }

    public async Task<IEnumerable<Product>> GetAllAsync(CancellationToken ct)
    {
        return await Task.FromResult(Products);
    }
}