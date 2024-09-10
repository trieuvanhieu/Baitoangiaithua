// Namespace của thư viện
using System;

namespace ConsoleApp3
{
    // Class tính toán giai thừa
    public class Giaithua
    {
        // Phương thức tính giai thừa
        public long TinhGiaiThua(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Số phải là số nguyên dương.");
            }

            long giaiThua = 1;
            for (int i = 1; i <= n; i++)
            {
                giaiThua *= i;
            }
            return giaiThua;
        }
    }
}
