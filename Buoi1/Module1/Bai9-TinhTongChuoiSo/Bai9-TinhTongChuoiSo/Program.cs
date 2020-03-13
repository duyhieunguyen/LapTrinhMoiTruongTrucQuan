using System;

namespace Bai9_TinhTongChuoiSo
{
    class Program
    {
        static void Main(string[] args)
        {

            int x, n = 0;
            Console.Clear();

            Console.WriteLine("***TINH TONG CHUOI SO***");
            Console.Write("Nhap x : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap n : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("S("+x+","+n+") = " + Math.Round(tinh_tong(x, n), 3));
            Console.ReadLine();
        }
        public static int tinh_giai_thua(int k)
        {
            int giaithua = 1;
            if (k < 0)
            {
                return -1;
            }
            else if ((k == 0) || (k == 1))
            {
                return 1;
            }
            else
            {
                for (int i = 2; i <= k; i++)
                {
                    giaithua *= i;
                }
            }
            return giaithua;
        }

        private static double luy_thua(double coSo, double soMu)
        {
            if (coSo == 1)
                return 1;
            else
                return Math.Pow(coSo, soMu);
        }

        private static double tinh_tong(int x, int n)
        {
            if (n == 1)
                return x;
            else
                return luy_thua(x, n) / tinh_giai_thua(n) + tinh_tong(x, n - 1);
        }

    }
}
