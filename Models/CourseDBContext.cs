using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationProjectT210.Models
{
    public class CourseDBContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<ClassRoom> ClassRooms { get; set; }
        public DbSet<Section1> Section1 { get; set; }


        public CourseDBContext(DbContextOptions opt):base(opt)
        {
        }



    }
}
