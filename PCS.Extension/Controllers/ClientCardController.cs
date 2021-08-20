using Microsoft.AspNetCore.Mvc;
using PCS.Extension.Data.Entities;
using PCS.Extension.Services.interfaces;

namespace PCS.Extension.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ClientCardController : ControllerBase
    {
        private IClientCardService _clientCardService;
        public ClientCardController(IClientCardService clientCardService)
        {
            _clientCardService = clientCardService;
        }
        [HttpPost]
        public IActionResult AddClient(ClientCard entity)
        {
            entity.CreateDate = System.DateTime.Now;
            var result = _clientCardService.InsertClient(entity);
            return Ok(result);
        }
    }
}
