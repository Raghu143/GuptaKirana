using GuptaKirana.Models;
using GuptaKirana.Repository;
using GuptaKirana.Repository.Contracts;
using GuptaKirana.Services.Contracts;
using System;
using System.Collections.Generic;

namespace GuptaKirana.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }
        public List<ProductDTO> GetProductList()
        {
            return _repository.GetProductList();
        }
    }
}
