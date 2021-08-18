using PCS.Extension.Data.Entities;
using PCS.Extension.Data.ModelEx;
using System;
using System.Collections.Generic;
using System.Text;

namespace PCS.Extension.Data.Repositories
{
    public interface IResponseDataRepository
    {
        IEnumerable<NewResponseData> GetAll(string userName);
        ResponseData GetById(int ReponseData);
        int Insert(ResponseData reponseData);
        void Update(ResponseData reponseData);
        void Delete(int ReponseData);
        void Save();
    }
}
