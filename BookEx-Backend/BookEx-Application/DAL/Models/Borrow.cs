using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Borrow
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter User ID")]
        [ForeignKey("User")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Please enter Book ID")]
        [ForeignKey("Book")]
        public int BookId { get; set; }

        [Required(ErrorMessage = "Please enter Borrowing Date")]
        public DateTime BorrowDate { get; set; }

        [Required(ErrorMessage = "Please enter Due Date")]
        public DateTime DueDate { get; set; }
        [Required(ErrorMessage = "Please enter Return Date")]
        public DateTime ReturnDate { get; set; }

        [Required]
        public string Status { get; set; }
        public double Fine { get; set; }

        public virtual User User { get; set; }
        public virtual Book Book { get; set; }


    }
}
