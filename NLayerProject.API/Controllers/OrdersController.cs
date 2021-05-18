using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NLayerProject.API.DTOs;
using NLayerProject.Core.Model;
using NLayerProject.Core.Services;

namespace NLayerProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IService<Order> _orderService;
        private readonly IMapper _mapper;

        public OrdersController(IService<Order> orderService, IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
       
        {

            var customers = await _orderService.IncludeMany(p => p.OrderDetails).ToListAsync();

            //var customers = await _orderService.GetAllAsync();

            return Ok(_mapper.Map<IEnumerable<OrderDto>>(customers));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            var customer = await _orderService.GetByIdAsync(Id);

            return Ok(_mapper.Map<OrderDto>(customer));
        }

        [HttpPost]
        public async Task<IActionResult> Save(OrderDto orderDto)
        {
            var customer = await _orderService.AddAsync(_mapper.Map<Order>(orderDto));

            return Created(string.Empty, _mapper.Map<OrderDto>(customer));

        }

        [HttpPut]
        public IActionResult Update(OrderDto orderDto)
        {
            var customer = _orderService.Update(_mapper.Map<Order>(orderDto));

            return NoContent();

        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            var row = _orderService.GetByIdAsync(Id).Result;
            _orderService.Remove(row);

            return NoContent();
        }
    }
}