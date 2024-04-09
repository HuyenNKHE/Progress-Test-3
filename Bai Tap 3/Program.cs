using System;

namespace KiemTraTamGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhập vào 3 số từ bàn phím
            Console.WriteLine("Enter a, b, c:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            // Kiểm tra xem 3 số là cạnh của một tam giác hay không
            if (LaTamGiac(a, b, c))
            {
                Console.WriteLine("a, b, c is sides of Triangle.");

                // Kiểm tra tam giác cân
                if (LaTamGiacCan(a, b, c))
                    Console.WriteLine("a, b, c is sides of  isosceles triangle.");

                // Kiểm tra tam giác đều
                if (LaTamGiacDeu(a, b, c))
                    Console.WriteLine("a, b, c is sides ofequilateral triangle.");

                // Kiểm tra tam giác vuông
                if (LaTamGiacVuong(a, b, c))
                    Console.WriteLine("a, b, c is sides of right triangle.");

                // Kiểm tra tam giác vuông cân
                if (LaTamGiacVuongCan(a, b, c))
                    Console.WriteLine("a, b, c is sides of isosceles right triangle.");
            }
            else
            {
                Console.WriteLine("a, b, c is not sides of a Triangle.");
            }

            Console.ReadLine();
        }

        // Hàm kiểm tra xem 3 số là cạnh của một tam giác hay không
        static bool LaTamGiac(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        // Hàm kiểm tra tam giác cân
        static bool LaTamGiacCan(double a, double b, double c)
        {
            return a == b || a == c || b == c;
        }

        // Hàm kiểm tra tam giác đều
        static bool LaTamGiacDeu(double a, double b, double c)
        {
            return a == b && b == c;
        }

        // Hàm kiểm tra tam giác vuông
        static bool LaTamGiacVuong(double a, double b, double c)
        {
            double max = Math.Max(Math.Max(a, b), c);
            if (max == a)
                return a * a == b * b + c * c;
            else if (max == b)
                return b * b == a * a + c * c;
            else
                return c * c == a * a + b * b;
        }

        // Hàm kiểm tra tam giác vuông cân
        static bool LaTamGiacVuongCan(double a, double b, double c)
        {
            return LaTamGiacCan(a, b, c) && LaTamGiacVuong(a, b, c);
        }
    }
}
