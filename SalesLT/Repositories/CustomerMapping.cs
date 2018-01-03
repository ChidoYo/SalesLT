using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SalesLT.Repositories
{
    public class CustomerMapping : EntityTypeConfiguration<Customer>
    {
        public CustomerMapping()
        {
            ToTable("Customer", "SalesLT");
            HasKey(c => c.Id);

            Property(c => c.Id).HasColumnName("CustomerID").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.FirstName).HasColumnName("FirstName");
            Property(c => c.MiddleName).HasColumnName("MiddleName");
            Property(c => c.LastName).HasColumnName("LastName");
            Property(c => c.EmailAddress).HasColumnName("EmailAddress");
            Property(c => c.Phone).HasColumnName("Phone");
        }
    }
}