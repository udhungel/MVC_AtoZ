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

        public ActionResult Index(int departmentId)
        {
            var employees = _myempService.GetEmployees().Where(x=>x.departmentID == departmentId);
            return View(employees);
        }

        [HttpGet]
        public ActionResult Create() 
        {
            return View();
        }
        public ActionResult Details(int id )
        {           
            var result = _myempService.GetEmployees().Single(x => x.EmployeeId == id);

            return View(result);
        }
    }
}