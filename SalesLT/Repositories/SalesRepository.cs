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

        public List<Customer> GetCustomers() // this is returning a 'List' of customers
        {
            var customerList = _sales.Customers.OrderBy(c => c.Id).Take(10).ToList();
            return customerList;
        }

        // typically this method would be just GetCustomer or GetCustomerById
        public Customer GetCustomerById(int id) // this is returning s 'single customer'. Hence: public Customer...
        {
            var customer = _sales.Customers.Find(id);
            return customer;
        }

        // this method needs to have a Customer as a parameter
        public Customer UpdateCustomer(Customer updatedCustomer)
        {
            // 1. get the right customer from the DB
            var customer = _sales.Customers.Find(updatedCustomer.Id);

            // 2. update the fields on the db customer with the passed in customer
            customer.FirstName = updatedCustomer.FirstName;
            customer.MiddleName = updatedCustomer.MiddleName;
            customer.LastName = updatedCustomer.LastName;

            // 3. dave the changes
            _sales.SaveChanges();

            // 4. return the updated customer
            return customer;
        }

        public void AddCustomer(Customer customer)
        {
            _sales.Customers.Add(customer);
            _sales.SaveChanges();
        }
    }
}