using Nero.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nero.DataAccess
{
    public static class EmployeeManager
    {
        private static List<Employee> AllEmployees = new List<Employee>();
        


        static EmployeeManager()
        {
            AllEmployees.Add(new Employee() { Name = "Jennifer Svennes", Biography = "Jenny is pretty cool", EmailAddress = "jennifer.svennes@neroeng.com" });
            AllEmployees.Add(new Employee() { Name = "Eric Meester", Biography = "Eric is pretty cool too", EmailAddress = "eric.meester@neroeng.com" });    
        }

        public static List<Employee> GetAllEmployees()
        {
            return AllEmployees;
        }

        public static Employee GetEmployeeByFirstName(string name)
        {
            return AllEmployees.Where(e => e.Name.StartsWith(name)).FirstOrDefault();
        }
    }
}
