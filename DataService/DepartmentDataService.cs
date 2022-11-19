using MVC_AtoZ.DataService.DbContextInterface;
using MVC_AtoZ.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_AtoZ.DataService
{
    public class DepartmentDataService : IDepartmentService
    {
        private readonly EmployeeContext _Empcontext;

        public DepartmentDataService(EmployeeContext ctx)
        {
            _Empcontext = ctx;
        }

     //   IEnumerable<Employee> IEmployeeService.GetEmployees { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IEnumerable<Department> GetDepartment()
        {
            return _Empcontext.Department.ToList();
        }
    }
}