using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Discount : BaseEntity
    {
        public int DiscountId { get; set; }
        public required string Code { get; set; }

        public string? Description { get; set; }
        public decimal Percentage { get; set; } 
        public decimal MinOrderAmount { get; set; }

        public decimal MaxDiscountAmount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
    }
}
