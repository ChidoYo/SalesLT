using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SalesLT.Repositories
{
    public class ProductModelMapping : EntityTypeConfiguration<ProductModel>
    {
        public ProductModelMapping()
        {
            ToTable("ProductModel", "SalesLT");
            HasKey(c => c.Id);

            Property(c => c.Id).HasColumnName("ProductModelID").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Name).HasColumnName("Name");
            Property(c => c.CatalogDescription).HasColumnName("CatalogDescription");
        }
    }
}