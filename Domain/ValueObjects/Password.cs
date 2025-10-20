using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public class Password
    {
        public string HashedValue { get; private set; }

        private Password() { } // Cho EF Core

        // Khởi tạo từ mật khẩu gốc
        public Password(string plainPassword)
        {
            if (string.IsNullOrWhiteSpace(plainPassword))
                throw new ArgumentException("Mật khẩu không được để trống.");

            if (plainPassword.Length < 6)
                throw new ArgumentException("Mật khẩu phải có ít nhất 6 ký tự.");

            HashedValue = BCrypt.Net.BCrypt.HashPassword(plainPassword);
        }

        // Kiểm tra mật khẩu khi đăng nhập
        public bool Verify(string plainPassword) => BCrypt.Net.BCrypt.Verify(plainPassword, HashedValue);

        public override string ToString() => "********"; // không bao giờ log ra hash thật
    }
}
