using System;

namespace KiemTraSo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhập số N từ bàn phím
            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine());

            // Kiểm tra số nguyên
            bool laSoNguyen = KiemTraSoNguyen(n);
            Console.WriteLine("N is Integer: " + laSoNguyen);

            if (laSoNguyen)
            {
                // Kiểm tra tính chẵn lẻ
                bool laSoChan = KiemTraSoChan(n);
                Console.WriteLine("N is Even: " + laSoChan);

                // Kiểm tra số chẵn dương
                bool laSoChanDuong = KiemTraSoChanDuong(n);
                Console.WriteLine("N is Positive Even: " + laSoChanDuong);

                // Kiểm tra số lẻ âm
                bool laSoLeAm = KiemTraSoLeAm(n);
                Console.WriteLine("N is Negative Odd: " + laSoLeAm);

                // Kiểm tra số chính phương
                bool laSoChinhPhuong = KiemTraSoChinhPhuong(n);
                Console.WriteLine("N is PerfectSquare: " + laSoChinhPhuong);

                // Kiểm tra số đặc biệt (nếu 0 < N < 1000)
                if (n > 0 && n < 1000)
                {
                    bool laSoDacBiet = KiemTraSoDacBiet(n);
                    Console.WriteLine("N is Armstrong: " + laSoDacBiet);
                }
            }

            Console.ReadLine();
        }

        // Hàm kiểm tra số nguyên
        static bool KiemTraSoNguyen(int n)
        {
            return n % 1 == 0;
        }

        // Hàm kiểm tra số chẵn
        static bool KiemTraSoChan(int n)
        {
            return n % 2 == 0;
        }

        // Hàm kiểm tra số chẵn dương
        static bool KiemTraSoChanDuong(int n)
        {
            return n > 0 && n % 2 == 0;
        }

        // Hàm kiểm tra số lẻ âm
        static bool KiemTraSoLeAm(int n)
        {
            return n < 0 && n % 2 != 0;
        }

        // Hàm kiểm tra số chính phương
        static bool KiemTraSoChinhPhuong(int n)
        {
            int sqrt = (int)Math.Sqrt(n);
            return sqrt * sqrt == n;
        }

        // Hàm kiểm tra số đặc biệt
        static bool KiemTraSoDacBiet(int n)
        {
            int sumOfCubedDigits = 0;
            int originalNumber = n;

            while (n != 0)
            {
                int digit = n % 10;
                sumOfCubedDigits += digit * digit * digit;
                n /= 10;
            }

            return sumOfCubedDigits == originalNumber;
        }
    }
}
