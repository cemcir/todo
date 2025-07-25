using Business.Abstract;
using Entities.DTOs.Todos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("tasks")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoService _todoService;

        public TodosController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [Authorize]
        [HttpPost]
        public IActionResult Add(TodoAddDto todoAddDto)
        {
            var result = _todoService.Add(todoAddDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [Authorize]
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _todoService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [Authorize]
        [HttpGet("{taskId}")]
        public IActionResult Get(int taskId)
        {
            var result = _todoService.Get(taskId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [Authorize]
        [HttpPut("{taskId}")]
        public IActionResult Update(int taskId, [FromBody] TodoUpdateDto todoUpdateDto)
        {
            var result = _todoService.Update(taskId,todoUpdateDto);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [Authorize]
        [HttpDelete("{taskId}")]
        public IActionResult Delete(int taskId)
        {
            var result = _todoService.Delete(taskId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
