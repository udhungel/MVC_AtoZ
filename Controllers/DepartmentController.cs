using MVC_AtoZ.DataService.DbContextInterface;
using MVC_AtoZ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_AtoZ.Controllers
{
    public class DepartmentController : Controller
    {

        private readonly IDepartmentService _myDepartService;

        public DepartmentController(IDepartmentService serv)
        {
            _myDepartService = serv;
        }

        // GET: Department
        public ActionResult Index()
        {
            var departmentList = _myDepartService.GetDepartment();
            return View(departmentList);
        }
    }
}