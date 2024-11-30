using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Dashboard
    {
        public int DashboardId { get; set; } 

        [Required(ErrorMessage = "TotalUsers is required.")]
        [Range(0, int.MaxValue, ErrorMessage = "TotalUsers cannot be negative.")]
        public int TotalUsers { get; set; }

        [Required(ErrorMessage = "TotalCourses is required.")]
        [Range(0, int.MaxValue, ErrorMessage = "TotalCourses cannot be negative.")]
        public int TotalCourses { get; set; }

        [Required(ErrorMessage = "TotalRevenue is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "TotalRevenue cannot be negative.")]
        public decimal TotalRevenue { get; set; }

    }
}
