using Domain.Common;
using Domain.Enums;
using Domain.ValueObjects;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : BaseEntity
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public Password Password { get; private set; }
        public Email Email { get; private set; }
        public UserRole Role { get; set; } 
        public PhoneNumber PhoneNumber { get; private set; }
        public bool IsActive { get; set; }
    }
}
