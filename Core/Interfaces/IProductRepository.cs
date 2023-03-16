using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
         Task<Product>GetProductByIdAsync(int id) ;
         Task<IReadOnlyList<Product>>GetProductsAsync() ;
         Task<IReadOnlyList<ProductBrand>>GetProductBransdAsync() ;
         Task<IReadOnlyList<ProductType>>GetProductTypesAsync() ;
         
    }
}