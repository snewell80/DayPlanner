namespace DayPlanner.Data.Models
{
    public class Task
    {
        public Guid Id { get; set; }
        public String Owner { get; set; }
        public string Title { get; set; } 
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CompleteDate { get; set; }

        //will need crud operations
    }
}
