using Microsoft.AspNetCore.Mvc;
using ShoppingListApp.Model;
using ShoppingListApp.Services;

namespace ShoppingListApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        

        private readonly ILogger<WeatherForecastController> _logger;

        private readonly IItemService service;
        public ItemController(IItemService service)
        {
            this.service=service;
        }

        [HttpGet]
        public IActionResult  GetAll()
        {
            return Ok(service.GetItem());
        }
        [HttpGet("{shopperId}")]
        public IActionResult GetByShopper(int shopperId)
        {
            return Ok(service.GetByShopper(shopperId));
        }
    }
}