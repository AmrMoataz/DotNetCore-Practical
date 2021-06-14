using BusinessLayer.Models;
using BussinessenseCorpTest.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BussinessenseCorpTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_productService.GetAll());
        }

        [HttpGet("{id}")] 
        public IActionResult GetOne(Guid id)
        {
            Product product = _productService.GetOne(id);
            return Ok(product);
        }

        [HttpPost] 
        public IActionResult Create(Product product)
        {
            product = _productService.Create(product);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + product.Id, product);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            if (_productService.Delete(id))
                return Ok();
            return NotFound($"Product was not found!");
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, Product product)
        {
           return Ok( _productService.Update(id, product));
        }



    }
}
