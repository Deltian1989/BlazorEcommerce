namespace BlazorEcommerce.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly BEContext _dbContext;

        public ProductService(BEContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _dbContext.Products.ToListAsync()
            };

            return response;
        }
    }
}
