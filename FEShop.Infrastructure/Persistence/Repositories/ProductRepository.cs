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
        await context.Products.FirstOrDefaultAsync(p => p.Id == id, ct);

    public async Task<IEnumerable<Product>> GetAllAsync(CancellationToken ct) =>
        await context.Products.AsNoTracking().ToListAsync(ct);
}