using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public class AddressDetail : IEquatable<AddressDetail>
    {
        public string StreetDetail { get; private set; }
        public string District { get; private set; }
        public string Province { get; private set; }

        public AddressDetail() { } 

        public AddressDetail(string street, string city, string province)
        {
            if (string.IsNullOrWhiteSpace(street))
                throw new ArgumentException("Địa chỉ cụ thể không được để trống.", nameof(street));

            if (string.IsNullOrWhiteSpace(city))
                throw new ArgumentException("Phường/xã không được để trống.", nameof(city));

            if (string.IsNullOrWhiteSpace(province))
                throw new ArgumentException("Tỉnh/thành phố không được để trống.", nameof(province));

            StreetDetail = street.Trim();
            District = city.Trim();
            Province = province.Trim();
        }

        // So sánh theo giá trị (Value Object)
        public bool Equals(AddressDetail? other)
        {
            if (other == null) return false;
            return StreetDetail == other.StreetDetail &&
                   District == other.District &&
                   Province == other.Province;
        }

        public override bool Equals(object? obj)
            => obj is AddressDetail other && Equals(other);

        public override int GetHashCode()
            => HashCode.Combine(StreetDetail, District, Province);

        public override string ToString() => $"{StreetDetail}, {District}, {Province}";
    }
}
