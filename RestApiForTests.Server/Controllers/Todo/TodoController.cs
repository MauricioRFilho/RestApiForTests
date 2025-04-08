using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using Mauricio.DevHubApi.Services.Todo;
using RestApiForTests.DTOs.Todo;

namespace RestApiForTests.Controllers.Todo
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService _todoService;

        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoDto>>> GetAll()
        {
            return Ok(await _todoService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TodoDto>> GetById(int id)
        {
            var todo = await _todoService.GetByIdAsync(id);
            if (todo == null) return NotFound();
            return Ok(todo);
        }

        [HttpPost]
        public async Task<ActionResult<TodoDto>> Create(CreateTodoDto dto)
        {
            var created = await _todoService.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateTodoDto dto)
        {
            var updated = await _todoService.UpdateAsync(id, dto);
            if (!updated) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _todoService.DeleteAsync(id);
            if (!deleted) return NotFound();
            return NoContent();
        }

        [HttpPatch("{id}/toggle")]
        public async Task<IActionResult> ToggleDone(int id)
        {
            var toggled = await _todoService.ToggleDoneAsync(id);
            if (!toggled) return NotFound();
            return NoContent();
        }

        [HttpGet("today")]
        public async Task<ActionResult<IEnumerable<TodoDto>>> GetToday()
        {
            return Ok(await _todoService.GetTodayTasksAsync());
        }

        [HttpGet("overdue")]
        public async Task<ActionResult<IEnumerable<TodoDto>>> GetOverdue()
        {
            return Ok(await _todoService.GetOverdueTasksAsync());
        }
    }
}