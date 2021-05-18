using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using NLayerProject.API.DTOs;
using NLayerProject.Core.Model;
using NLayerProject.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerProject.API.Filters
{
    public class NotFoundFilter : ActionFilterAttribute 
    {
        //private readonly IProductService _productService;
        private readonly IService<Product> _productService;

        public NotFoundFilter(IService<Product> productService)
        {
            _productService = productService;
        }

        public async override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            int Id = (int)context.ActionArguments.Values.FirstOrDefault();

            var product = await _productService.GetByIdAsync(Id);

            //Eğer Id ile gelen değer null değilse bir sonraki requeste geç.
            if (product != null)
            {
                await next();
            }
            else
            {
                ErrorDto errorDto = new ErrorDto();
                errorDto.Status = 404;
                errorDto.Errors.Add($"Id'si {Id} olan ürün veritabanında bulunamadı.");

                context.Result = new NotFoundObjectResult(errorDto);
            }
        }
    }
}
