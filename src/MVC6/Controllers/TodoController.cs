using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using MVC6.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC6.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        [FromServices]
        public ITodoRepository TodoItems { get; set; }
        //GET /api/todo
        [HttpGet]
        public IEnumerable<TodoItem> GetAll()
        {
            return TodoItems.GetAll();
        }
        //GET /api/todo/{id}
        [HttpGet("{id}", Name = "GetTodo")]
        public IActionResult GetById(string id)
        {
            var item = TodoItems.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return new ObjectResult(item);
        }

    }
}
//// GET: api/values
//[HttpGet]
//public IEnumerable<string> Get()
//{
//    return new string[] { "value1", "value2" };
//}

//// GET api/values/5
//[HttpGet("{id}")]
//public string Get(int id)
//{
//    return "value";
//}

//// POST api/values
//[HttpPost]
//public void Post([FromBody]string value)
//{
//}

//// PUT api/values/5
//[HttpPut("{id}")]
//public void Put(int id, [FromBody]string value)
//{
//}

//// DELETE api/values/5
//[HttpDelete("{id}")]
//public void Delete(int id)
//{
//}