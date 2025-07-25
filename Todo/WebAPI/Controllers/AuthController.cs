using Business.Abstract;
using Core.Utilities.FileOperation;
using Core.Utilities.Security.JWT;
using Entities.DTOs.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    //[Route("api/[controller]")]
    [Route("users")]
    [ApiController]
    public class AuthController : BaseController
    {
        private IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Login(UserForLoginDto userForLoginDto)
        {
            var result = _authService.Login(userForLoginDto);
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[Authorize(Roles="Admin")]
        [HttpPost]
        public IActionResult Add(UserAddDto userAddDto)
        {
            var result = _authService.Add(userAddDto);
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[Authorize(Roles="Admin")]
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _authService.GetUserList();
            if (result.Success) {
                return Ok(result);
            }
            return NotFound(result);   
        }

        [Authorize]
        [HttpGet("{userId}")]
        public IActionResult GetById(int userId)
        {
            var result = _authService.GetById(userId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
