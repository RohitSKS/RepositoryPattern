using DapperExtensionTutorials.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DapperExtensionTutorials.Repository
{
    public class TestRepository:GenericRepository<Test>,ITestRepository
    {

    }
}