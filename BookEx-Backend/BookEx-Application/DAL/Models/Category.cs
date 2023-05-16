using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Category
    {
        [Key]
        public int CategoryId{ get; set; }

        [Required(ErrorMessage = "Please enter category name")]
        [StringLength(25, MinimumLength = 4, ErrorMessage = "Category name should contain 3 t0 25 characters")]
        public string CategoryName { get; set; }

        public virtual ICollection<Book> Book { get; set; }

    }
}
