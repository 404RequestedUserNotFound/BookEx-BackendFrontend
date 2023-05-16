﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        [Required(ErrorMessage = "Please enter first name")]
        [StringLength(25, MinimumLength = 4, ErrorMessage = "First name should contain 3 t0 25 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter last name")]
        [StringLength(25, MinimumLength = 4, ErrorMessage = "Last name should contain 3 t0 25 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter User name")]
        [StringLength(25, MinimumLength = 8, ErrorMessage = "User name should contain 3 t0 25 characters")]
        public string Username { get; set; }
        
        [Required(ErrorMessage = "Please enter phone number")]
        [StringLength(14, MinimumLength = 11, ErrorMessage = "Phone number should be valid")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter present address name")]
        [StringLength(25, MinimumLength = 10, ErrorMessage = "Present address name should contain 3 t0 25 characters")]
        public string PresentAddress { get; set; }

        [Required(ErrorMessage = "Please enter permanent address name")]
        [StringLength(25, MinimumLength = 10, ErrorMessage = "Permanent address name should contain 3 t0 25 characters")]
        public string PermanentAddress { get; set; }

        [Required(ErrorMessage = "Please enter NID card number")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "NID card number should contain 10 characters")]
        public string NID { get; set; }

        [Required(ErrorMessage = "Please enter email address")]
        [StringLength(25, MinimumLength = 10, ErrorMessage = "Email address should be valid")]
        public string Email { get; set; }

        [Required]
        [StringLength(8)]
        public string Password { get; set; }

        [Compare("Password")]
        [Required(ErrorMessage = "Entered password did not match")]
        public string ConfirmPassword { get; set; }

    }
}

