using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayerProject.API.DTOs;
using NLayerProject.Core.Model;
using NLayerProject.Core.Services;

namespace NLayerProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly IService<Customer> _customerService;
        private readonly IMapper _mapper;

        public CustomersController(IService<Customer> customerService, IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var customers = await _customerService.GetAllAsync();

            return Ok(customers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            var customer = await _customerService.GetByIdAsync(Id);

            return Ok(customer);
        }

        [HttpPost]
        public async Task<IActionResult> Save(Customer customer)
        {
            var customerRow = await _customerService.AddAsync(_mapper.Map<Customer>(customer));

            return Created(string.Empty, customerRow);

        }

        [HttpPut]
        public IActionResult Update(Customer customer)
        {
            var result = _customerService.Update(customer);

            return NoContent();

        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            var row = _customerService.GetByIdAsync(Id).Result;
            _customerService.Remove(row);

            return NoContent();
        }
    }
}