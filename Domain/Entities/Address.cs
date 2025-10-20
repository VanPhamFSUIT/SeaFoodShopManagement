using Domain.Common;
using Domain.ValueObjects;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Address : BaseEntity
    {
        public int AddressId { get; set; }
        public int UserId { get; set; }
        public AddressDetail AddressDetail { get; private set; }
        public bool IsDefault { get; set; }

    }
}
