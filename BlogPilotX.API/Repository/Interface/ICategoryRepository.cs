using BlogPilotX.API.Model.Domain;

namespace BlogPilotX.API.Repository.Interface
{
    public interface ICategoryRepository
    {
       public Task<Category> CreateAsync(Category category);
    }
}
