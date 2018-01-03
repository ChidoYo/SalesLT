using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;


namespace SalesLT.Repositories
{
    public class CustomerAddressMapping : EntityTypeConfiguration<CustomerAddress>
    {
        public CustomerAddressMapping()
        {
            ToTable("CustomerAddress", "SalesLT");
            HasKey(c => c.Id);

            Property(c => c.Id).HasColumnName("CustomerID").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.AddressId).HasColumnName("AddressID");
        }
    }
}