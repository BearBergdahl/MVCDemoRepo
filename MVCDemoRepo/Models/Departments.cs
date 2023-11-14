using System.ComponentModel.DataAnnotations;

namespace MVCDemoRepo.Models
{
    public class Departments
    {
        List<Department> departments;
    }

    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
