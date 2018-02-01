using Ford.Domain;
using Ford.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FordApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class FordController : Controller
    {
        private readonly ICarsService _carsService;

        public FordController(ICarsService carsService)
        {
            _carsService = carsService;
        }

        /// <summary>
        ///     This method will create a new car.
        /// </summary>
        /// <remarks>
        ///     Sample request:
        ///     {
        ///     "id": "",
        ///     "model": "model",
        ///     "motor":"motor",
        ///     "gearBox":"gear",
        ///     "year":2019,
        ///     "active":true
        ///     }
        /// </remarks>
        /// <response code="200">If the car was succesfully created</response>
        /// <response code="500">If the car was not succesfully created</response>
        [HttpPost]
        [ProducesResponseType(typeof(Car), 200)]
        [ProducesResponseType(typeof(Car), 500)]
        public IActionResult Post([FromBody] Car car)
        {
            _carsService.Create(car);
            return Ok();
        }

        /// <summary>
        ///     Get all cars.
        /// </summary>
        /// <remarks>
        ///     Sample request:
        ///     {
        ///     "id": "5a71b9721cafa41c54a31f30",
        ///     "model": "Focus",
        ///     "motor":"Gas",
        ///     "gearBox":"Automatic",
        ///     "year":2019,
        ///     "active":true
        ///     }
        /// </remarks>
        /// <returns>All active cars</returns>
        /// <response code="200">Returns all active cars</response>
        /// <response code="204">If cars are not availables</response>
        [HttpGet]
        public IActionResult GetAll()
        {
            var cars = _carsService.GetAll();

            if (cars.Count == 0) return NoContent();

            return Ok(cars);
        }

        /// <summary>
        ///     Get all cars that match with the model.
        /// </summary>
        /// <remarks>
        ///     Sample request:
        ///     {
        ///     "id": "5a71b9721cafa41c54a31f30",
        ///     "model": "Focus",
        ///     "motor":"Gas",
        ///     "gearBox":"Automatic",
        ///     "year":2019,
        ///     "active":true
        ///     }
        /// </remarks>
        /// <param name="model"></param>
        /// <returns>All active cars</returns>
        /// <response code="200">Returns active cars</response>
        /// <response code="204">If cars are not availables</response>
        [HttpGet("model/{model}")]
        public IActionResult GetByModel(string model)
        {
            var cars = _carsService.GetByModel(model);

            if (cars.Count == 0) return NoContent();

            return Ok(cars);
        }

        /// <summary>
        ///     Get all cars that match with the motor.
        /// </summary>
        /// <remarks>
        ///     Sample request:
        ///     {
        ///     "id": "5a71b9721cafa41c54a31f30",
        ///     "model": "Focus",
        ///     "motor":"Gas",
        ///     "gearBox":"Automatic",
        ///     "year":2019,
        ///     "active":true
        ///     }
        /// </remarks>
        /// <param name="motor"></param>
        /// <returns>All active cars that match with the motor</returns>
        /// <response code="200">Returns active cars</response>
        /// <response code="204">If cars are not availables</response>
        [HttpGet("motor/{motor}")]
        public IActionResult GetByMotor(string motor)
        {
            var cars = _carsService.GetByMotor(motor);

            if (cars.Count == 0) return NoContent();

            return Ok(cars);
        }

        /// <summary>
        ///     Get all cars that match with the gear box.
        /// </summary>
        /// <remarks>
        ///     Sample request:
        ///     {
        ///     "id": "5a71b9721cafa41c54a31f30",
        ///     "model": "Focus",
        ///     "motor":"Gas",
        ///     "gearBox":"Automatic",
        ///     "year":2019,
        ///     "active":true
        ///     }
        /// </remarks>
        /// <param name="gearBox"></param>
        /// <returns>All active cars that match with the gearbox</returns>
        /// <response code="200">Returns active cars</response>
        /// <response code="204">If cars are not availables</response>
        [HttpGet("gearbox/{gearbox}")]
        public IActionResult GetByGearBox(string gearBox)
        {
            var cars = _carsService.GetByGearBox(gearBox);

            if (cars.Count == 0) return NoContent();

            return Ok(cars);
        }

        /// <summary>
        ///     Get all cars that match with the year.
        /// </summary>
        /// <remarks>
        ///     Sample request:
        ///     {
        ///     "id": "5a71b9721cafa41c54a31f30",
        ///     "model": "Focus",
        ///     "motor":"Gas",
        ///     "gearBox":"Automatic",
        ///     "year":2019,
        ///     "active":true
        ///     }
        /// </remarks>
        /// <param name="year"></param>
        /// <returns>All active cars that match with the year</returns>
        /// <response code="200">Returns active cars</response>
        /// <response code="204">If cars are not availables</response>
        [HttpGet("year/{year}")]
        public IActionResult GetByYear(int year)
        {
            var cars = _carsService.GetByYear(year);

            if (cars.Count == 0) return NoContent();

            return Ok(cars);
        }

        /// <summary>
        ///     Get the car that match with the id.
        /// </summary>
        /// <remarks>
        ///     Sample request:
        ///     {
        ///     "id": "5a71b9721cafa41c54a31f30",
        ///     "model": "Focus",
        ///     "motor":"Gas",
        ///     "gearBox":"Automatic",
        ///     "year":2019,
        ///     "active":true
        ///     }
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>the car that match with the id</returns>
        /// <response code="200">If exist returns the car</response>
        /// <response code="204">If not exist</response>
        /// <response code="500">if an error occurs, like parsing the id to an objectId</response>
        [HttpGet("id/{id}")]
        public IActionResult GetById(string id)
        {
            var car = _carsService.GetById(id);

            if (car == null) return NoContent();

            return Ok(car);
        }

        /// <summary>
        ///     This method will update a car.
        /// </summary>
        /// <remarks>
        ///     Sample request:
        ///     {
        ///     "id": "5a71b9721cafa41c54a31f30",
        ///     "model": "Focus",
        ///     "motor":"Gas",
        ///     "gearBox":"Automatic",
        ///     "year":2019,
        ///     "active":true
        ///     }
        /// </remarks>
        /// <response code="200">If the car was succesfully updated</response>
        /// <response code="500">If the car was not succesfully updated</response>
        [HttpPut]
        public IActionResult Put([FromBody] Car car)
        {
            _carsService.Update(car);
            return Ok();
        }

        /// <summary>
        ///     Delete the car that match with the id.
        /// </summary>
        /// <param name="id"></param>
        /// <response code="200">If the car was succesfully deleted</response>
        /// <response code="204">If not exist</response>
        /// <response code="500">if an error occurs, like parsing the id to an objectId</response>
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            _carsService.Delete(id);
            return Ok();
        }
    }
}