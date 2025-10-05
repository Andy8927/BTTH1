using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bai03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int year = Convert.ToInt32(Console.ReadLine());

            if(KTNgay(day, month, year))
            {
                Console.WriteLine("Ngay hop le.");
            }
            else
            {
                Console.WriteLine("Ngay KHONG hop le.");
            }
        }

        //Ham kiem tra nam nhuan
        static bool KTNhuan(int yy)
        {
            if ((yy % 4 == 0 && yy % 100 != 0) || yy % 400 == 0)
                return true;
            return false;
        }

        //Tra ve so ngay trong thang
        static int SoNgay(int mm, int yy)
        {
            if (mm == 2)
                return (KTNhuan(yy) == true ? 29 : 28);
            else
                if (mm == 4 || mm == 6 || mm == 9 || mm == 11)
                return 30;
            return 31;
        }

        //Kiem tra ngay nhap vao co hop le khong
        static bool KTNgay(int dd, int mm, int yy)
        {
            if (yy <= 0 || mm > 12 || mm <= 0)
                return false;
            else
                if (dd > SoNgay(mm, yy))
                return false;
            return true;
        }
    }
}
