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
    public class OrdersController : ControllerBase
    {
        private IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_orderService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetOne(Guid id)
        {
            return Ok(_orderService.GetOne(id));
        }

        [HttpPost]
        public IActionResult Create([FromForm] Order order)
        {
            order = _orderService.Create(order);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + order.Id, order);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            return Ok(_orderService.Delete(id));
        }
    }
}
