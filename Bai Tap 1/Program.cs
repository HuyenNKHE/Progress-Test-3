using System;

namespace TinhToan
{
    class Program
    {
        static void Main(string[] args)
        {
            float number1, number2;
            nhapLieu(out number1, out number2);

            float tong = Tong(number1, number2);
            float hieu = Hieu(number1, number2);
            float tich = Tich(number1, number2);
            float thuong = Chia(number1, number2);
            float uocSoChungLonNhat = TimUocSoChungLonNhat(number1, number2);
            float boiSoChungNhoNhat = TimBoiSoChungNhoNhat(number1, number2);

            Console.WriteLine("Sum of " + number1 + " and " + number2 + " is: " + tong);
            Console.WriteLine("Difference of " + number1 + " and " + number2 + " is: " + hieu);
            Console.WriteLine("Product of " + number1 + " and " + number2 + " is: " + tich);
            Console.WriteLine("Quotient of " + number1 + " and " + number2 + " is: " + thuong);
            Console.WriteLine("Greatest common divisor of " + number1 + " and " + number2 + " is: " + uocSoChungLonNhat);
            Console.WriteLine("Least common multiple of " + number1 + " and " + number2 + " is: " + boiSoChungNhoNhat);

            Console.ReadLine();
        }

        static void nhapLieu(out float number1, out float number2)
        {
            Console.WriteLine("Enter first number:");
            number1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            number2 = float.Parse(Console.ReadLine());
        }

        static float Tong(float a, float b)
        {
            return a + b;
        }

        static float Hieu(float a, float b)
        {
            return a - b;
        }

        static float Tich(float a, float b)
        {
            return a * b;
        }

        static float Chia(float a, float b)
        {
            if (b != 0)
                return a / b;
            else
            {
                Console.WriteLine("Can not devide by 0.");
                return float.NaN;
            }
        }

        static float TimUocSoChungLonNhat(float a, float b)
        {
            while (b != 0)
            {
                float temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static float TimBoiSoChungNhoNhat(float a, float b)
        {
            return (a * b) / TimUocSoChungLonNhat(a, b);
        }
    }
}
