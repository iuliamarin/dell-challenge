using System;
using System.Collections.Generic;
using System.Linq;
using DellChallenge.D1.Api.Dto;

namespace DellChallenge.D1.Api.Dal
{
    public class ProductsService : IProductsService
    {
        private readonly ProductsContext _context;

        public ProductsService(ProductsContext context)
        {
            _context = context;
        }

        public ProductDto Get(Guid id)
        {
            var entity = _context.Products.FirstOrDefault(x => Guid.Parse(x.Id) == id);
            return MapToDto(entity);
        }

        public IEnumerable<ProductDto> GetAll()
        {
            return _context.Products.Select(p => MapToDto(p));
        }

        public ProductDto Add(NewProductDto newProduct)
        {
            var product = MapToData(newProduct);
            _context.Products.Add(product);
            _context.SaveChanges();
            var addedDto = MapToDto(product);
            return addedDto;
        }

        public ProductDto Update(string id, NewProductDto newProduct) {
            var product = _context.Products.FirstOrDefault(x => x.Id == id);
            if (product != null)
            {
                product.Category = newProduct.Category;
                product.Name = newProduct.Name;
                _context.SaveChanges();
            }
            return MapToDto(product);
        }

        public ProductDto Delete(string id)
        {
            var entity = _context.Products.Single(x => x.Id == id);
            // if (entity != null)
            _context.Products.Remove(entity);
            _context.SaveChanges();
            return MapToDto(entity);
        }

        private Product MapToData(NewProductDto newProduct)
        {
            return new Product
            {
                Category = newProduct.Category,
                Name = newProduct.Name
            };
        }

        private ProductDto MapToDto(Product product)
        {
            if (product != null)
            {
                return new ProductDto
                {
                    Id = product.Id,
                    Name = product.Name,
                    Category = product.Category
                };
            }
            return null;
        }
    }
}
