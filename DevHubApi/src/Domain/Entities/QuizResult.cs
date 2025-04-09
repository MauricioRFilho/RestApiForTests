public class QuizResult
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User? User { get; set; }

    public int Score { get; set; }
    public DateTime SubmittedAt { get; set; }
}
