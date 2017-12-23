using SalesLT.Repositories;
using SalesLT.Services;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}