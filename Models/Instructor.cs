using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public string Expertise { get; set; }
        public ICollection<CourseInstructor> CourseInstructors { get; set; }
    }
}
