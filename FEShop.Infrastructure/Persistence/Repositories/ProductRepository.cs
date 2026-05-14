using FEShop.Domain.Entities;
using FEShop.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FEShop.Infrastructure.Persistence.Repositories;

public class ProductRepository(FEShopDbContext context) : IProductRepository
{
    public async Task<int> CreateAsync(Product product, CancellationToken ct)
    {
        await context.Products.AddAsync(product, ct);
        await context.SaveChangesAsync(ct);
        return product.Id;
    }

    public async Task<Product?> GetByIdAsync(int id, CancellationToken ct) =>
        await context.Products.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id, ct);

    public async Task<IEnumerable<Product>> GetAllAsync(CancellationToken ct) =>
        await context.Products.AsNoTracking().ToListAsync(ct);

    public async Task<bool> DeleteAsync(int id, CancellationToken ct)
    {
        var affectedRows = await context.Products.Where(p => p.Id == id).ExecuteDeleteAsync(ct);
        return affectedRows > 0;
    }

    public async Task<bool> UpdateAsync(int id, string? name, string? description, decimal? price, CancellationToken ct)
    {
        var affectedRows = await context.Products
            .Where(p => p.Id == id)
            .ExecuteUpdateAsync(setter => setter
                    .SetProperty(p => p.Name, old => name ?? old.Name)
                    .SetProperty(p => p.Description, old => description ?? old.Description)
                    .SetProperty(p => p.Price, old => price ?? old.Price),
                ct);
        return affectedRows > 0;
    }
}