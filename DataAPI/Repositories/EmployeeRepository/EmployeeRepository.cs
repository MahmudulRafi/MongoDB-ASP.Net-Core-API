using DataAPI.Data;
using DataAPI.Models;

namespace DataAPI.Repositories.EmployeeRepository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeContext _context;
        public EmployeeRepository()
        {
            _context = new EmployeeContext();
        }

        public List<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }

    }
}
