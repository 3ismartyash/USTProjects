using EmployeeAdminPortal.Data;
using EmployeeAdminPortal.Models;
using EmployeeAdminPortal.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAdminPortal.Controllers
{
    //localhost:xxxx that our application is running on
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public EmployeesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        //READ METHOD
        [HttpGet]
        public IActionResult GetAllEmploees()
        {
            var allEmpployees = dbContext.Employees.ToList();

            return Ok(allEmpployees);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetEmployeeById(Guid id)
        {
            var Emp = dbContext.Employees.Find(id);

            if (Emp == null)
            {
                return NotFound();
            }

            return Ok(Emp);
        }

        //CREATE METHOD
        [HttpPost]
        public IActionResult AddEmployee(AddEmployeeDto addEmployeeDto)
        {
            var EmployeeEntity = new Employee()
            {
                Name = addEmployeeDto.Name,
                Email = addEmployeeDto.Email,
                Phone = addEmployeeDto.Phone,
                Salary = addEmployeeDto.Salary,
            };

            dbContext.Employees.Add(EmployeeEntity);
            dbContext.SaveChanges();
            return Ok(EmployeeEntity);
        }
        
        //UPDATE METHOD
        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpdateEmployee(Guid id, UpdateEmployeeDto updateEmployeeDto)
        {
            var Emp = dbContext.Employees.Find(id);
            if (Emp == null)
            {
                return NotFound();
            }

            Emp.Name = updateEmployeeDto.Name;
            Emp.Email = updateEmployeeDto.Email;
            Emp.Phone = updateEmployeeDto.Phone;
            Emp.Salary = updateEmployeeDto.Salary;
            dbContext.Employees.Add(Emp);
            dbContext.SaveChanges();

            return Ok(Emp);
        }

        //DELETE METHOD
        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteEmployee(Guid id)
        {
            var Emp = dbContext.Employees.Find(id);
            if (Emp == null)
            {
                return NotFound();
            }

            dbContext.Employees.Remove(Emp);

            dbContext.SaveChanges();

            return Ok(Emp);

        }
    }
}
