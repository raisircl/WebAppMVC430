namespace WebAppMVC430.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        List<Employee> _employees=new List<Employee>();
        public EmployeeRepository()
        {
            _employees.Add(new Employee() { Id = 1001, Name = "Rai", Department = "SW" });
            _employees.Add(new Employee() { Id = 1002, Name = "Vinod", Department = "HW" });
            _employees.Add(new Employee() { Id = 1003, Name = "Pawan", Department = "Sales" });
            _employees.Add(new Employee() { Id = 1004, Name = "Rishi", Department = ".Net" });
            _employees.Add(new Employee() { Id = 1005, Name = "Gagan", Department = ".Net" });

        }
        public Employee Add(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public Employee GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Employee GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployees()
        {
            return _employees;
        }

        public Employee UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
