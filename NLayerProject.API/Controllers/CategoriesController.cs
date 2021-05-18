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
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoriesController(Core.Services.ICategoryService categoryService,IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _categoryService.GetAllAsync();

            return Ok(_mapper.Map<IEnumerable<CategoryDto>>(categories));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            var category = await _categoryService.GetByIdAsync(Id);

            return Ok(_mapper.Map<CategoryDto>(category));
        }

        [HttpGet("{id}/products")]
        public async Task<IActionResult> GetWithProductById(int Id)
        {
            var category = await _categoryService.GetWithProductsByIdAsync(Id);

            return Ok(_mapper.Map<CategoryWithProductDto>(category));
        }

        [HttpPost]
        public async Task<IActionResult> Save(CategoryDto categoryDto)
        {
            var category = await _categoryService.AddAsync(_mapper.Map<Category>(categoryDto));

            return Created(string.Empty, _mapper.Map<CategoryDto>(category));

        }

        [HttpPut]
        public IActionResult Update(CategoryDto categoryDto)
        {
            var category =  _categoryService.Update(_mapper.Map<Category>(categoryDto));

            return NoContent();

        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            var row = _categoryService.GetByIdAsync(Id).Result;
            _categoryService.Remove(row);

            return NoContent();
        }
    }
}