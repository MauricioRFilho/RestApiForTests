using System;

namespace YourNamespace.DTOs.Todo
{
    public class UpdateTodoDto
    {
        public string Title { get; set; } = string.Empty;
        public DateTime DueDate { get; set; } = DateTime.Today;
    }
}
