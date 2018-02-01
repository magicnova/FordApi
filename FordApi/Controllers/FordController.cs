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

        ///<remarks>This method will create a new car.</remarks>
        [HttpPost]
        public void Post([FromBody] Car car)
        {
              _carsService.Create(car);
        }

        [HttpGet]
        ///<remarks>This method will return all the cars.</remarks>
        public IList<Car> GetAll()
        {
        return   _carsService.GetAll();
        }

        [HttpGet("model/{model}")]
        ///<remarks>This method will return all the cars that match with the model.</remarks>
        public IList<Car> GetByModel(string model)
        {
            return _carsService.GetByModel(model);
        }

        [HttpGet("motor/{motor}")]
        ///<remarks>This method will return all the cars that match with the motor.</remarks>
        public IList<Car> GetByMotor(string motor)
        {
            return _carsService.GetByMotor(motor);
        }
        
        [HttpGet("gearbox/{gearbox}")]
        ///<remarks>This method will return all the cars that match with the gearbox.</remarks>
        public IList<Car> GetByGearBox(string gearBox)
        {
            return _carsService.GetByGearBox(gearBox);
        }
        
        [HttpGet("year/{year}")]
        ///<remarks>This method will return all the cars that match with the year.</remarks>
        public IList<Car> GetByYear(int year)
        {
            return _carsService.GetByYear(year);
        }

        [HttpGet("id/{id}")]
        ///<remarks>This method will return all the cars that match with the id.</remarks>
        public Car GetById(string id)
        {
            return _carsService.GetById(id);
        }
        
        [HttpPut]
        ///<remarks>This method will updarte the car.</remarks>
        public void Put([FromBody] Car car)
        {
            _carsService.Update(car);
        }
       
    }
}