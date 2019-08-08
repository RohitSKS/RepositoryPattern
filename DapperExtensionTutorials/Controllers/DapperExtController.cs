using DapperExtensionTutorials.IRepository;
using DapperExtensionTutorials.Iservice;
using DapperExtensionTutorials.Models;
using DapperExtensionTutorials.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DapperExtensionTutorials.Controllers
{
    public class DapperExtController : Controller
    {
        //
        // GET: /DapperExt/
        private IEmployeeService _employeeservice;

        public DapperExtController(IEmployeeService employeeService)
        {
            this._employeeservice = employeeService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            List<EmployeeModel> result =_employeeservice.EmployeeRepository.All().ToList();
            var result2 = _employeeservice.TestRepository.All();
            //This is the test comments...
            return View();
        }

    }
}
