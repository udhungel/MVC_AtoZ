using MVC_AtoZ.DataService.DbContextInterface;
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
        private readonly IEmployeeService _myempService;

        public EmployeeController(IEmployeeService serv)
        {
            _myempService = serv;
        }

        public ActionResult Index()
        {
            return View();
        }



        // GET: Employee
        public ActionResult Details()
        {           
            var result = _myempService.GetEmployees().Single(x => x.EmployeeId == 1);

            return View(result);
        }
    }
}