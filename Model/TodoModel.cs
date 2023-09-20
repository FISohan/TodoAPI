namespace TodoAPI.Model
{
    public class TodoModel
    {
        public Guid Id { get; set; }
        public required string title { get; set; }
        public string? description { get; set; }
        public bool isDone { get; set; } = false;
        public DateTime createTime { get; set; } = DateTime.Now;
    }
}
