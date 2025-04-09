public class QuizQuestion
{
    public int Id { get; set; }
    public string Question { get; set; } = string.Empty;
    public string[] Options { get; set; } = Array.Empty<string>();
    public int CorrectOptionIndex { get; set; }
}