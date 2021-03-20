﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webapp.Models;
using Microsoft.AspNetCore.Http;

namespace Webapp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private DataContext context;
        public ProductsController(DataContext ct)
        {
            context = ct;
        }
        [HttpGet]
        public IAsyncEnumerable<Product> GetProducts()
        {
            return context.Products;
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetProduct(long id)
        {
            Product p = await context.Products.FindAsync(id);
            if (p == null)
            {
                return NotFound();
            }
            return Ok(new { 
                ProductId =p.ProductID, Name = p.Name, Price = p.Price, 
                CategoryID = p.CategoryID, SupplierID = p.SupplierID
            });
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary), StatusCodes.Status400BadRequest)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> SaveProduct([FromBody]ProductBindingTarget target)
        {
            if (ModelState.IsValid)
            {
                Product p = target.ToProduct();
                await context.Products.AddAsync(p);
                await context.SaveChangesAsync();
                return Ok(p);
            }
            return BadRequest(ModelState);
        }
        [HttpPut]
        public async Task UpdateProduct(Product product)
        {
            context.Update(product);
            await context.SaveChangesAsync();
        }
        [HttpDelete("{id}")]
        public async void DeleteProduct(long id)
        {
            context.Products.Remove(new Product() { ProductID = id });
            await context.SaveChangesAsync();
        }
        [HttpGet("redirect")]
        public IActionResult Redirect()
        {
            //return Redirect("/api/products/1");
            return RedirectToAction(nameof(GetProduct), new { Id = 1 });
        }
    }
}