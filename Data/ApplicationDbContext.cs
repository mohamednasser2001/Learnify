using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
: base(options)
        {
        }

        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Dashboard> Dashboards { get; set; }
        public DbSet<CourseInstructor> CourseInstructors { get; set; }
    }
}
