using DapperExtensionTutorials.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperExtensionTutorials.IRepository
{
   public interface IEmployeeRepository:IGenericRepository<EmployeeModel>
    {

    }
}
