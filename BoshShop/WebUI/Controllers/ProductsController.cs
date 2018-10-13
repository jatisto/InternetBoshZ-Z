using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Castle.Components.DictionaryAdapter.Xml;
using System.IO;
using Domain.Abstract;

namespace WebUI.Controllers
{
    public class ProductsController : Controller
    {
        private IProductRepository _repository;

        public ProductsController()
        {
            
        }
        public ProductsController(IProductRepository repo)
        {
            _repository = repo;
        }

        public ViewResult List()
        {
            return View(_repository.Products);
        }
    }
}