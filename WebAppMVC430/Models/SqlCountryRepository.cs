namespace WebAppMVC430.Models
{
    public class SqlCountryRepository : ICountryRepository
    {
        private readonly AppDBContext context;

        public SqlCountryRepository(AppDBContext context)
        {
            this.context = context;
        }
        public List<Country> GetAll()
        {
            return context.Countries.ToList();
        }
    }
}
