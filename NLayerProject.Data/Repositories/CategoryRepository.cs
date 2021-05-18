using Microsoft.EntityFrameworkCore;
using NLayerProject.Core.Model;
using NLayerProject.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Data.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public AppDbContext appDbContext { get => _context as AppDbContext; }
        public CategoryRepository(AppDbContext context) : base(context)
        {

        }
        public async Task<Category> GetWithProductsByIdAsync(int categoryId)
        {
            return await appDbContext.Categories.Include(x => x.Product)
                .FirstOrDefaultAsync(s => s.Id == categoryId);
        }
    }
}
