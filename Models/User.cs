using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User
    {
        public string Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "First name cannot exceed 50 characters.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Last name cannot exceed 50 characters.")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        public ICollection<UserAssignment> UserAssignments { get; set; } // Many-to-Many with Assignment
        public ICollection<UserQuiz> UserQuizzes { get; set; } // Many-to-Many with Quiz
        public ICollection<UserWishlist> UserWishlists { get; set; } // Many-to-Many with Wishlist
        public ICollection<Feedback> Feedbacks { get; set; } // One-to-Many with Feedback
        public ICollection<CourseUser> CourseUsers { get; set; } // Many-to-Many with Course
        public AdminSettings AdminSettings { get; set; } // One-to-One with AdminSettings

    }
}
