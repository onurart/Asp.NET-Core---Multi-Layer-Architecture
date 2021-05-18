using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerProject.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerProject.Data.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        private readonly int[] _ids;

        public ProductSeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, Name = "Elma", Price = 5.5m, Stock = 100, CategoryId = _ids[0] },
                new Product { Id = 2, Name = "Armut", Price = 6.0m, Stock = 95, CategoryId = _ids[0] },
                new Product { Id = 3, Name = "Muz", Price = 14.50m, Stock = 300, CategoryId = _ids[0] },
                new Product { Id = 4, Name = "Kitap", Price = 30.0m, Stock = 120, CategoryId = _ids[1] },
                new Product { Id = 5, Name = "Defter", Price = 12.30m, Stock = 150, CategoryId = _ids[1] },
                new Product { Id = 6, Name = "Kalem", Price = 7.50m, Stock = 400, CategoryId = _ids[1] }

                );

        }
    }
}
