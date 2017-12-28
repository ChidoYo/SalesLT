﻿using System;
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
            var customerList = _sales.Customers.OrderBy(c => c.Id).ToList();
            return customerList;
        }

        public Customer GetOneCustomer(int id) // this is returning s 'single customer'. Hence: public Customer...
        {
            var customer = _sales.Customers.Find(id);
            return customer;
        }

        // this method needs to have a Customer as a parameter
        //public void UpdateCustomer(Customer customer)
        //{
            
        //    _sales.SaveChanges();
        //}

        public void AddCustomer(Customer customer)
        {
            _sales.Customers.Add(customer);
            _sales.SaveChanges();
        }
    }
}