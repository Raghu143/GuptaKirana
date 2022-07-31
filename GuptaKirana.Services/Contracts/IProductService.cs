using GuptaKirana.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuptaKirana.Services.Contracts
{
    public interface IProductService
    {
        List<ProductDTO> GetProductList();
    }
}
