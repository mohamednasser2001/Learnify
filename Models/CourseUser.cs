using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [PrimaryKey(nameof(CourseId), nameof(UserId))]
    public class CourseUser
    {
        public int CourseId { get; set; }
        [ForeignKey(nameof(CourseId))]
        [ValidateNever]
        public Course Course { get; set; }

        public string UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        [ValidateNever]
        public User User { get; set; }
    }
}
