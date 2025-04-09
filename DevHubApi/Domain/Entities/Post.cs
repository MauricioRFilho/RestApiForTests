public class Post
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public string? Tags { get; set; } // opcional: separadas por vírgula

    public DateTime PublishedAt { get; set; }
    public int UserId { get; set; }
    public User? Author { get; set; }

    public ICollection<Comment>? Comments { get; set; }
}
