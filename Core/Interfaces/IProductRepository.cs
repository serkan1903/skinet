using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductIdAsync(int id);

        Task<IReadOnlyList<Product>> GetProductsAsync();
        Task<IReadOnlyList<ProductBrand>> GetProductsBrandAsync();
        Task<IReadOnlyList<ProductType>> GetProductsTypeAsync();
    }
}