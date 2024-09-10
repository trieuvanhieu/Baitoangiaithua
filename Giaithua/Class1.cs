using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giaithua
{
    public class Class1
    {
        public long TinhGiaiThua(int n)
        {
            if (n < 0)
                throw new ArgumentException("Số phải là số nguyên dương.");

            long giaiThua = 1;
            for (int i = 1; i <= n; i++)
            {
                giaiThua *= i;
            }
            return giaiThua;
        }
    }
}
