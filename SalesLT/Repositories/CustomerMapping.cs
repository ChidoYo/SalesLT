﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

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
        }
    }
}