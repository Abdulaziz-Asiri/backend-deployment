using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Controllers;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sdaonsite_2_csharp_backend_teamwork.src.Services;

namespace sda_onsite_2_csharp_backend_teamwork.src.Controller
{
    public class CategoryController : CustomBaseController
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CategoryReadDto>> FindAll()
        {
            return Ok(_categoryService.FindAll());
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Authorize(Roles = "Admin")]
        public ActionResult<CategoryReadDto> CreateOne([FromBody] CategoryCreateDto category)
        {
            var createdCategory = _categoryService.CreateOne(category);
            if (createdCategory != null)
            {
                return CreatedAtAction(nameof(CreateOne), createdCategory);
            }
            return BadRequest();
        }

        [HttpGet("{categoryId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public ActionResult<CategoryReadDto?> FindOne(Guid categoryId)
        {
            var category = _categoryService.FindOne(categoryId);
            if (category != null)
            {
                return Ok(category);
            }
            return NotFound();
        }

        [HttpDelete("{categoryId}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [Authorize(Roles = "Admin")]

        public ActionResult< CategoryReadDto?> DeleteOne([FromRoute] Guid categoryId)
        {
            var deletedCategory = _categoryService.DeleteOne(categoryId);
            if (deletedCategory != null)
            {
                return Ok(deletedCategory);
            }
            return NotFound();
        }

        [HttpPatch("{categoryId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Authorize(Roles = "Admin")]

        public ActionResult<CategoryReadDto> UpdateOne(Guid categoryId, [FromBody] CategoryUpdateDto updatedCategory)
        {
            CategoryReadDto category = _categoryService.UpdateOne(categoryId, updatedCategory);
            return Accepted(category);
        }
    }

}
