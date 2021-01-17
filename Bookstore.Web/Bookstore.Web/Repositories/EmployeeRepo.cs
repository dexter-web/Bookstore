using Bookstore.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Web.Repositories
{
    public class EmployeeRepo
    {
        public List<Employee> GetList()
        {
            return GetEmployeeList();

        }
        public Employee GetEmployeeByID(int ID)
        {
            return GetEmployeeList().Where(x=>x.Id.Equals(ID)).FirstOrDefault();
        }

        public List<Employee> GetlistByNameandAge(string name,int age)
        {
            return GetEmployeeList().Where(x => x.Name.Contains(name) || x.Age.Equals(age)).ToList();
        }


        private List<Employee> GetEmployeeList()
        {
            return new List<Employee>()
          {
              new Employee(){ Id=1,Name="Deepak sharma",Age=28,Address="Rohta Road,Meerut"},
              new Employee(){ Id=2,Name="Anjali sharma",Age=25,Address="Rohta Road,Meerut"},
              new Employee(){ Id=3,Name="Deepa sharma",Age=27,Address="Rohta Road,Meerut"},
              new Employee(){ Id=4,Name="Raj kumar sharma sharma",Age=56,Address="Rohta Road,Meerut"}

          };
        }
    }
}



