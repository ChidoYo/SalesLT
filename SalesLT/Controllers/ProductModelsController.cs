using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SalesLT.Repositories;
using SalesLT.Services;

namespace SalesLT.Controllers
{
    public class ProductModelsController : Controller
    {
        private readonly SalesService _service;

        public ProductModelsController()
        {
            _service = new SalesService(new SalesRepository(new SalesContext()));
        }

        // GET: ProductModels
        public ActionResult Index()
        {
            return View(_service.GetProductModels());
        }
    }
}