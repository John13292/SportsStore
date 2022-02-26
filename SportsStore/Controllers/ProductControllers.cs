using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Controllers
{
    public class ProductControllers : Controller
    {
        private readonly IProductRepository _repository;

        public ProductControllers(IProductRepository repository)
        {
            _repository = repository;
        }

        public ViewResult List() => View(_repository.Products);
    }
}
