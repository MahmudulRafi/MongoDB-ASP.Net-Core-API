using DataAPI.Models;

namespace DataAPI.Services.EmployeeService
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();
    }
}
