using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ReceiptDTO
    {
        public int ReceiptId { get; set; }

        public int CustomerId { get; set; }

        public string ReceiptNumber { get; set; }

        public string ReceiptDescription { get; set; }

        public decimal Amount { get; set; }




    }
}