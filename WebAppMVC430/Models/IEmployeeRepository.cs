namespace WebAppMVC430.Models
{
    public interface IEmployeeRepository
    {
        Employee Add(Employee employee);
        Employee GetById(int id);
        Employee GetByName(string name);
        List<Employee> GetEmployees();

        Employee UpdateEmployee(Employee employee);
        void DeleteEmployee(int id);

    }
}
