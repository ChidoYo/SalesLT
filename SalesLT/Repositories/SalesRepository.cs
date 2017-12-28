using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesLT.Repositories
{
    public class SalesRepository
    {
        private readonly SalesContext _sales;

        public SalesRepository(SalesContext sales)
        {
            _sales = sales;
        }

        public List<Customer> GetCustomers()
        {
            var customerList = _sales.Customers.OrderBy(c => c.Id).Take(10).ToList();
            return customerList;
        }

        public GetOneCustomer(int? id)
        {
            var customer = _sales.Customers.Find(id);
            return customer;
        }

        public void AddCustomer(Customer customer)
        {
            _sales.Customers.Add(customer);
            _sales.SaveChanges();
        }
    }
}