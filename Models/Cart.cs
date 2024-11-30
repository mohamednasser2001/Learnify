﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Models
{
    [PrimaryKey(nameof(CourseId),nameof(ApplicationUserId))]
    public class Cart
    {
        public int CourseId { get; set; }
        [ForeignKey(nameof(CourseId))]

        public Course course { get; set; }
        
        public string ApplicationUserId { get; set; }
        [ForeignKey(nameof(ApplicationUserId))]
        public ApplicationUser ApplicationUser { get; set; }
        
        public int Count { get; set; }
    }
}
