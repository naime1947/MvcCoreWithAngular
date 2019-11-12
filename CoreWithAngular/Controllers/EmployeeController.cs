using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWithAngular.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreWithAngular.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        EmployeeManager employeeManager = new EmployeeManager();

        [HttpGet("[action]")]
        [Route("api/Employee/Index")]
        public IEnumerable<TblEmployee> Index()
        {
            return employeeManager.GetAllEmployees();
        }

        [HttpPost("[action]")]
        [Route("api/Employee/Create")]
        public int Create([FromBody] TblEmployee employee)
        {
            return employeeManager.AddEmployee(employee);
        }

        [HttpGet("[action]")]
        [Route("api/Employee/Details/{id}")]
        public TblEmployee Details(int id)
        {
            return employeeManager.GetEmployeeData(id);
        }

        [HttpPut("[action]")]
        [Route("api/Employee/Edit")]
        public int Edit([FromBody]TblEmployee employee)
        {
            return employeeManager.UpdateEmployee(employee);
        }

        [HttpDelete("[action]")]
        [Route("api/Employee/Delete/{id}")]
        public int Delete(int id)
        {
            return employeeManager.DeleteEmployee(id);
        }

        [HttpGet("[action]")]
        [Route("api/Employee/GetCityList")]
        public IEnumerable<TblCities> Details()
        {
            return employeeManager.GetCities();
        }
    }
}
