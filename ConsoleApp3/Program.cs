using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo đối tượng của class FactorialCalculator
            FactorialCalculator calculator = new FactorialCalculator();

            // Nhập số nguyên dương từ người dùng
            Console.WriteLine("Nhap mot so nguyen duong:");
            int n = int.Parse(Console.ReadLine());

            // Gọi hàm tính giai thừa và in kết quả ra màn hình
            long result = calculator.TinhGiaiThua(n);
            Console.WriteLine($"Giai thua cua {n} la: {result}");

            // Cho người dùng bấm phím trước khi thoát
            Console.ReadKey();
        }
    }
}
