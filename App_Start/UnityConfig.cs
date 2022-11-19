using MVC_AtoZ.DataService;
using MVC_AtoZ.DataService.DbContextInterface;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace MVC_AtoZ
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
             container.RegisterType<IEmployeeService, EmployeeDataService>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}