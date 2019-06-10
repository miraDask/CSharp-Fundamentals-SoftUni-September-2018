namespace TeisterMask.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Task
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        //status can be Open, In Progress, Finished;
        [Required]
        public string Status { get; set; }
        
    }
}
