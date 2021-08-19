using PCS.Extension.Data.EF;
using PCS.Extension.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PCS.Extension.Data.ModelEx;

namespace PCS.Extension.Data.Repositories
{
    public class ResponseDataRepository : IResponseDataRepository
    {
        private readonly ExtensionContext _extensionContext;
        public ResponseDataRepository(ExtensionContext amazonExtraContext)
        {
            _extensionContext = amazonExtraContext;
        }
        public void Delete(int id)
        {
            ResponseData reponse = _extensionContext.ReponseDataDbSet.Find(id);
            _extensionContext.ReponseDataDbSet.Remove(reponse);
        }

        public IEnumerable<NewResponseData> GetAll(string username)
        {
            var lstRes = from x in _extensionContext.ReponseDataDbSet
                         join y in _extensionContext.SourcePages on x.IdPage equals y.Id
                         join z in _extensionContext.Currencies on x.IdCurrency equals z.Id
                         where x.UserName == username
                         select new NewResponseData
                         {
                             Availability = x.Availability,
                             CurrencyCode = z.CurrencyCode,
                             Status = x.Status,
                             GetDate = x.GetDate,
                             PageName = y.PageName,
                             Price = x.Price,
                             ProductImageSrc = x.ProductImageSrc,
                             ProductTitle = x.ProductTitle,
                             Url = x.Url,
                             UserName = username
                         };



            return lstRes.ToList();
        }

        public ResponseData GetById(int id)
        {
            return _extensionContext.ReponseDataDbSet.Find(id);
        }
        public int Insert(ResponseData response)
        {
            ResponseData newResponseData = new ResponseData
            {
                ProductTitle = response.ProductTitle,
                Price = response.Price,
                ProductImageSrc = response.ProductImageSrc,
                Availability = response.Availability,
                GetDate = response.GetDate,
                Url = response.Url,
                IdPage = response.IdPage,
                Status = CommanConstant.Contants.PENDING,
                IdCurrency = response.IdCurrency,
                UserName = response.UserName
            };
            _extensionContext.Add(newResponseData);
            return newResponseData.Id;
        }

        public void Save()
        {
            _extensionContext.SaveChanges();
        }

        public void Update(ResponseData reponseData)
        {
            _extensionContext.Entry(reponseData).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
        public int InsertCurrency(Currency x)
        {
            Currency newCurrency = new Currency
            {
                CurrencyCode = x.CurrencyCode,
                CurrencyName = x.CurrencyName,
                ExchangeRate = x.ExchangeRate,
                GetDateTime = x.GetDateTime

            };
            _extensionContext.Add(newCurrency);

            return newCurrency.Id;
        }
    }
}