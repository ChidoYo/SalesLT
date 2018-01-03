using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SalesLT.Repositories
{
    public class AddressMapping : EntityTypeConfiguration<Address>
    {
        public AddressMapping()
        {
            ToTable("Address", "SalesLT");
            HasKey(c => c.AddressId);

            Property(c => c.AddressId).HasColumnName("AddressID").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.AddressLine1).HasColumnName("AddressLine1");
            Property(c => c.AddressLine2).HasColumnName("AddressLine2");
            Property(c => c.City).HasColumnName("City");
            Property(c => c.StateProvince).HasColumnName("StateProvince");
            Property(c => c.CountryRegion).HasColumnName("CountryRegion");
            Property(c => c.PostalCode).HasColumnName("PostalCode");
        }
    }
}