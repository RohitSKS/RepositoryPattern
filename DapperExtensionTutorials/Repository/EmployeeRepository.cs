using DapperExtensionTutorials.IRepository;
using DapperExtensionTutorials.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DapperExtensionTutorials.Repository
{
    public class EmployeeRepository : GenericRepository<EmployeeModel>, IEmployeeRepository
    {

    }
}