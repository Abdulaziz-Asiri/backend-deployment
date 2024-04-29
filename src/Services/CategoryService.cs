
using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sda_onsite_2_csharp_backend_teamwork.src.Repositories;
using sdaonsite_2_csharp_backend_teamwork.src.Services;

namespace sda_onsite_2_csharp_backend_teamwork.src.Controller
{

    public class CategoryService : ICategoryService

    {

        private ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public Category CreateOne(Category category)
        {
            return _categoryRepository.CreateOne(category);
        }

        public List<Category> FindAll()
        {
            return _categoryRepository.FindAll();
        }

    }
}

//FindOne 
//DeleteOne
//UpdateOne