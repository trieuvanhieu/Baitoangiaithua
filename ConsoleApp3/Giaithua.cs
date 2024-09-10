using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Giaithua
    {
        // Phương thức tính giai thừa
        public long TinhGiaiThua(int n)
        {
            if (n < 0)
                throw new ArgumentException("So phai la so nguyen duong.");

            long giaiThua = 1;
            for (int i = 1; i <= n; i++)
            {
                giaiThua *= i;
            }
            return giaiThua;
        }
    }
}
   