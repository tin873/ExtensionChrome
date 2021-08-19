using Microsoft.AspNetCore.Mvc;
using PCS.Extension.Data.EF;
using PCS.Extension.Data.Entities;
using PCS.Extension.Data.Repositories;
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
        private readonly IResponseDataRepository _reponseDataRepository;
        private readonly ExtensionContext _extensionContext;
        public GetExchangeRateController(IResponseDataRepository reponseDataRepository, ExtensionContext extensionContext)
        {
            _reponseDataRepository = reponseDataRepository;
            _extensionContext = extensionContext;
        }
        [HttpGet]
        public async Task<List<Currency>> Get()
        {
            GetExchangeVietcombank temp = new GetExchangeVietcombank();
            var result = temp.GetExchange().Result;
            return result;
        }
        [HttpPost]
        public async Task<List<Currency>> Post()
        {
            DeserializeJsonCurrency deserialize = new DeserializeJsonCurrency();
            var outPut = deserialize.DeserializeJson().Result;
            foreach (var item in outPut)
            {
                Currency currency = new Currency()
                {
                    CurrencyCode = item.CurrencyCode,
                    CurrencyName = item.CurrencyName,
                    ExchangeRate = item.ExchangeRate,
                    GetDateTime = item.GetDateTime,
                    Id = item.Id
                };
                _reponseDataRepository.InsertCurrency(currency);
            }
            _reponseDataRepository.Save();
            return outPut;
        }
    }
}