using Microsoft.EntityFrameworkCore;
using TodoAPI.Data;
using TodoAPI.Model;

namespace TodoAPI.Services
{
    public class TodoService : ITodoService
    {
        private readonly DataContext _context;

        public TodoService(DataContext context) {
            _context = context;
        }

        public async Task<bool> AddNewTodo(TodoModel todo)
        {
            _context.Todos.Add(todo);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            { 
                return false;
            }
            return true;
        }

        public async Task<bool> DeleteTodo(Guid id)
        {
            TodoModel todo = await GetSingleTodo(id);
            _context.Todos.Remove(todo);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public async Task<List<TodoModel>> GetAllTodo()
        {
            List<TodoModel> todos = await _context.Todos.ToListAsync();
            return todos;
        }

        public async Task<TodoModel> GetSingleTodo(Guid id)
        {
            TodoModel todo = await _context.Todos.FirstAsync(t => t.Id == id);
            return todo;
        }

        public async Task<bool> UpdateTodo(TodoModel todo)
        {
            TodoModel oldTodo = await GetSingleTodo(todo.Id);
            oldTodo.title = todo.title;
            oldTodo.description = todo.description;
            oldTodo.isDone = todo.isDone;
            _context.Entry(oldTodo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
