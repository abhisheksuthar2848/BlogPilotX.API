using BlogPilotX.API.Repository.Interface;
using BlogPilotX.API.Model.Domain;
using BlogPilotX.API.Data;

namespace BlogPilotX.API.Repository.Implementation
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppliactionDbContext context;

        public CategoryRepository(AppliactionDbContext context)
        {
            this.context = context;
        }


        public async Task<Category> CreateAsync(Category category)
        {
            await context.AddAsync(category);
            await context.SaveChangesAsync();
            return category;
        }
    }
}
