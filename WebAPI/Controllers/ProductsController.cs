using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("getall")]
        public IActionResult Get(string order)
        {
            var result = _productService.GetAll();
            switch (order)
            {
                case "desc":
                    var desc = result.Data.OrderByDescending(p => p.ProductId);
                    if (result.Success)
                    {
                        return Ok(desc);
                    }
                    return BadRequest(desc);
                default:
                    if (result.Success)
                    {
                        return Ok(result);
                    }
                    return BadRequest(result);
            }

        }

        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result= _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbycategoryid")]
        public IActionResult GetByCategoryId(int id)
        {
            var result = _productService.GetAllByCategoryId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getorderdetails")]
        public IActionResult GetOrderDetails()
        {
            var result = _productService.GetOrderDetailDtos();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getproductsbyterm")]
        public IActionResult GetProductByTerm(string term)
        {
            if (term==null)
            {
                var result1 = _productService.GetAll();
                if (result1.Success)
                {
                    return Ok(result1);
                }
                return BadRequest(result1);
            }
            var result = _productService.GetProductsByTerm(term);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getproductsbyprice")]
        public IActionResult GetProductsByPrice(string order)
        {
            var result = _productService.GetAll();
            switch (order)
            {
                case "asce":
                    var asce = result.Data.OrderBy(p => p.ProductPrice);
                    if (result.Success)
                    {
                        return Ok(asce);
                    }
                    return BadRequest(asce);
                case "desc":
                    var desc = result.Data.OrderByDescending(p => p.ProductPrice);
                    if (result.Success)
                    {
                        return Ok(desc);
                    }
                    return BadRequest(desc);
                default:
                    if (result.Success)
                    {
                        return Ok(result);
                    }
                    return BadRequest(result);
            }
            //var orderd =result.Data.OrderBy(p => p.ProductPrice);

        }
        [HttpGet("getdetailsbyid")]
        public IActionResult GetDetailsById(int id)
        {
            var result = _productService.GetOrderDetailDtos();
            var resultById = result.Data.Where(o => o.OrderId == id);
            if (result.Success)
            {
                return Ok(resultById);
            }
            return BadRequest(resultById);
        }
        [HttpPost("update")]
        public IActionResult Update(Product product)
        {
            var result = _productService.Update(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Product product)
        {
            var result = _productService.Delete(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
