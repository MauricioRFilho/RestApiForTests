using System.Collections.Generic;
using System.Threading.Tasks;
using YourNamespace.DTOs.Todo;

namespace YourNamespace.Services.Todo
{
    public interface ITodoService
    {
        Task<IEnumerable<TodoDto>> GetAllAsync();
        Task<TodoDto?> GetByIdAsync(int id);
        Task<TodoDto> CreateAsync(CreateTodoDto dto);
        Task<bool> UpdateAsync(int id, UpdateTodoDto dto);
        Task<bool> DeleteAsync(int id);
        Task<bool> ToggleDoneAsync(int id);
        Task<IEnumerable<TodoDto>> GetTodayTasksAsync();
        Task<IEnumerable<TodoDto>> GetOverdueTasksAsync();
    }
}
