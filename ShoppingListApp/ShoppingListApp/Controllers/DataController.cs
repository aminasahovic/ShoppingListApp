using Microsoft.AspNetCore.Mvc;
using ShoppingListApp.Model;
using ShoppingListApp.Services;

namespace ShoppingListApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataController : ControllerBase
    {

        private readonly IDataService service;
        public DataController(IDataService service)
        {
            this.service=service;
        }

        [HttpPost]
        public IActionResult  GenerateData()
        {
            service.GenerateData();
            return Ok();
        }
    }
}