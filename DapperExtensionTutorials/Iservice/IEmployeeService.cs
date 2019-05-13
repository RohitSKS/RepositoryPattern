using DapperExtensionTutorials.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperExtensionTutorials.Iservice
{
   public interface IEmployeeService
    {
       IEmployeeRepository EmployeeRepository { get; }
       ITestRepository TestRepository { get; }
    }
}
