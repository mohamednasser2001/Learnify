using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AdminSettings
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Key cannot exceed 50 characters.")]
        public string Key { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Value cannot exceed 100 characters.")]
        public string Value { get; set; }

        public string UserId { get; set; } // One-to-One with User
        public User User { get; set; }
    }
}
