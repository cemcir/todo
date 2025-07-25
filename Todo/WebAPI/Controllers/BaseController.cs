using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected int userId => GetUserId();

        private int GetUserId()
        {
            if (int.TryParse(User.FindFirst("userId")?.Value, out int userId))
            {
                return userId;
            }
            return 0;
        }

       
    }
}
