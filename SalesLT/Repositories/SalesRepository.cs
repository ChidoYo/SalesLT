﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

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
            //var customerList = _sales.Customers.OrderBy(c => c.Id).Take(10).ToList();
            var customerList = _sales.Customers.OrderBy(c => c.Id).ToList();
            return customerList;
        }

        public Customer GetCustomerById(int id) // this is returning s 'single customer'. Hence: public Customer...
        {
            var customer = _sales.Customers.Include(c => c.CustomerAddresses.Select(ca => ca.Address)).Single(c => c.Id == id);
            return customer;
        }

        public Customer UpdateCustomer(Customer updatedCustomer)
        {
            var customer = _sales.Customers.Find(updatedCustomer.Id);

            customer.FirstName = updatedCustomer.FirstName;
            customer.MiddleName = updatedCustomer.MiddleName;
            customer.LastName = updatedCustomer.LastName;
            customer.EmailAddress = updatedCustomer.EmailAddress;
            customer.Phone = updatedCustomer.Phone;

            _sales.SaveChanges();
            return customer;
        }

        public void DeleteCustomer(int id)
        {
            var customer = _sales.Customers.Find(id);
            _sales.Customers.Remove(customer);
            _sales.SaveChanges();
        }

        public void AddCustomer(Customer customer)
        {
            _sales.Customers.Add(customer);
            _sales.SaveChanges();
        }

        // ProductModels
        public List<ProductModel> GetProductModels()
        {
            var productList = _sales.ProductModels.OrderBy(c => c.Id).ToList();
            return productList;
        }
    }
}