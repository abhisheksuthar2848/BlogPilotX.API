using BlogPilotX.API.Model.Domain;
using BlogPilotX.API.Model.DTO;
using BlogPilotX.API.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogPilotX.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoriesController(ICategoryRepository category)
        {
            this.categoryRepository = category;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryRequestDto request)
        {
            var category = new Category
            {
                Name = request.Name,
                UrlHandle = request.UrlHandle
            };
            await categoryRepository.CreateAsync(category);

            var responce = new ResponceCategoryDto
            {
                Id=category.Id,
                Name = request.Name,
                UrlHandle = request.UrlHandle
            };

            return Ok(responce);


        }
    }
}
