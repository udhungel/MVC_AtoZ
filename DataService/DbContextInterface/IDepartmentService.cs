using MVC_AtoZ.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_AtoZ.DataService.DbContextInterface
{
   public interface IDepartmentService
    {
        IEnumerable<Department> GetDepartment();
    }
}
