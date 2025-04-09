public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;

    public bool IsAdmin { get; set; } = false;
    public DateTime CreatedAt { get; set; }

    public ICollection<Post>? Posts { get; set; }
    public ICollection<Comment>? Comments { get; set; }
    public ICollection<QuizResult>? QuizResults { get; set; }
}
