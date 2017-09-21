using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using TentaWeb.Models;

namespace TentaWeb.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context, UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager, Student student)
        {

            if (context.Student.ToList().Count == 0)
            {
                //Stud
                var stud = new Student
                {
                    id = 1,
                    Name = "Mattias",
                    Email = "mattiasxx@hotmail.com",
                    GitHubHomeURl = "https://github.com/MattiasNackademin",
                    GoogleAccount = "mattias.nackademin@gmail.com"
                };

                context.Student.Add(stud);
                context.SaveChanges();
            }
        }
    }
}
