using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourNamespace.DTOs.Todo;

namespace YourNamespace.Services.Todo
{
    public class TodoService : ITodoService
    {
        private readonly List<TodoDto> _todos = new();
        private int _id = 1;

        public Task<IEnumerable<TodoDto>> GetAllAsync() =>
            Task.FromResult(_todos.AsEnumerable());

        public Task<TodoDto?> GetByIdAsync(int id) =>
            Task.FromResult(_todos.FirstOrDefault(t => t.Id == id));

        public Task<TodoDto> CreateAsync(CreateTodoDto dto)
        {
            var todo = new TodoDto
            {
                Id = _id++,
                Title = dto.Title,
                IsDone = false,
                DueDate = dto.DueDate
            };
            _todos.Add(todo);
            return Task.FromResult(todo);
        }

        public Task<bool> UpdateAsync(int id, UpdateTodoDto dto)
        {
            var todo = _todos.FirstOrDefault(t => t.Id == id);
            if (todo == null) return Task.FromResult(false);

            todo.Title = dto.Title;
            todo.DueDate = dto.DueDate;
            return Task.FromResult(true);
        }

        public Task<bool> DeleteAsync(int id)
        {
            var todo = _todos.FirstOrDefault(t => t.Id == id);
            if (todo == null) return Task.FromResult(false);
            _todos.Remove(todo);
            return Task.FromResult(true);
        }

        public Task<bool> ToggleDoneAsync(int id)
        {
            var todo = _todos.FirstOrDefault(t => t.Id == id);
            if (todo == null) return Task.FromResult(false);
            todo.IsDone = !todo.IsDone;
            return Task.FromResult(true);
        }

        public Task<IEnumerable<TodoDto>> GetTodayTasksAsync()
        {
            var today = DateTime.Today;
            return Task.FromResult(_todos.Where(t => t.DueDate.Date == today));
        }

        public Task<IEnumerable<TodoDto>> GetOverdueTasksAsync()
        {
            var now = DateTime.Now;
            return Task.FromResult(_todos.Where(t => t.DueDate < now && !t.IsDone));
        }
    }
}
