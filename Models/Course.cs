﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Course
    {
        public int CourseId { get; set; }
        
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public DateTime CreateDate { get; set; }
        public ICollection<CourseInstructor> courseInstructors { get; set; }
    }
}
