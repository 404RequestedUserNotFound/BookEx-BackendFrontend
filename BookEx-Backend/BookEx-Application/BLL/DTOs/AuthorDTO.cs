using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AuthorDTO
    {
        public int AuthorId { get; set; }

        public string AuthorName { get; set; }

        public string AuthorBio { get; set; }

        public string PresentAddress { get; set; }

        public string AuthorEmail { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

    }
}