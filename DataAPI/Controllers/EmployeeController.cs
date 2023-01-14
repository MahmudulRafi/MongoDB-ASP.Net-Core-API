using DataAPI.Models;
using DataAPI.Services.EmployeeService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DataAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        [Route("/GetEmployees")]
        public List<Employee> GetEmployees()
        {
            return _employeeService.GetEmployees();
        }

        //[HttpPost]
        //[Route("/AddEmployeeName")]
        //public bool AddtEmployeeName(Employee employee)
        //{
        //    return _employeeService.AddEmployee(employee);
        //}

    }
}
