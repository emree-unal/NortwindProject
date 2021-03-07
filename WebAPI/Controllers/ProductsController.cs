using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YazılımKampıKatmanlıMimari.Business.Abstract;
using YazılımKampıKatmanlıMimari.Business.Constants;
using YazılımKampıKatmanlıMimari.Core.Utilities.Results;
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
        public IDataResult<List<Product>> Get()
        {
            return new SuccessDataResult<List<Product>>(_productService.GetAll().Data,Messages.ProductListed);
        }

        [HttpGet("getbyid")]
        public IDataResult<Product> GetById(int id)
        {
           
            return new SuccessDataResult<Product>(_productService.GetById(id).Data, Messages.ProductListed);
        }

        [HttpPost("add")]
        public IResult Add(Product product)
        {
             _productService.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        [HttpPut("update")]
        public IResult Update(Product product)
        {
            _productService.Update(product);
            return new SuccessResult("Ürün güncellendi");

        }

        [HttpDelete("delete")]
        public IResult Delete(Product product)
        {
            _productService.Delete(product);
            return new SuccessResult("Ürün Silindi");
        }
    }
}
