using System;

namespace MenuChucNangMang
{
    class Program
    {
        static double[] mang; // Mảng lưu trữ các số thực
        static int N; // Số phần tử của mảng

        static void Main(string[] args)
        {
            bool tiepTuc = true;

            while (tiepTuc)
            {
                Console.WriteLine("----- Menu -----");
                Console.WriteLine("1. Enter N (N is integer)");
                Console.WriteLine("2. Enter N-Real number Array");
                Console.WriteLine("3. Find Max in Array");
                Console.WriteLine("4. Find Min in Array");
                Console.WriteLine("5. Find Positive Even in Array");
                Console.WriteLine("6. Find Negative Odd in Array");
                Console.WriteLine("7. Find PerfectSquare in Array ");
                Console.WriteLine("8. Calculate sum of array");
                Console.WriteLine("9. Find average of array");
                Console.WriteLine("10. Find elements greater than average");
                Console.WriteLine("11. Sorts the elements of an array increasing");
                Console.WriteLine("12. Sorts the elements of an array decreasing");
                Console.WriteLine("0. Exit");
                Console.WriteLine("---------------");

                Console.Write("Enter a choice: ");
                int luaChon = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (luaChon)
                {
                    case 1:
                        NhapSoNguyenN();
                        break;
                    case 2:
                        NhapMang();
                        break;
                    case 3:
                        TimSoLonNhat();
                        break;
                    case 4:
                        TimSoNhoNhat();
                        break;
                    case 5:
                        TimSoDuongChanLonNhat();
                        break;
                    case 6:
                        TimSoAmLeNhoNhat();
                        break;
                    case 7:
                        TimSoChinhPhuong();
                        break;
                    case 8:
                        TinhTongMang();
                        break;
                    case 9:
                        TinhTrungBinhCong();
                        break;
                    case 10:
                        TimPhanTuLonHonTrungBinhCong();
                        break;
                    case 11:
                        SapXepTangDan();
                        break;
                    case 12:
                        SapXepGiamDan();
                        break;
                    case 0:
                        tiepTuc = false;
                        break;
                    default:
                        Console.WriteLine("Choice is invalid. Please re-enter.");
                        break;
                }
                Console.WriteLine();
            }
        }

        static void NhapSoNguyenN()
        {
            Console.Write("Enter integer N (0 < N < 50): ");
            N = int.Parse(Console.ReadLine());
            if (N <= 0 || N >= 50)
            {
                Console.WriteLine("N is invalid.");
                return;
            }
        }

        static void NhapMang()
        {
            mang = new double[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                mang[i] = double.Parse(Console.ReadLine());
            }
        }

        static void TimSoLonNhat()
        {
            if (N == 0)
            {
                Console.WriteLine("Array haven't declare yet.");
                return;
            }

            double max = mang[0];
            for (int i = 1; i < N; i++)
            {
                if (mang[i] > max)
                    max = mang[i];
            }

            Console.WriteLine($"Max is: {max}");
        }

        static void TimSoNhoNhat()
        {
            if (N == 0)
            {
                Console.WriteLine("Array haven't declare yet.");
                return;
            }

            double min = mang[0];
            for (int i = 1; i < N; i++)
            {
                if (mang[i] < min)
                    min = mang[i];
            }

            Console.WriteLine($"Min is: {min}");
        }

        static void TimSoDuongChanLonNhat()
        {
            if (N == 0)
            {
                Console.WriteLine("Array haven't declare yet.");
                return;
            }

            double max = double.MinValue;
            for (int i = 0; i < N; i++)
            {
                if (mang[i] > 0 && mang[i] % 2 == 0 && mang[i] > max)
                    max = mang[i];
            }

            if (max == double.MinValue)
                Console.WriteLine("There aren't positive even number in array.");
            else
                Console.WriteLine($" Positive even number in array is: {max}");
        }

        static void TimSoAmLeNhoNhat()
        {
            if (N == 0)
            {
                Console.WriteLine("Array haven't declare yet.");
                return;
            }

            double min = double.MaxValue;
            for (int i = 0; i < N; i++)
            {
                if (mang[i] < 0 && mang[i] % 2 != 0 && mang[i] < min)
                    min = mang[i];
            }

            if (min == double.MaxValue)
                Console.WriteLine(" There aren't negative odd number in array.");
            else
                Console.WriteLine($"Negative odd number in array is: {min}");
        }

        static void TimSoChinhPhuong()
        {
            if (N == 0)
            {
                Console.WriteLine("Array haven't declare yet.");
                return;
            }

            Console.Write("PerfectSquare is: ");
            for (int i = 0; i < N; i++)
            {
                if (Math.Sqrt(mang[i]) % 1 == 0)
                    Console.Write(mang[i] + " ");
            }
            Console.WriteLine();
        }

        static void TinhTongMang()
        {
            if (N == 0)
            {
                Console.WriteLine("Array haven't declare yet.");
                return;
            }

            double tong = 0;
            for (int i = 0; i < N; i++)
            {
                tong += mang[i];
            }

            Console.WriteLine($"Sum of array is: {tong}");
        }

        static void TinhTrungBinhCong()
        {
            if (N == 0)
            {
                Console.WriteLine("Array haven't declare yet.");
                return;
            }

            double tong = 0;
            for (int i = 0; i < N; i++)
            {
                tong += mang[i];
            }

            double trungBinhCong = tong / N;
            Console.WriteLine($"Average of array is:{trungBinhCong}");
        }

        static void TimPhanTuLonHonTrungBinhCong()
        {
            if (N == 0)
            {
                Console.WriteLine("Array haven't declare yet.");
                return;
            }

            double tong = 0;
            for (int i = 0; i < N; i++)
            {
                tong += mang[i];
            }

            double trungBinhCong = tong / N;

            Console.Write("Elements greater than average is: ");
            for (int i = 0; i < N; i++)
            {
                if (mang[i] > trungBinhCong)
                    Console.Write(mang[i] + " ");
            }
            Console.WriteLine();
        }

        static void SapXepTangDan()
        {
            if (N == 0)
            {
                Console.WriteLine("Array haven't declare yet.");
                return;
            }

            Array.Sort(mang);
            Console.WriteLine("Array after sort increasing:");
            for (int i = 0; i < N; i++)
            {
                Console.Write(mang[i] + " ");
            }
            Console.WriteLine();
        }

        static void SapXepGiamDan()
        {
            if (N == 0)
            {
                Console.WriteLine("Array haven't declare yet.");
                return;
            }

            Array.Sort(mang);
            Array.Reverse(mang);
            Console.WriteLine("Array after sort decreasing:");
            for (int i = 0; i < N; i++)
            {
                Console.Write(mang[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
