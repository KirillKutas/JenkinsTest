using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompareController : ControllerBase
    {
        private readonly ICompareService _service;

        public CompareController(ICompareService service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("Compare")]
        public bool Compare([FromQuery] int a, int b)
        {
            return _service.Compare(a, b);
        }
    }
}
