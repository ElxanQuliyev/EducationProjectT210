using EducationProjectT210.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationProjectT210.ViewModels
{
    public class HomeVm
    {
        public List<Category> Categories { get; set; }
        public List<ClassRoom> ClassRooms { get; set; }
        public List<Course> Courses { get; set; }
    }
}
