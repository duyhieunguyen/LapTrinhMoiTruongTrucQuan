using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide_Bai_Tap
{
    class Lop_DoiTuong
    {
    }
    class KhachHang
    {
        #region Khai báo các biến
        private int mMaKhachHang;
        private string mTenKhachHang;
        #endregion

        #region Các phương thức
        public void In()
        {
            // Các câu lệnh
            Console.WriteLine("Phuong thuc class KhachHang!");
        }
        #endregion
    }
    class KhachHang1
    {
        private static int mMaKH;
        public static string mTenKH;
        public static void In()
        {
            // Các câu lệnh
            Console.WriteLine("Ten khach hang : " + mTenKH);
        }
    }
    class KhachHang2
    {
        private int mMaKH;
        public string mTenKH;
        public void In()
        {
            // Các câu lệnh
            Console.WriteLine("Ten khach hang : " + mTenKH);
        }
    }
    class KhachHangConstructor
    {
        private int mMaKH;
        private string mTenKH;
        // Constructor không tham số
        public KhachHangConstructor()
        {
            mMaKH = 0;
            mTenKH = "ABC";
        }
        // Constructor có 2 tham số
        public KhachHangConstructor(int MaKH,string TenKH)
        {
            mMaKH = MaKH;
            mTenKH = TenKH;
        }
        // Static Constructor
        static KhachHangConstructor()
        {
            // Các câu lệnh...
            Console.WriteLine("Static Constructor!");
        }
    }
    // Private Constructor
    class KhachHangCPrivate
    {
        private static int mMaKH;
        public static string mTenKH;
        public static void In()
        {
            // Các câu lệnh
            Console.WriteLine("Cac phuong thuc!");
        }
        private KhachHangCPrivate()
        {
            Console.WriteLine("Constructor Private!");
        }
    }
    // Destructors
    class KhachHangDestructor
    {
        private int mMaKH = 0;
        private string mTenKH = "";
        public KhachHangDestructor()
        {
            mMaKH = 0;
            mTenKH = "ABC";
        }
        ~KhachHangDestructor()
        {
            // Các câu lệnh...
            Console.WriteLine("Huy Constructor!");
        }
    }
    // Overloading Methods
    class KhachHangOLMethod
    {
        #region Khai báo các biến
        private int mMaKH;
        private string mTenKH;
        #endregion

        #region Các hàm tạo
        KhachHangOLMethod()
        {
            Console.WriteLine("KhachHangOLMethod!");
        }
        #endregion

        #region Các phương thức
        public void In()
        {
            Console.WriteLine("KhachHangOLMethod.In()");
        }
        public void In(string s)
        {
            Console.WriteLine("KhachHangOLMethod.In(string s)");
        }
        public void In(int n)
        {
            Console.WriteLine("KhachHangOLMethod.In(int n)");
        }
        #endregion
    }
}
