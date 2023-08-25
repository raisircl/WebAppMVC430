namespace WebAppMVC430.Models
{
    public class StateRepo : IStateRepo
    {
        List<State> states;
        public StateRepo()
        {
                states = new List<State>();
                states.Add(new State() {Id=1, Name="Haryana",Code="Hry",CId=1 });
            states.Add(new State() { Id = 2, Name = "Punjab", Code = "PB", CId = 1 });
            states.Add(new State() { Id = 3, Name = "Rajasthan", Code = "RJ", CId = 1 });
            states.Add(new State() { Id = 4, Name = "Ontario", Code = "ON", CId = 2 });
            states.Add(new State() { Id = 5, Name = "Alberta", Code = "AB", CId = 2 });
            states.Add(new State() { Id = 6, Name = "British Columbia", Code = "BC", CId = 2 });
            states.Add(new State() { Id = 7, Name = "Calafornia", Code = "CAL", CId = 3 });
            states.Add(new State() { Id = 8, Name = "Hawai", Code = "HW", CId = 3 });
            states.Add(new State() { Id = 9, Name = "Badulla", Code = "Bad", CId = 4 });
            states.Add(new State() { Id = 10, Name = "Galle ", Code = "Gal", CId = 4 });

        }
        public State? Get(int id)
        {
            return states.FirstOrDefault(e => e.Id == id);
        }

        public List<State> GetAll()
        {
            return states;
        }

        public List<State> GetSatesByCountry(int cid)
        {
            return states.FindAll(e=>e.CId==cid);
        }
    }
}
//LINQ