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

        [HttpGet("model/{model}")]
        public IList<Car> GetByModel(string model)
        {
            return _carsService.GetByModel(model);
        }

        [HttpGet("motor/{motor}")]
        public IList<Car> GetByMotor(string motor)
        {
            return _carsService.GetByMotor(motor);
        }
        
        [HttpGet("gearbox/{gearbox}")]
        public IList<Car> GetByGearBox(string gearBox)
        {
            return _carsService.GetByGearBox(gearBox);
        }
        
        [HttpGet("year/{year}")]
        public IList<Car> GetByYear(int year)
        {
            return _carsService.GetByYear(year);
        }

        [HttpGet("id/{id}")]
        public Car GetById(string id)
        {
            return _carsService.GetById(id);
        }
        
        [HttpPut]
        public void Put([FromBody] Car car)
        {
            _carsService.Update(car);
        }
       
    }
}