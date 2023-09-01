using System.ComponentModel.DataAnnotations;

namespace WebAppMVC430.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter department name"), MaxLength(10,ErrorMessage ="Department Name can not more than 10 character long")]
        [Display(Name ="Department Name")]
        public string?  DName { get; set; }

        public Country? Country { get; set; }
        public State? State { get; set; }

        [Required]
        public Location? Loc { get; set; }
       
    }
}
