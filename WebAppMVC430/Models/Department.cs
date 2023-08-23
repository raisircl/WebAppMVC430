namespace WebAppMVC430.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string?  DName { get; set; }

        public Country? Country { get; set; }
        public Location? Loc { get; set; }
       
    }
}
