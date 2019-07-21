using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApp.API.Models;
using TodoApp.API.Data;

namespace TodoApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly DataContext _context;
        public TodoController(DataContext context)
        {
            _context = context;
        }
        // GET api/todo
        [HttpGet]
        public IActionResult GetValues()
        {
            var todoList = _context.Todos.ToList();

            return Ok(todoList);
        }

        // GET api/todo/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/todo
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/todo/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/todo/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
