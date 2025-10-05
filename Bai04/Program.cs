
namespace Bai04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month = Convert.ToInt32(Console.ReadLine());
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(SoNgay(month, year));
        }

        static bool KTNhuan(int yy)
        {
            if ((yy % 4 == 0 && yy % 100 != 0) || yy % 400 == 0)
                return true;
            return false;
        }

        static int SoNgay(int mm, int yy)
        {
            if (mm == 2)
                return (KTNhuan(yy) == true ? 29 : 28);
            else
                if (mm == 4 || mm == 6 || mm == 9 || mm == 11)
                return 30;
            return 31;
        }
    }
}
