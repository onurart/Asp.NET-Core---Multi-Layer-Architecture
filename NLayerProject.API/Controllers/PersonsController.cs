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
using NLayerProject.Service.Services;

namespace NLayerProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IService<Person> _personService;
        private readonly IMapper _mapper;

        public PersonsController(IService<Person> personService,IMapper mapper)
        {
            _personService = personService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var persons = await _personService.GetAllAsync();

            return Ok(_mapper.Map<IEnumerable<PersonDto>>(persons));
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            var person = await _personService.GetByIdAsync(Id);

            return Ok(_mapper.Map<Person>(person));
        }

        [HttpPost]
        public async Task<IActionResult> Save(PersonDto person)
        {
            var _person = await _personService.AddAsync(_mapper.Map<Person>(person));

            return Created(string.Empty, _mapper.Map<PersonDto>(_person));
        }

        [HttpPut]
        public IActionResult Update(PersonDto person)
        {
            var _updatedPerson =  _personService.Update(_mapper.Map<Person>(person));

            return NoContent();
        }

        [HttpPut]
        public IActionResult Delete(int Id)
        {
            var _person = _personService.GetByIdAsync(Id).Result;
            _personService.Remove(_person);

            return NoContent();
        }
    }
}