using DapperExtensionTutorials.IRepository;
using DapperExtensionTutorials.Iservice;
using DapperExtensionTutorials.Repository;
using DapperExtensionTutorials.Service;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace DapperExtensionTutorials
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            container.RegisterType<IEmployeeRepository, EmployeeRepository>();
            container.RegisterType<ITestRepository, TestRepository>();  
            container.RegisterType<IEmployeeService, EmployeeService>();
            
        }
    }
}