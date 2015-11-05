using Nero.DataAccess;
using Nero.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nero.Controllers
{
    public class AboutController : Controller
    {
        //
        // GET: /About/


        public ActionResult Index(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                return View(EmployeeManager.GetAllEmployees());
            }
            else
            {
                Employee employee = EmployeeManager.GetEmployeeByFirstName(name);
                if(employee == null)
                {
                    return View(EmployeeManager.GetAllEmployees());
                }
                List<Employee> employeeForView = new List<Employee>();
                employeeForView.Add(employee);
                return View(employeeForView);
            }
            
        }
    }
}
