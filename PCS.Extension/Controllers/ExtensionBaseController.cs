using Microsoft.AspNetCore.Mvc;
using PCS.Extension.Services;

namespace PCS.Extension.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ExtensionBaseController<Entity> : ControllerBase where Entity : class
    {
        protected readonly IBaseService<Entity> _baseService;

        public ExtensionBaseController(IBaseService<Entity> baseService)
        {
            _baseService = baseService;
        }

        [HttpGet("{id}")]
        public virtual IActionResult GetById(int Id)
        {
            var result = _baseService.GetById(Id);
            return Ok(result);
        }

        [HttpPost]
        public virtual IActionResult Post(Entity entity)
        {
            var result = _baseService.Insert(entity);
            return Ok(result);
        }
    }
}
