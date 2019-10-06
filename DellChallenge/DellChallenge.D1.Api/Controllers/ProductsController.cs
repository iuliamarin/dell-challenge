using DellChallenge.D1.Api.Dal;
using DellChallenge.D1.Api.Dto;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace DellChallenge.D1.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        [HttpGet]
        [EnableCors("AllowReactCors")]
        public ActionResult<IEnumerable<ProductDto>> Get()
        {
            return Ok(_productsService.GetAll());
        }

        [HttpGet("{id}")]
        [EnableCors("AllowReactCors")]
        public ActionResult<ProductDto> Get(Guid id)
        {
            var entity = _productsService.Get(id);
            if (entity == null)
                return NotFound();
            return Ok(entity);
        }

        [HttpPost]
        [EnableCors("AllowReactCors")]
        public ActionResult<ProductDto> Post([FromBody] NewProductDto newProduct)
        {
            var addedProduct = _productsService.Add(newProduct);
            return Ok(addedProduct);
        }

        [HttpDelete("{id}")]
        [EnableCors("AllowReactCors")]
        public ActionResult Delete(Guid id)
        {
            var deleted = _productsService.Delete(id.ToString());
            if (deleted != null)
                return Ok();
            else return NotFound();
        }

        [HttpPut("{id}")]
        [EnableCors("AllowReactCors")]
        public ActionResult Put(Guid id, [FromBody] NewProductDto product)
        {
            if (product == null || id == null ||  id == Guid.Empty)
                return BadRequest();
            var updated = _productsService.Update(id.ToString(), product);
            return Ok(updated);
        }
    }
}
