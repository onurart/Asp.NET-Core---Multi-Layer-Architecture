using Microsoft.EntityFrameworkCore;
using NLayerProject.Core.Repositories;
using NLayerProject.Core.UnitOfWorks;
using NLayerProject.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;
        private ProductRepository _productRepository;
        private CategoryRepository _categoryRepository;
        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public ICategoryRepository Categories => _categoryRepository = _categoryRepository ??
            new CategoryRepository(_appDbContext);

        public IProductRepository Products => _productRepository = _productRepository ??
            new ProductRepository(_appDbContext);

        public void Commit()
        {
            _appDbContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _appDbContext.SaveChangesAsync();
        }
    }
}
