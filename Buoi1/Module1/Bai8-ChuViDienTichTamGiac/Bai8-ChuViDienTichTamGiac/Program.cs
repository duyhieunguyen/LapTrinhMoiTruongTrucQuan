using System;

namespace Bai8_ChuViDienTichTamGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double p, chuvi, dientich;
            Console.Clear();

            Console.WriteLine("***CHU VI DIEN TICH TAM GIAC***");

            Console.Write("Nhap canh a > 0: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap canh b > 0: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap canh c > 0: ");
            c = Convert.ToInt32(Console.ReadLine());

            chuvi = a + b + c;
            //Nua chu vi
            p = chuvi / 2;
            dientich =  Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            
            if(a > 0 & b > 0 && c > 0)
            {
                Console.WriteLine("Co the tao thanh tam giac!!!");
                Console.WriteLine("Chu vi = " + chuvi);
                Console.WriteLine("Dien tich = "+ dientich);
            }
            else
            {
                Console.WriteLine("Khong the tao thanh tam giac!!!");
            }
            




            Console.ReadLine();
        }
    }
}
