using GuptaKirana.Models;
using GuptaKirana.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GuptaKirana.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : GuptaKiranaController
    {
        private readonly IProductService _service;
        
        public ProductController(IProductService service)
        {
            _service = service;
        }

          
        [HttpGet]
        [Route("products")]
        public ResponseDTO GetProductList()
        {
            try
            {
                List<ProductDTO> productList = _service.GetProductList();
                return GenerateSuccessResponse(productList);
            }
            catch (Exception ex)
            {
                return GenerateErrorResponse(ex);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public ResponseDTO GetProductById(int id)
        {
            try
            {
                ProductDTO product = _service.GetProductList().First(x => x.ProductID == id);
                return GenerateSuccessResponse(product);
            }
            catch (Exception ex)
            {
                return GenerateErrorResponse(ex);
            }
        }
    }
}
