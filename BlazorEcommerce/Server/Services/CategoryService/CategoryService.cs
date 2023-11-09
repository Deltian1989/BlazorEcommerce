namespace BlazorEcommerce.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly BEContext _dbContext;

        public CategoryService(BEContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ServiceResponse<List<Category>>> GetCategories()
        {
            var categories = await _dbContext.Categories.ToListAsync();

            return new ServiceResponse<List<Category>>
            {
                Data = categories
            };
        }
    }
}
