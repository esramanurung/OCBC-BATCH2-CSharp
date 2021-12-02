using Kantor_WebApi2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kantor_WebApi2.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private EmployeeContext _context;
        public EmployeeController(EmployeeContext context)
        {
            this._context = context;
        }

        //Get : api/user
        [HttpGet( Name = "Get Employee")]
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItems()
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            // retirm new string[]
            return _context.GetAllEmployee();
        }

        //Get : api/user/{id}
        [HttpGet("{id}", Name = "Get Where EmployeeItem")]
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeitem(string id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.GetEmployee(id);
        }

        [HttpPost]
        public String InsertDataEmployee(EmployeeItem data)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
        
            return _context.InsertDataEmployee(data);
        }

        [HttpPut]
        public String UpdateDataEmployee(EmployeeItem data)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
        
            return _context.UpdateDataEmployee(data);
        }

        [HttpDelete("{id}")]
        public String DeleteEmployeeData(string id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
        
            return _context.DeleteEmployeeData(id);
        }
    }

}
