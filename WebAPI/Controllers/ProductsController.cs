using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YazılımKampıKatmanlıMimari.Business.Abstract;
using YazılımKampıKatmanlıMimari.Entities;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            this._productService = productService;
        }

        [HttpGet("getall")]
        public List<Product> Get()
        {
            return _productService.GetAll();
        }

        [HttpGet("getbyid")]
        public Product GetById(int id)
        {
            return _productService.GetById(id);
        }

        [HttpPost("add")]
        public void Add(Product product)
        {
             _productService.Add(product);
        }

        [HttpPut("update")]
        public void Update(Product product)
        {
            _productService.Update(product);
        }

        [HttpDelete("delete")]
        public void Delete(Product product)
        {
            _productService.Delete(product);
        }
    }
}
