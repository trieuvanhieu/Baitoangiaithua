using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo đối tượng của class Giaithua từ DLL
            Giaithua1 giaithua = new Giaithua1();

            // Nhập số nguyên dương từ người dùng
            Console.WriteLine("Nhập một số nguyên dương:");
            int n = int.Parse(Console.ReadLine());

            // Gọi hàm tính giai thừa và in kết quả ra màn hình
            long result = giaithua.TinhGiaiThua(n);
            Console.WriteLine($"Giai thừa của {n} là: {result}");

            // Cho người dùng bấm phím trước khi thoát
            Console.ReadKey();
        }
    }
}
