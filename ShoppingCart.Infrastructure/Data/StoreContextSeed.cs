using Microsoft.Extensions.Logging;
using ShoppingCart.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ShoppingCart.Infrastructure.Data
{
    public class StoreContextSeed
    {
        public static async Task SeedDataAsync(NRShoppingCartContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                //SEED PRODUCTS BRAND DATA
                if (!context.ProductBrands.Any())
                {
                    var brandsData = File.ReadAllText("..\\ShoppingCart.Infrastructure\\Data\\SeedData\\brands.json");
                    var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsData);
                    if (brands  != null && brands.Count > 0)
                    {
                        foreach (var brand in brands)
                        {
                            context.ProductBrands.Add(brand);
                        }
                    }
                    await context.SaveChangesAsync();
                }

                //SEED PRODUCT TYPES DATA
                if (!context.ProductTypes.Any())
                {
                    var typesData = File.ReadAllText("..\\ShoppingCart.Infrastructure\\Data\\SeedData\\types.json");
                    var types = JsonSerializer.Deserialize<List<ProductType>>(typesData);
                    if (types != null && types.Count > 0)
                    {
                        foreach (var type in types)
                        {
                            context.ProductTypes.Add(type);
                        }
                    }
                    await context.SaveChangesAsync();
                }

                //SEED PRODUCT DATA
                if (!context.Products.Any())
                {
                    var productsData = File.ReadAllText("..\\ShoppingCart.Infrastructure\\Data\\SeedData\\products.json");
                    var products = JsonSerializer.Deserialize<List<Product>>(productsData);
                    if (products != null && products.Count > 0)
                    {
                        foreach (var product in products)
                        {
                            context.Products.Add(product);
                        }
                    }
                    await context.SaveChangesAsync();
                }
            }
            catch(Exception ex) {
                var logger = loggerFactory.CreateLogger<StoreContextSeed>();
                logger.LogError(ex.Message);
            }
        }
    }
}
