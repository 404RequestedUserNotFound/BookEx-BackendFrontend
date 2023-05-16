using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]

        public DateTime OrderDate { get; set; }

        [Required]

        public decimal TotalPrice { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual ICollection<OrderItem> OrderItem { get; set; }
    }
}