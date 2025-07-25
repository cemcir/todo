using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs.Categories;
using Entities.DTOs.Customers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    /*
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [Authorize]
        [HttpGet("get/{categoryId:long}")]
        public IActionResult Get(long categoryId)
        {
            var result=_categoryService.GetById(categoryId);
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [Authorize]
        [HttpPost("add")]
        public IActionResult Add(CategoryAddDto categoryAddDto)
        {
            var result=_categoryService.Add(categoryAddDto);
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [Authorize]
        [HttpPost("delete")]
        public IActionResult Delete(CategoryDeleteDto categoryDeleteDto)
        {
            var result = _categoryService.Delete(categoryDeleteDto);
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [Authorize]
        [HttpPost("update")]
        public IActionResult Update(CategoryUpdateDto categoryUpdateDto)
        {
            var result=_categoryService.Update(categoryUpdateDto);
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [Authorize]
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _categoryService.GetAll();
            if (result.Success) {
                return Ok(result);
            }
            return NotFound(result);
        }

    }
    */
}
