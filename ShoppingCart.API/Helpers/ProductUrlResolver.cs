using AutoMapper;
using ShoppingCart.API.DTOs;
using ShoppingCart.Core.Entities;

namespace ShoppingCart.API.Helpers
{
    public class ProductUrlResolver : IValueResolver<Product, ProductToReturnDTO, string>
    {
        private readonly IConfiguration _configuration;

        public ProductUrlResolver(IConfiguration configuration) {
            this._configuration = configuration;
        }
        public string Resolve(Product source, ProductToReturnDTO destination, string destMember, 
            ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.PictureUrl))
            {
                return _configuration["ApiUrl"] + source.PictureUrl;
            }
            return null;
        }
    }
}
