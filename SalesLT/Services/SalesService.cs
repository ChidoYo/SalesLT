using SalesLT.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SalesLT.Factories;

namespace SalesLT.Services
{
    public class SalesService
    {
        private readonly SalesRepository _repo;
        public SalesService(SalesRepository repo)
        {
            _repo = repo;
        }

        public List<Customer> GetCustomers()
        {
            var customerList = _repo.GetCustomers();
            return customerList;
        }

        public Customer GetCustomerById(int id)
        {
            var customer = _repo.GetCustomerById(id);
            return customer;
        }

        // this should return the updated Customer and accept a Customer as a parameter
        public Customer UpdateCustomer(Customer updatedCustomer)
        {
            var customer = _repo.UpdateCustomer(updatedCustomer);
            return customer;
        }

        public void DeleteCustomer(int id)
        {
            _repo.DeleteCustomer(id);
        }

        public void CreateCustomer(Customer customer)
        {
            _repo.AddCustomer(customer);
        }

        // ProductModels
        public List<ProductModel> GetProductModels()
        {
            var productList = _repo.GetProductModels();
            return productList;
        }
    }
}