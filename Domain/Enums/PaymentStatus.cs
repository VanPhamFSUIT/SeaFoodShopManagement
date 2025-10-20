using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
    public enum PaymentStatus
    {
        Pending = 0,    // Chưa thanh toán
        Success = 1,  // Đã thanh toán
        Failed = 2,     // Thanh toán thất bại
        Refunded = 3    // Đã hoàn tiền
    }
}
