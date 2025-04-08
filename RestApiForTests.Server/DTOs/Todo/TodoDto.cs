using System;

namespace YourNamespace.DTOs.Todo
{
    public class TodoDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public bool IsDone { get; set; }
        public DateTime DueDate { get; set; }
    }
}
