namespace WebAppMVC430.Models
{
    public interface IStateRepo
    {
        List<State> GetAll();   
        List<State> GetSatesByCountry(int cid);
        State? Get(int id);
    }
}
