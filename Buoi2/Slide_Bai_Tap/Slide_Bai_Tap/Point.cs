using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide_Bai_Tap
{
    class Point
    {
        public int m_x;
        public int m_y;
        public Point()
        {

        }
        public Point(int xx, int yy)
        {
            m_x = xx;
            m_y = yy;
        }
        public static Point operator+(Point p1, Point p2)
        {
            Point result = new Point();
            result.m_x = p1.m_x + p2.m_x;
            result.m_y = p1.m_y + p2.m_y;
            return result;
        }
    }
    public struct PointStruct
    {
        public int x, y;
        public PointStruct(int p1,int p2)
        {
            x = p1;
            y = p2;
        }
        public int Add()
        {
            return x + y;
        }
    }
}
