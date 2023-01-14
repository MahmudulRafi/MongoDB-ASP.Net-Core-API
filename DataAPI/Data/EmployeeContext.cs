using DataAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAPI.Data
{
    public class EmployeeContext : DbContext
    {
        private List<Employee> _employees = new List<Employee>();

        public List<Employee> Employees { get { return _employees; } protected set { _employees = value; } }
        public EmployeeContext()
        {
            _employees.AddRange(new List<Employee>()
            {
                new Employee
                {
                    EmployeeId = Guid.NewGuid(),
                    Name = "XYZ",
                    Designation = "Engineer",
                    Email = "xyz@company.com",
                    JoiningDate = Convert.ToDateTime("25/11/2021")
                },
                new Employee
                {
                    EmployeeId = Guid.NewGuid(),
                    Name = "abc",
                    Designation = "Engineer",
                    Email = "abc@company.com",
                    JoiningDate = Convert.ToDateTime("25/01/2021")
                }

            }); ;
        }

    }
}
