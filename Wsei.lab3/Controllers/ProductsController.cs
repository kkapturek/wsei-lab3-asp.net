﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wsei.lab3.Database;
using Wsei.lab3.Entities;
using Wsei.lab3.Models;

namespace Wsei.lab3.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _dbContext;
        public ProductsController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> Add(ProductModel product)
        {
            var entity = new ProductEntity 
            {
                Name = product.Name,
                Description = product.Description,
                IsVisible = product.IsVisible,
            };

            await _dbContext.Products.AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            var viewModel = new ProductStatsViewModel
            {
                NameLength = product.Name.Length,
                DescriptionLength = product.Description.Length,
            };
            return View(viewModel);
        }


    }
}