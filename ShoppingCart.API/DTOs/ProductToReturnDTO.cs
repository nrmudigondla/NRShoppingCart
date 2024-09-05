using ShoppingCart.Core.Entities;

namespace ShoppingCart.API.DTOs
{
    public class ProductToReturnDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string PictureUrl { get; set; } = string.Empty;
        public string ProductType { get; set; } = string.Empty;
        public string ProductBrand { get; set; } = string.Empty;
    }
}
