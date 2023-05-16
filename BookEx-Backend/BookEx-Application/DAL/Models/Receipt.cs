using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Receipt
    {
        [Key]
        public int ReceiptId { get; set; }

        [Required(ErrorMessage = "Please enter Receipt number")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Receipt number should contain 10 characters")]

        public string ReceiptNumber { get; set; }
        
        public string ReceiptDescription { get; set; }

        public decimal Amount { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

    }
}