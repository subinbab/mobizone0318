﻿using BusinessLayer;
using DomainLayer;
using Microsoft.AspNetCore.Mvc;
using RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UILayer.Controllers
{
    public class CatalogController : Controller
    {
        ProductDbContext _context;
        IRepositoryOperations<Product> _repo;
        IProductCatalog
        public CatalogController(ProductDbContext context , IRepositoryOperations<Product> repo)
        {
            _context = context;
            _repo = repo;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Product product)
        {

            return View();
        }
    }
}
