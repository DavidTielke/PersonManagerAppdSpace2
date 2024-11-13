using ConsoleClient;
using ConsoleClient.DataClasses;
using Microsoft.AspNetCore.Mvc;

namespace ServiceClient.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonManager _manager;

        public PersonController(IPersonManager manager)
        {
            _manager = manager;
        }

        [HttpGet()]
        [Route("/Person/Adults")]
        public IEnumerable<Person> GetAllAdults()
        {
            return _manager.GetAllAdults();
        }

        [HttpGet()]
        [Route("/Person/Children")]
        public IEnumerable<Person> GetAllChildren()
        {
            return _manager.GetAllChildren();
        }
    }
}
