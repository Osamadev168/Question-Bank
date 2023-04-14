using System.ComponentModel.DataAnnotations;

namespace Testing_System.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }
        public string Answer { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Subject { get; set; }
        public string Difficulty { get; set; }

    }


}
