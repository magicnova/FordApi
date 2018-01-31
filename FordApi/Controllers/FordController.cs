using Ford.Domain;
using Microsoft.AspNetCore.Mvc;

namespace FordApi.Controllers
{
    [Route("api/[controller]")]
    public class FordController : Controller
    {
        [HttpPost]
        public void Post([FromBody] Car car)
        {
            
        }
       
    }
}