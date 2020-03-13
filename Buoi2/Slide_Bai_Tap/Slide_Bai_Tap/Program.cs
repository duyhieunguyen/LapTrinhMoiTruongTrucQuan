using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide_Bai_Tap
{
    class Program
    {
        enum Days
        {
            #region day
            Sat,
            Sun,
            Mon,
            Tue,
            Web,
            Thu,
            Fri
            #endregion
        }
        static void Main(string[] args)
        {

            
            Console.WriteLine("*******Struct*******");
            PointStruct p1 = new PointStruct();
            PointStruct p2 = new PointStruct(10, 10);
            Console.Write("Point 1: ");
            Console.WriteLine("x = {0}, y = {1}", p1.x, p1.y);
            Console.Write("Point 2: ");
            Console.WriteLine("x = {0}, y = {1}", p2.x, p2.y);
            Console.WriteLine("Call Add Method: {0}", p2.Add());


            Console.WriteLine("___Cac Thanh Phan Trong Lop___");
            KhachHang1.mTenKH = "DuyHieu";
            KhachHang1.In();

            KhachHang2 objKH = new KhachHang2();
            objKH.In();
            objKH.mTenKH = "ABC";

            Console.WriteLine("___Overloading Methods___");
            Point objP1 = new Point(1, 1);
            Point objP2 = new Point(2, 2);
            Point objResult = new Point();
            objResult = objP1 + objP2;
            Console.WriteLine("The result is m_x = {0} and m_y = {1}", objResult.m_x, objResult.m_y);

            Console.WriteLine("*******Enumrator*******");
            int x = (int)Days.Sun;
            int y = (int)Days.Fri;
            Console.WriteLine("Sun = {0} : Value : {1}", x, Days.Sun);
            Console.WriteLine("Fri = {0} : Value : {1}", y, Days.Fri);
            Console.WriteLine("--------------------");

            Console.WriteLine("*******Properties*******");
            Rectangle objRectangle = new Rectangle();
            objRectangle.Lenght = 3;
            objRectangle.Width = 4;
            objRectangle.CallArea();
            Console.WriteLine("{0}", objRectangle.Area);



            Console.WriteLine("*******Indexer*******");
            IndexerClass b = new IndexerClass();
            b[3] = 256;
            b[5] = 1024;
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Element # {0} = {1}", i, b[i]);
            }



            Console.WriteLine("*******Ke Thua*******");
            MicrosoftSoftware objMS = new MicrosoftSoftware();
            IBMSoftware objBM1 = new IBMSoftware(50);
            IBMSoftware objBM2 = new IBMSoftware("test", 75);
            Console.WriteLine("--------------------");


            Console.WriteLine("*******Overriding Method*******");
            Animal a1 = new Animal();
            a1.Talk();
            Dog d1 = new Dog();
            d1.Talk();



            Console.WriteLine("*******Da Hinh - Polymorphism*******");
            Animal objA = new Animal();
            Dog objD = new Dog();
            objA = objD;
            objA.Talk1();



            Console.WriteLine("*******Abstract Class*******");
            RectangleKeThua objRec = new RectangleKeThua();
            objRec.CalculateArea();
            objRec.CalculateCircumference();


            Console.WriteLine("*******Interface*******");
            BaseInterface obj = new BaseInterface();
            obj.Print();
            ITest ib = (ITest)obj;
            ib.Print();
            BaseInterface ojB = (BaseInterface)ib;
            ojB.Print();


            Console.ReadLine();
        }
    }
}
