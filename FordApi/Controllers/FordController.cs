using System.Collections.Generic;
using Ford.Domain;
using Ford.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FordApi.Controllers
{
    [Route("api/[controller]")]
    public class FordController : Controller
    {
        private readonly ICarsService _carsService;

        public FordController(ICarsService carsService)
        {
            _carsService = carsService;
        }

        [HttpPost]
        public void Post([FromBody] Car car)
        {
              _carsService.Create(car);
        }

        [HttpGet]
        public IList<Car> GetAll()
        {
        return   _carsService.GetAll();
        }

        [HttpPut]
        public void Put([FromBody] Car car)
        {
            _carsService.Update(car);
        }
       
    }
}