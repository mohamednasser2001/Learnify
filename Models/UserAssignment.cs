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
    [PrimaryKey(nameof(UserId), nameof(AssignmentId))]
    public class UserAssignment
    {
        public string UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        [ValidateNever]
        public User User { get; set; }
        public int AssignmentId { get; set; }
        [ValidateNever]
        [ForeignKey(nameof(AssignmentId))]
        public Assignment Assignment { get; set; }
    }
}
