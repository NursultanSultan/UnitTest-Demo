using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UnitTestingDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        List<Item> itemsList = new List<Item>()
        {
            new ()
            {
                Id = 1,
                Name = "Item1"
            },
            new ()
            {
                Id = 2,
                Name = "Item2"
            }

        };

        // GET: api/<ValuesController>
        [HttpGet]
        public int GetCount()
        {
            return itemsList.Count();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {

           Item item = itemsList.Find(item => item.Id == id);

            return item.Name;
        }

        
    }
}
