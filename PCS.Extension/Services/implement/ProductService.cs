using PCS.Extension.Data.Entities;
using PCS.Extension.Data.Enum;
using PCS.Extension.Data.Repositories;
using PCS.Extension.Services.interfaces;
using System;

namespace PCS.Extension.Services.implement
{
    public class ProductService : BaseService<Products>, IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IBaseRepository<Products> baseRepository, IProductRepository productRepository) : base(baseRepository)
        {
            _productRepository = productRepository;
        }

        public ServiceResult GetProductsByIdClient(Guid clientId)
        {
            try
            {
                var result = _productRepository.GetProductsByIdClient(clientId);
                _serviceResult.IsSuccess = true;
                _serviceResult.UserMsg.Add("Lấy dữ liệu thành công.");
                _serviceResult.ExtensionCode = ExtensionCode.Success;
                _serviceResult.Data = result;
                return _serviceResult;
            }
            catch (System.Exception)
            {
                _serviceResult.IsSuccess = false;
                _serviceResult.UserMsg.Add("Lỗi hệ thống.");
                _serviceResult.ExtensionCode = ExtensionCode.Exeption;
                _serviceResult.Data = null;
                return _serviceResult;
            }
        }

        public ServiceResult InsertProducts(Products product)
        {
            try
            {
                var result = _baseRepository.Insert(product);
                _serviceResult.IsSuccess = true;
                _serviceResult.UserMsg.Add("Thêm mới thành công.");
                _serviceResult.ExtensionCode = ExtensionCode.Success;
                _serviceResult.Data = result;
                return _serviceResult;
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
