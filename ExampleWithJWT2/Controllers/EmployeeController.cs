using ExampleWithJWT2.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace ExampleWithJWT2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        [Authorize(Roles = ("Administrador"))]
        public IActionResult Get()
        {
            var listEmployee = EmployeeConstants.Employees;

            return Ok(listEmployee);
        }
    }
}
