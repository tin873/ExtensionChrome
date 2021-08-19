using Microsoft.AspNetCore.Mvc;
using PCS.Extension.Data.Entities;
using PCS.Extension.Services;

namespace PCS.Extension.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CurrencyController : ExtensionBaseController<Currency>
    {
        public CurrencyController(IBaseService<Currency> baseService) : base(baseService)
        {
        }
    }
}
