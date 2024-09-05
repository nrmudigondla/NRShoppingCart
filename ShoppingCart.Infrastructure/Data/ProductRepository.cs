using Microsoft.EntityFrameworkCore;
using ShoppingCart.Core.Entities;
using ShoppingCart.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Infrastructure.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly NRShoppingCartContext _context;

        public ProductRepository(NRShoppingCartContext context)
        {
            this._context = context;
        }

        public async Task<IReadOnlyList<Product>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }
    }
}
