using Microsoft.AspNetCore.Mvc;
using TodoAPI.Model;
using TodoAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService _todoService;

        public TodoController(ITodoService todoService)
        {
            _todoService  = todoService;
        }
        // GET: api/<TodoController>
        [HttpGet]
        public async Task<ActionResult<List<TodoModel>>> Get()
        {
            return Ok(await _todoService.GetAllTodo());
        }

        // GET api/<TodoController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TodoModel>> Get(Guid id)
        {
            return Ok(await _todoService.GetSingleTodo(id));
        }

        // POST api/<TodoController>
        [HttpPost]
        public async Task<ActionResult<bool>> Post(TodoModel newTodo)
        {
            return Ok(await _todoService.AddNewTodo(newTodo));
        }

        // PUT api/<TodoController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<bool>> Put(TodoModel todo)
        {
            bool sucess = await _todoService.UpdateTodo(todo);
            if (sucess) return Ok(sucess);
            return BadRequest(sucess);
        }

        // DELETE api/<TodoController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(Guid id)
        {
            bool success = await _todoService.DeleteTodo(id);
            if (!success) return BadRequest(success);
            return Ok(success);
        }
    }
}
