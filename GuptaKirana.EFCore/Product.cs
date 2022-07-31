using GuptaKirana.EFCore.Enums;
using System.ComponentModel.DataAnnotations;

namespace GuptaKirana.EFCore
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [MaxLength(1000)]
        public string ProductName { get; set; }
        public string ProductCatelogue { get; set; }
        public ProductType ProductType { get; set; }
        public double Price { get; set; }
    }
}
