using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nhap so nguyen duong tu nguoi dung
            Console.WriteLine("Nhap mot so nguyen duong:");
            int n = int.Parse(Console.ReadLine());

            // Goi ham tinh giai thua va in ket qua ra man hinh
            long result = TinhGiaiThua(n);
            Console.WriteLine($"Giai thua cua {n} la: {result}");

            // Cho nguoi dung bam phim truoc khi thoat
            Console.ReadKey();
        }

        // Ham tinh giai thua
        static long TinhGiaiThua(int n)
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
