using Microsoft.AspNetCore.Mvc;

namespace Cars_Location.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentsController : ControllerBase
    {
        // GET: api/<RentsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<RentsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RentsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
