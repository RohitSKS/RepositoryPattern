using DapperExtensionTutorials.IRepository;
using DapperExtensionTutorials.Iservice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DapperExtensionTutorials.Service
{
    public class EmployeeService:IEmployeeService
    {
       // public IEmployeeRepository EmployeeRepository;
        public IEmployeeRepository EmployeeRepository;

        public ITestRepository TestRepository;

        public EmployeeService(IEmployeeRepository employeeRepository, ITestRepository testRepository)
        {
            this.EmployeeRepository = employeeRepository;
            this.TestRepository = testRepository;
        }

        IEmployeeRepository IEmployeeService.EmployeeRepository
        {
            get { return EmployeeRepository; }
        }

        ITestRepository IEmployeeService.TestRepository
        {
            get { return TestRepository; }
        }
    }
}