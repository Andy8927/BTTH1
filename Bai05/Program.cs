namespace Bai05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int year = Convert.ToInt32(Console.ReadLine());

            //kiem tra neu ngay hop le thi se in ra ngay trong tuan
            if (KTNgay(day, month, year))
            {
                Console.WriteLine("Ngay hop le.");
                NgayTrongTuan(day, month, year);
            }
            else
            {
                Console.WriteLine("Ngay KHONG hop le.");
            }
        }

        //ham kiem tra nam nhuan
        static bool KTNhuan(int yy)
        {
            if ((yy % 4 == 0 && yy % 100 != 0) || yy % 400 == 0)
                return true;
            return false;
        }

        //ham tra ve so ngay hop le dua vao thang va nam
        static int SoNgay(int mm, int yy)
        {
            if (mm == 2)
                return (KTNhuan(yy) == true ? 29 : 28);
            else
                if (mm == 4 || mm == 6 || mm == 9 || mm == 11)
                return 30;
            return 31;
        }

        //kiem tra ngay hop le
        static bool KTNgay(int dd, int mm, int yy)
        {
            if (yy <= 0 || mm > 12 || mm <= 0)
                return false;
            else
                if (dd > SoNgay(mm, yy))
                return false;
            return true;
        }

        //Xuat ra ngay trong tuan cua ngay ay
        static void NgayTrongTuan(int Day, int Month, int Year)
        {
            int b = (14 - Month) / 12;
            int y = Year - b;
            int m = Month + 12 * b - 2;
            int ans = (Day + y + y / 4 - y / 100 + y / 400 + (31 * m) / 12) % 7;
            switch (ans)
            {
                case 0:
                    Console.WriteLine("Chu Nhat");
                    break;
                case 1:
                    Console.WriteLine("Thu Hai");
                    break;
                case 2:
                    Console.WriteLine("Thu Ba");
                    break;
                case 3:
                    Console.WriteLine("Thu Tu");
                    break;
                case 4:
                    Console.WriteLine("Thu Nam");
                    break;
                case 5:
                    Console.WriteLine("Thu Sau");
                    break;
                case 6:
                    Console.WriteLine("Thu Bay");
                    break;
            }
        }
    }
}
