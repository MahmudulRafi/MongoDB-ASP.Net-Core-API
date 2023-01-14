using DataAPI.Models;
using DataAPI.Repositories.EmployeeRepository;

namespace DataAPI.Services.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public List<Employee> GetEmployees()
        {
            return _employeeRepository.GetEmployees();
        }

    }
}
