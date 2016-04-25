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
            AllEmployees.Add(new Employee() { Name = "Eric Meester", Biography = "Eric is pretty cool too", Title = "", EmailAddress = "eric.meester@neroeng.com", RouteName = "Eric", ImagePath = "/Images/EricMeester.jpg" });    
            AllEmployees.Add(new Employee() { Name = "Jennifer Svennes", Biography = @"Jennifer Svennes joined Nero Engineering in 2015 as a process engineer bringing additional water 
                                                    and wastewater treatment expertise to the company.  When it comes to her career, her goals are simple:  making a living doing 
                                                    rewarding work and doing it well.  The reward comes from providing safe drinking water to the public and protecting our water 
                                                    resources as well as developing relationships with others in the industry working toward the same goals. Doing it well means 
                                                    being productive, organized, attentive to detail, and being amiable when working with others so that projects are not only 
                                                    completed successfully but the process is enjoyable.  Her variety of experience with municipalities and industries, large and small, 
                                                    indicates her ability to adapt to the goals different entities are aiming to achieve with individual projects as well as for long-term solutions.
                                                    <br><br>Jennifer grew up in a small town in western Minnesota.  While she had many interests growing up, she followed her dad’s encouragement 
                                                    to pursue the engineering field after years of learning about the treatment of wastewater as a laborer in his septic system business.  
                                                    She obtained Bachelor and Master of Science degrees in civil engineering from South Dakota State University.  Jennifer has 
                                                    been in the consulting engineering field since graduating from college where she has gained planning, design, project management, and construction 
                                                    services experience.", 
                     EmailAddress = "jennifer.svennes@neroeng.com", Title="Process Engineer", RouteName="Jennifer", ImagePath="/Images/JenniferSvennes.jpg" });
            
        }

        public static List<Employee> GetAllEmployees()
        {
            return AllEmployees;
        }

        public static Employee GetEmployeeByFirstName(string name)
        {
            return AllEmployees.Where(e => e.Name.StartsWith(name)).FirstOrDefault();
        }


        public static Employee GetEmployeeByRouteName(string route)
        {
            return AllEmployees.Where(e => e.RouteName == route).FirstOrDefault();
        }
    }
}
