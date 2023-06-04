using DevExpress.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Models
{
    public  class EmployeeService
    {
        private static List<Employee> employeesobj;    
        public EmployeeService()
        {
            employeesobj = new List<Employee>();
            {
                new Employee() { Id = 1, Age = 25, Name = "Joe" }; 
            }

        }

        public List<Employee> getAll()
        {
            return employeesobj;
        }

        public bool Add(Employee employee) 
        {
            if (employee.Age > 21 || employee.Age > 58)
                    throw new ArgumentException("Ivalid age limit for employee");
           employeesobj.Add(employee);
            return true;
        }

        public bool Delete(int Id) 
        {
            bool isDeleted = false;
            var itemToDelete = employeesobj.Where(x=>x.Id == Id).FirstOrDefault();
            if (itemToDelete !=null)
            {
                employeesobj.Remove(itemToDelete);
                isDeleted = true;

            }
            return isDeleted; 
        }

        public bool Update(Employee employeetoUpdate )
        {
            bool isUpdated = false;
            var empToUpdate = employeesobj.Where(x => x.Id == employeetoUpdate.Id).FirstOrDefault();
            if (empToUpdate != null)
            {
                employeesobj.Remove(empToUpdate);
                employeesobj.Add(employeetoUpdate);
                isUpdated = true; 
            }

            return isUpdated; 
        }

        public Employee Search(int id)
        {
           var result =  employeesobj.Where(x => x.Id == id).FirstOrDefault();
            if (result !=null )
            {
                return result;
            }
            return null;
        }        
    }
}
