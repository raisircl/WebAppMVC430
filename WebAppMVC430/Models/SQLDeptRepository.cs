namespace WebAppMVC430.Models
{
    public class SQLDeptRepository : IDepartmentRepository
    {
        private readonly AppDBContext context;

        public SQLDeptRepository(AppDBContext context)
        {
            this.context = context; // DI
        }
        public Department AddDepartment(Department department)
        {
            context.Departments.Add(department);        
            context.SaveChanges();
            return department;  
        }

        public void DeleteDepartment(int id)
        {
            Department d = context.Departments.Find(id);
            if(d != null) { 
                    context.Remove(d); 
                context.SaveChanges();
            }
            
        }

        public Department GetDepartmentById(int? id)
        {
            return context.Departments.Find(id);
            
        }

        public Department GetDepartmentByName(string name)
        {
            return context.Departments.Where(x => x.DName == name).FirstOrDefault();

        }

        public List<Department> GetDepartments()
        {
           return context.Departments.ToList();
        }

        public Department UpdateDepartment(Department department)
        {
            var dept = context.Departments.Attach(department);
            dept.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return department;

        }
    }
}
