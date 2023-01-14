using DataAPI.Models;

namespace DataAPI.Repositories.EmployeeRepository
{
    public interface IEmployeeRepository
    {
        List<Employee> GetEmployees();
    }
}
