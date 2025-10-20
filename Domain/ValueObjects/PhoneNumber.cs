using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public class PhoneNumber : IEquatable<PhoneNumber>
    {
        public string Value { get; private set; }

        private PhoneNumber() { } // Cho EF Core

        public PhoneNumber(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Số điện thoại không được để trống.", nameof(value));

            value = value.Trim();

            // Chấp nhận các số bắt đầu bằng 0 và có 10 chữ số
            if (!Regex.IsMatch(value, @"^0\d{9}$"))
                throw new ArgumentException("Số điện thoại phải có đúng 10 chữ số và bắt đầu bằng số 0.", nameof(value));

            Value = value;
        }

        // So sánh 2 số điện thoại
        public bool Equals(PhoneNumber? other)
        {
            if (other == null) return false;
            return Value == other.Value;
        }

        public override bool Equals(object? obj)
        {
            return obj is PhoneNumber other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value;

        public static implicit operator string(PhoneNumber phone) => phone.Value;
        public static explicit operator PhoneNumber(string value) => new PhoneNumber(value);
    }
}
