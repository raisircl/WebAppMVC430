using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace WebAppMVC430.Models
{
    public class Department
    {
        [Required(ErrorMessage = "Please enter Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter department name"), MaxLength(10, ErrorMessage = "Department Name can not more than 10 character long")]
        [Display(Name = "Department Name")]
        public string? DName { get; set; }

        public Country? Country { get; set; }

        [Required(ErrorMessage = "Please select country name")]
        public int CId {get; set;}

        public int? SId { get; set; }

        [Required(ErrorMessage = "Please enter location name")]
        public Location? Loc { get; set; }
       
    }
}
