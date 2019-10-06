using System;
using System.Collections.Generic;
using DellChallenge.D2.Web.Models;
using RestSharp;

namespace DellChallenge.D2.Web.Services
{
    public class ProductService : IProductService
    {
        public ProductModel Add(NewProductModel newProduct)
        {
            var apiClient = new RestClient("http://localhost:5000/api");
            var apiRequest = new RestRequest("products", Method.POST, DataFormat.Json);
            apiRequest.AddJsonBody(newProduct);
            var apiResponse = apiClient.Execute<ProductModel>(apiRequest);
            return apiResponse.Data;
        }

        public bool Delete(Guid id) {
            var apiClient = new RestClient("http://localhost:5000/api");
            var apiRequest = new RestRequest($"products/{id}", Method.DELETE, DataFormat.Json);
            //apiRequest.AddJsonBody(newProduct);
            var apiResponse = apiClient.Execute(apiRequest);
            return apiResponse.IsSuccessful;
        }

        public ProductModel Update(ProductModel model)
        {
            var apiClient = new RestClient("http://localhost:5000/api");
            var apiRequest = new RestRequest($"products/{model.Id}", Method.PUT, DataFormat.Json);
            apiRequest.AddJsonBody(new NewProductModel() { Category = model.Category, Name = model.Name} );
            var apiResponse = apiClient.Execute<ProductModel>(apiRequest);
            return apiResponse.Data;
        }

        public IEnumerable<ProductModel> GetAll()
        {
            
            var apiClient = new RestClient("http://localhost:5000/api");
            var apiRequest = new RestRequest("products", Method.GET, DataFormat.Json);
            var apiResponse = apiClient.Execute<List<ProductModel>>(apiRequest);
            return apiResponse.Data;
        }

        public ProductModel GetByID(Guid id)
        {

            var apiClient = new RestClient("http://localhost:5000/api");
            var apiRequest = new RestRequest($"products/{id}", Method.GET, DataFormat.Json);
            var apiResponse = apiClient.Execute<ProductModel>(apiRequest);
            return apiResponse.Data;
        }
    }
}
