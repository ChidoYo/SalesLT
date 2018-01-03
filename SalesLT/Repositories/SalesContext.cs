using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SalesLT.Repositories
{
    public class SalesContext : DbContext
    {
        public SalesContext() : base("MainDatabaseConnection")
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<ProductModel> ProductModels { get; set; }
        public DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMapping());
            modelBuilder.Configurations.Add(new ProductModelMapping());
            modelBuilder.Configurations.Add(new CustomerAddressMapping());
            modelBuilder.Configurations.Add(new AddressMapping());
        }
    }
}