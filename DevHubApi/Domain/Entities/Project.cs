public class Project
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string? Url { get; set; }
    public string? RepoUrl { get; set; }

    public DateTime CreatedAt { get; set; }
}
