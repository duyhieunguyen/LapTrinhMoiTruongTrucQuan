using System;

namespace Bai4_TinhDienTich
{
    class Program
    {
        static void Main(string[] args)
        {
            int dai, rong = 0;
            float dientich, chuvi = 0;
            Console.Clear();
            Console.WriteLine("*********Tinh Chu vi & Dien tich*********");
            Console.Write("Nhap vao chieu dai: ");
            dai = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap vao chieu rong: ");
            rong = Convert.ToInt32(Console.ReadLine());

            dientich = dai * rong;
            chuvi = (dai + rong) * 2;

            Console.WriteLine("Chu vi = " + chuvi);
            Console.WriteLine("Dien tich = " + dientich);
            Console.ReadLine();
        }
    }
}
