using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [Required(ErrorMessage = "Please enter Authorname")]
        [StringLength(25, MinimumLength = 4, ErrorMessage = "AuthorName should contain 3 t0 25 characters")]
        public string AuthorName { get; set; }

        [Required(ErrorMessage = "Please enter Authorname")]
        [StringLength(25, MinimumLength = 5, ErrorMessage = "AuthorName should contain 3 t0 25 characters")]
        public string AuthorBio { get; set; }

        [Required(ErrorMessage = "Please enter present address ")]
        [StringLength(25, MinimumLength = 10, ErrorMessage = "Present address should contain 3 t0 25 characters")]
        public string PresentAddress { get; set; }

        [Required(ErrorMessage = "Please enter Author email address")]
        [StringLength(25, MinimumLength = 10, ErrorMessage = "AuthorEmail address should be valid")]
        public string AuthorEmail { get; set; }

        [Required]
        [StringLength(8)]
        public string Password { get; set; }

        [Compare("Password")]
        [Required(ErrorMessage = "Entered password did not match")]
        public string ConfirmPassword { get; set; }

    }
}