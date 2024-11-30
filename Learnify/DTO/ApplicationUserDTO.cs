﻿using System.ComponentModel.DataAnnotations;

namespace Learnify.DTO
{
    public class ApplicationUserDTO
    {
        public int  Id { get; set; }
        [Required]

        public string  Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string  Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string  Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string  ConfirmPassword { get; set; }
        public string  City { get; set; }
    }
}
