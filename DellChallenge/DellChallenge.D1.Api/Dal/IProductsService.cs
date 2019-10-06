using DellChallenge.D1.Api.Dto;
using System;
using System.Collections.Generic;

namespace DellChallenge.D1.Api.Dal
{
    public interface IProductsService
    {
        IEnumerable<ProductDto> GetAll();
        ProductDto Add(NewProductDto newProduct);
        ProductDto Delete(string id);
        ProductDto Get(Guid id);
        ProductDto Update(string id, NewProductDto newProduct);
    }
}
