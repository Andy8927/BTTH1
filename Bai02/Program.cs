namespace Bai02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m;
            string n;
            do
            {
                n = Console.ReadLine();
            }
            while (!int.TryParse(n, out m) || m <= 0);
            Console.WriteLine (SumPrime(m));
        }

        //Kiem tra so nguyen to
        static bool CheckPrime(int num)
        {
            bool chek = true;

            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    return chek = false;
                }
            }

            return chek;
        }

        //Ham tinh tong cac so nguyen to be hon so nhap vao
        static Int64 SumPrime(int num)
        {
            Int64 ans = 0;

            for (int i = 2; i < num; i++)
            {
                if (CheckPrime(i))
                {
                    ans += i;
                }
            }

            return ans;
        }
    }
}
