using System.ComponentModel.DataAnnotations;

namespace WebAppMVC430.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required]
        public string?  DName { get; set; }

        public Country? Country { get; set; }
        public State? State { get; set; }
        public Location? Loc { get; set; }
       
    }
}
