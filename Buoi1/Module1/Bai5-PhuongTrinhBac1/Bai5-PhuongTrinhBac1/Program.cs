using System;

namespace Bai5_PhuongTrinhBac1
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, x;
            Console.Clear();

            Console.WriteLine("***GIAI VA BIEN LUAN PHUONG TRINH BAC 1***");
            Console.Write("Nhap a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap b: ");
            b = Convert.ToInt32(Console.ReadLine());

            if(a == 0) 
            {   
                if(b == 0)
                {
                    Console.WriteLine("Phuong trinh co vo so nghiem");
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
            }
            else
            {
                x = -b / a;
                Console.WriteLine("Phuong trinh co 1 nghiem x = "+ x);
            }
        }
    }
}
