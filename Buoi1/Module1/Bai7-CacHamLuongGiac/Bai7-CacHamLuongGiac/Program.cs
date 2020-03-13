using System;

namespace Bai7_CacHamLuongGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            double fx;
            Console.Clear();

            Console.WriteLine("****CAC HAM LUONG GIAC****");
            Console.Write("Nhap vao 1 goc: ");
            fx = Convert.ToDouble(Console.ReadLine());

            double rad = fx * Math.PI / 180;
            Console.WriteLine("Sin({0}) = {1}", fx,Math.Sin(rad));
            Console.WriteLine("Cos({0}) = {1}", fx, Math.Cos(rad));
            Console.WriteLine("Tan({0}) = {1}", fx,(Math.Sin(rad)/ Math.Cos(rad)));
            Console.WriteLine("Cotg({0}) = {1}", fx, (Math.Cos(rad) / Math.Sin(rad)));
            Console.ReadLine();
        }
    }
}
