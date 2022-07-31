using GuptaKirana.Models;
using System.Collections.Generic;

namespace GuptaKirana.Repository.Contracts
{
    public interface IProductRepository
    {
        List<ProductDTO> GetProductList();
    }
}
