using SalesLT.Repositories;
using SalesLT.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SalesLT.Controllers
{
    public class SalesController : Controller
    {
        private readonly SalesService _service;

        public SalesController()
        {
            _service = new SalesService(new SalesRepository(new SalesContext()));
        }
        // GET: Sales
        public ActionResult Index()
        {
            return View(_service.GetCustomers());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            _service.CreateCustomer(customer);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult GetCustomerById(int id)
        {
            return View("Edit", _service.GetOneCustomer(id));
        }

        [HttpPost]
        public ActionResult UpdateCustomer(Customer customer)
        {
            _service.UpdateCustomer(customer);
            return RedirectToAction("Index");
        }
    }
}