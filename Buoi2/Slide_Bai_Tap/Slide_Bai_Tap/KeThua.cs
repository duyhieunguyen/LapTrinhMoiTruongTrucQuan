using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide_Bai_Tap
{
    class KeThua
    {
    }
    class Software
    {
        private int m_z;
        public int m_v;
        protected int m_x;
        public Software()
        {
            m_x = 100;
        }
        public Software(int y)
        {
            m_x = y;
        }
    }
    class MicrosoftSoftware : Software
    {
        public MicrosoftSoftware()
        {
            Console.WriteLine(m_x);
        }
    }
    class IBMSoftware : Software
    {
        public IBMSoftware(int y) : base(y)
        {
            Console.WriteLine(m_x);
        }
        public IBMSoftware(string s,int f) : this(f)
        {
            Console.WriteLine(s);
        }
    }
    /*public sealed class A { }
    public class B : A { }*/

    // Overriding Method
    class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal constructor");
        }
        public void Talk()
        {
            Console.WriteLine("Animal talk");
        }
        // Tính đa hình
        public virtual void Talk1()
        {
            Console.WriteLine("Animal talk 1");
        }
    }
    class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("Dog Constructor");
        }
        public new void Talk()
        {
            Console.WriteLine("Dog talk");
        }
        public override void Talk1()
        {
            Console.WriteLine("Dog talk 1");
        }
    }

    // Abstract Class
    abstract class Shape
    {
        #region Khai báo các field
        protected float m_Height = 5;
        protected float m_Width = 10;
        #endregion

        #region Khai báo cáo Method
        public abstract void CalculateArea();
        public abstract void CalculateCircumference();
        public void PrintHeight()
        {
            Console.WriteLine("Height = {0}", m_Height);
        }
        public void PrintWidth()
        {
            Console.WriteLine("Width = {0}", m_Width);
        }
        #endregion
    }
    class RectangleKeThua : Shape
    {
        public RectangleKeThua()
        {
            m_Height = 20;
            m_Width = 30;
        }

        public override void CalculateArea()
        {
            Console.WriteLine("Area : {0}", m_Height * m_Width);
        }

        public override void CalculateCircumference()
        {
            Console.WriteLine("Circumference = {0}", (m_Height + m_Width) * 2);
        }
    }
}
