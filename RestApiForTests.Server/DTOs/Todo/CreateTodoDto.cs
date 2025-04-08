using System;
using System.ComponentModel.DataAnnotations;

namespace YourNamespace.DTOs.Todo
{
    public class CreateTodoDto
    {
        [Required]
        public string Title { get; set; } = string.Empty;

        public DateTime DueDate { get; set; } = DateTime.Today;
    }
}
