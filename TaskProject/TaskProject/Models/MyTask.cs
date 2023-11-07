namespace TaskProject.Models
{public enum Priority{
        A,B,C,D
    }
    public class MyTask
    {
        
        public string titele { get; set; }
        public string description { get; set; }
        public DateTime targetDate { get; set; }
        public Priority priority { get; set; }
    }
}
