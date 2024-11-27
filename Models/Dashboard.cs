using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Dashboard
    {
        public int DashboardId { get; set; }
        public int TotalUsers { get; set; }
        public int TotalCourses { get; set; }
        public decimal TotalRevenue { get; set; }
    }
}
