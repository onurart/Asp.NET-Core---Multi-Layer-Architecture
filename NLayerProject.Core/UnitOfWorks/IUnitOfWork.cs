using NLayerProject.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        public ICategoryRepository Categories { get; }
        public IProductRepository Products { get; }
        Task CommitAsync();
        void Commit();
    }
}
