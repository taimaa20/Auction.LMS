using Auction.LMS.CORE.Data;
using Auction.LMS.CORE.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auction.LMS.API.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;
        public CategoryController(ICategoryService _categoryService)
        {
            categoryService = _categoryService;
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Category>), StatusCodes.Status200OK)]
        public List<Category> GetAllCategory()
        {
            return categoryService.GetAllCategory();
        }
        [HttpPost]
        public bool InsertCategory([FromBody] Category category)
        {
            return categoryService.InsertCategory(category);
        }
        [HttpPut]
        public bool UpdateCategory(Category category)
        {
            return categoryService.UpdateCategory(category);
        }
        [HttpDelete("delete/{id}")]
        public bool DeleteCategory(int id)
        {
            return categoryService.DeleteCategory(id);
        }
        [HttpGet]
        [Route("getCategorybyid/{id}")]
        public Category GetAllCategoryId(int id)
        {
            return categoryService.GetAllCategoryId(id);
        }
        [HttpPost]
        public List<Category> SearchByCategoryName([FromBody] Category category)
        {
            return categoryService.SearchByCategoryName(category);
        }
    }
}
