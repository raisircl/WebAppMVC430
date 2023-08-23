namespace WebAppMVC430.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {
        List<Department> departments=new List<Department>();
        public DepartmentRepository()
        {

            departments.Add(new Department() { Id = 10, DName = "SW", Loc = Location.Chandigarh, Country = new Country() { Id = 1, Name = "India", Code = "IN" } });
            departments.Add(new Department() { Id = 20, DName = "HW", Loc = Location.Sirsa});
            departments.Add(new Department() { Id = 30, DName = "Sales", Loc = Location.Mohali });
            departments.Add(new Department() { Id = 40, DName = "Android", Loc =Location.Panchkula });
        }

        public Department AddDepartment(Department department)
        {
           departments.Add(department);
            return department;
        }

        public void DeleteDepartment(int id)
        {
            throw new NotImplementedException();
        }

        public Department GetDepartmentById(int? id)
        {
            return departments.FirstOrDefault(d => d.Id == id);

        }

        public Department GetDepartmentByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetDepartments()
        {
            return departments;
        }

        public Department UpdateDepartment(Department department)
        {
            throw new NotImplementedException();
        }
    }
}
