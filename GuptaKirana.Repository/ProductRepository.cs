using GuptaKirana.EFCore.DBContext;
using GuptaKirana.Models;
using GuptaKirana.Repository.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace GuptaKirana.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly GuptaKiranaDBContext _dBContext;
        public ProductRepository(GuptaKiranaDBContext dBContext)
        {
            _dBContext = dBContext;
        }
        public List<ProductDTO> GetProductList()
        {
            var productList = _dBContext.Products.Select(x => new ProductDTO
            {
                ProductID = x.ProductID,
                ProductName = x.ProductName,
                Price = x.Price,
                ProductType = x.ProductType.ToString(),
                ProductCatelogue = x.ProductCatelogue
            }).ToList();

            return productList;
        }
    }
}
