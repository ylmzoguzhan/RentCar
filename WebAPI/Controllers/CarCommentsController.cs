using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarCommentsController : ControllerBase
    {
        ICarCommentService _carCommentService;
        public CarCommentsController(ICarCommentService carCommentService)
        {
            _carCommentService = carCommentService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carCommentService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(CarComment carComment)
        {
            var result = _carCommentService.Add(carComment);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
