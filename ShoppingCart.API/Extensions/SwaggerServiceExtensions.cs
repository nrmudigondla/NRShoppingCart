using Microsoft.OpenApi.Models;

namespace ShoppingCart.API.Extensions
{
    public static class SwaggerServiceExtensions
    {
        public static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(s => {
                s.SwaggerDoc("v1", new OpenApiInfo { Title = "NR Shopping Cart API", Version = "v1" });
            });

            return services;
        }
    }
}
