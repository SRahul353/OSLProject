namespace OSLProject.Models
{
    public class ReplyModel
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public string User { get; set; }
        public int QAModelId { get; set; }
        public QAModel QAModel { get; set; }
    }
}