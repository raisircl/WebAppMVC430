namespace WebAppMVC430.Models
{
    public class CountryRepository : ICountryRepository
    {
        List<Country> _countries;
        public CountryRepository()
        {
                _countries = new List<Country>();
            _countries.Add(new Country { Id = 1, Name = "India", Code = "IN" });
            _countries.Add(new Country { Id = 2, Name = "Canada", Code = "CA" });
            _countries.Add(new Country { Id = 3, Name = "America", Code = "US" });
            _countries.Add(new Country { Id = 4, Name = "Sri Lanka", Code = "SL" });

        }
        public List<Country> GetAll()
        {
           return _countries;
        }
    }
}
