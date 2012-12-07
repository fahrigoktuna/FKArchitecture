using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using FKArch.Domain;

namespace FKArch.DomainMapping
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            HasKey(a => a.Id);
            Property(a => a.Title).HasColumnName("Title");
            Property(a => a.Status).HasColumnName("Status");
            ToTable("dbo.Product");
        }
    }
}
