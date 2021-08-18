using Microsoft.AspNetCore.Mvc;
using PCS.Extension.Data.Entities;
using PCS.Extension.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PCS.Extension.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetExchangeRateController : ControllerBase
    {
        // GET: api/<GetExchangeRateController>
        [HttpGet]
        public async Task<List<Currency>> Get()
        {
            GetExchangeVietcombank temp = new GetExchangeVietcombank();
            var result = temp.GetExchange().Result;
            return result;
        }   
    }
}
