using System;

namespace Bai6_PhuongTrinhBac2
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            

            Console.Clear();
            Console.WriteLine("***GIAI VA BIEN LUAN PHUONG TRINH BAC 2***");
            Console.Write("Nhap a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap c: ");
            c = Convert.ToInt32(Console.ReadLine());

            if(a == 0)
            {
                if(b == 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
                else
                {
                    Console.WriteLine("Phuong trinh co 1 nghiem x = " +(-c/b));
                }
            }

            float delta = b * b - 4 * a * c;
            float x, x1, x2;

            if (delta > 0)
            {
                x1 = (float) ((-b + Math.Sqrt(delta)) / (2 * a));
                x2 = (float)((-b - Math.Sqrt(delta)) / (2 * a));
                Console.WriteLine("Phuong trinh co 2 nghiem phan biet:\n"+"x1 = "+ x1+"\nx2 = "+x2);
            }
            else
            {
                if(delta == 0)
                {
                    x = (-b / (2 * a));
                    Console.WriteLine("Phuong trinh co nghiem kep x1 = x2 = " + x);
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
            }
            Console.ReadLine();
        }
    }
}
