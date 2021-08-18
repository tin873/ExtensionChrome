using PCS.Extension.Data.EF;
using PCS.Extension.Data.Entities;
using PCS.Extension.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PCS.Extension.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly IResponseDataRepository _reponseDataRepository;
        private readonly ExtensionContext _extensionContext;
        public ApiController(IResponseDataRepository reponseDataRepository, ExtensionContext extensionContext)
        {
            _reponseDataRepository = reponseDataRepository;
            _extensionContext = extensionContext;
        }
        //[Route("listall")]
        //[HttpPost]
        //public IEnumerable<ResponseData> ListAll()
        //{
        //    return _reponseDataRepository.GetAll("haideptrai");
        //}
        // POST api/<AmazonApiController>

        [HttpPost]
        public async Task<ActionResult> Post(ResponseData reponseData)
        {

            ResponseData response = new ResponseData()
            {
                ProductTitle = reponseData.ProductTitle,
                Price = reponseData.Price,
                Availability = reponseData.Availability,
                ProductImageSrc = reponseData.ProductImageSrc,
                Url = reponseData.Url,
                GetDate = DateTime.Now,
                Status = Data.CommanConstant.Contants.PENDING,
                IdPage = reponseData.IdPage,
                IdCurrency = reponseData.IdCurrency,
                UserName = "haideptrai"
            };
            Console.WriteLine(response.ProductTitle);
            Console.WriteLine(response.Price);
            Console.WriteLine(response.Availability);
            Console.WriteLine(response.ProductImageSrc);
            Console.WriteLine(response.Url);
            Console.WriteLine(response.GetDate);
            Console.WriteLine(response.IdPage);


            _reponseDataRepository.Insert(response);
            _reponseDataRepository.Save();

            return Ok(response);
        }
    }
}
