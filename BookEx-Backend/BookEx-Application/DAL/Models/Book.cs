using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required(ErrorMessage = "Please enter the name of Title")]
        [StringLength(14, MinimumLength = 11, ErrorMessage = "Title name should be valid")]
        public string Title { get; set; }


        [Required(ErrorMessage = "Please enter the author name")]
        [StringLength(14, MinimumLength = 11, ErrorMessage = "Author name should be valid")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Please enter description")]
        [StringLength(14, MinimumLength = 11, ErrorMessage = "description should be valid")]
        public string Description { get; set; }


        [Required]

        public decimal Price { get; set; }

        [Required]

        public int Quantity { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}