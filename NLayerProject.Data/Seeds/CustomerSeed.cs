using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerProject.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerProject.Data.Seeds
{
    public class CustomerSeed : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            //builder.HasData(
            //    new Customer { Id = 1, CustomerName = "A Şirketi", Address = "", City = "Ankara", Country = "Türkiye", Phone = "11111111", Email = "abc@hotmail.com" },
            //    new Customer { Id = 2, CustomerName = "B Şirketi", Address = "", City = "İtsanbul", Country = "Türkiye", Phone = "2222222", Email = "def@hotmail.com" },
            //    new Customer { Id = 3, CustomerName = "C Şirketi", Address = "", City = "İzmir", Country = "Türkiye", Phone = "33333333", Email = "xyz@hotmail.com" }
            //    );
        }
    }
}
