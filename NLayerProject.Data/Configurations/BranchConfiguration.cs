using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerProject.Data.Configurations
{
    public class BranchConfiguration : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(m => m.Id).HasColumnName("ID");
            builder.Property(m => m.Kod).HasMaxLength(20);
            builder.Property(m => m.Ad).HasMaxLength(100);

            builder.ToTable("Branches");
        }
    }
}
