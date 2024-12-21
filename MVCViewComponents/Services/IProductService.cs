namespace MVCViewComponents.Services;

public interface IProductService
{
    Task<List<Product>> GetTopProductsAsync(int count);
}
