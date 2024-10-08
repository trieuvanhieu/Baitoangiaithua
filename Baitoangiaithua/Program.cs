﻿//Triệu Văn Hiếu
//Bài toán giai thừa
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitoangiaithua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nhap so nguyen duong tu nguoi dung
            Console.WriteLine("Nhap mot so nguyen duong:");
            int n = int.Parse(Console.ReadLine());

            // Tinh giai thua cua so vua nhap
            long result = GiaiThua(n);

            // In ket qua ra man hinh
            Console.WriteLine($"Giai thua cua {n} la: {result}");

            // Cho nguoi dung bam phim truoc khi thoat
            Console.ReadKey();
        }

        // Phuong thuc tinh giai thua
        static long GiaiThua(int n)
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
