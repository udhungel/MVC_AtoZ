using MVC_AtoZ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_AtoZ.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Details()
        {
            Employee emp = new Employee()
                        {   
                            EmployeeId = 1
                           ,City = "Philly"
                           ,Gender = "Male"
                           ,Name = "Joe" 
                        };

            return View(emp);
        }
    }
}