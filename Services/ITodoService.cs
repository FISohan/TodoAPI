using TodoAPI.Model;

namespace TodoAPI.Services
{
    public interface ITodoService
    {
        public Task<List<TodoModel>> GetAllTodo();
        public Task<TodoModel> GetSingleTodo(Guid id);
        public Task<bool> AddNewTodo(TodoModel todo);
        public Task<bool> DeleteTodo(Guid id);
        public Task<bool> UpdateTodo(TodoModel todo);

    }
}
