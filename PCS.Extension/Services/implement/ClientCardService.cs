using PCS.Extension.Data.Entities;
using PCS.Extension.Data.Enum;
using PCS.Extension.Data.Repositories;
using PCS.Extension.Services.interfaces;
using System;

namespace PCS.Extension.Services.implement
{
    public class ClientCardService : BaseService<ClientCard>, IClientCardService
    {
        public ClientCardService(IBaseRepository<ClientCard> baseRepository) : base(baseRepository)
        {
        }

        public ServiceResult InsertClient(ClientCard entity)
        {
            try
            {
                var checkIsExits = _baseRepository.GetById(entity.ClientCardId);
                if(checkIsExits != null)
                {
                    _serviceResult.IsSuccess = false;
                    _serviceResult.UserMsg.Add("Client đã tồn tại.");
                    _serviceResult.ExtensionCode = ExtensionCode.NotValid;
                    _serviceResult.Data = null;
                    return _serviceResult;
                }   
                else
                {
                    var result = _baseRepository.Insert(entity);
                    _serviceResult.IsSuccess = true;
                    _serviceResult.UserMsg.Add("Thêm mới thành công.");
                    _serviceResult.ExtensionCode = ExtensionCode.Success;
                    _serviceResult.Data = result;
                    return _serviceResult;
                }    
            }
            catch (Exception)
            {
                _serviceResult.IsSuccess = false;
                _serviceResult.UserMsg.Add("Lỗi hệ thống!.");
                _serviceResult.ExtensionCode = ExtensionCode.Exeption;
                return _serviceResult;
            }
        }
    }
}
