namespace WebAppMVC430.Models
{
    public interface IDepartmentRepository
    {
        List<Department> GetDepartments();
        Department AddDepartment(Department department);
        Department GetDepartmentById(int? id);
        Department GetDepartmentByName(string name);
        void DeleteDepartment(int id);
        Department UpdateDepartment(Department department); 

    }
}
