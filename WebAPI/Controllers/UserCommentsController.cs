using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserCommentsController : ControllerBase
    {
        IUserCommentService _userCommentService;
        public UserCommentsController(IUserCommentService userCommentService)
        {
            _userCommentService = userCommentService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _userCommentService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(UserComment userComment)
        {
            var result = _userCommentService.Add(userComment);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
