using DellChallenge.D2.Web.Models;
using System;
using System.Collections.Generic;

namespace DellChallenge.D2.Web.Services
{
    public interface IProductService
    {
        IEnumerable<ProductModel> GetAll();
        ProductModel Add(NewProductModel newProduct);
        bool Delete(Guid id);
         ProductModel GetByID(Guid id);
        ProductModel Update(ProductModel model);
    }
}