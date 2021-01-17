using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bookstore.Web.Repositories;
using Bookstore.Web.Models;
using Microsoft.Extensions.FileProviders;
using System.IO;

namespace Bookstore.Web.Controllers
{
    public class HomeController : Controller
    {
        private EmployeeRepo _Emp = null;

        public HomeController()
        {
            _Emp = new EmployeeRepo(); 
        }

        public string Index()
        {
            return "Hello Welcome to Home Controller";
        }

        public string Getname(string name)
        {
            return $"Hello {name} Welcome to Home Controller";
        }

        public string GetnameByID(int ID)
        {
            return $"Hello {ID} Welcome to Home Controller";
        }


        public List<Employee> getEmployeelist()
        {
            return _Emp.GetList();
        }

        public Employee GetEmployeeById(int ID)
        {
            return _Emp.GetEmployeeByID(ID);
        }

        public List<Employee> GetEmployeeByNameAndAge(string Name,int Age)
        {
            return _Emp.GetlistByNameandAge(Name,Age);
        }

        public ActionResult Demo()
        { 
            return View();
        }
    }
}
