namespace Bai01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nhap so phan tu cua mang
            int m;
            string n;
            do
            {
                n = Console.ReadLine();
            }
            while (!int.TryParse(n,out m) || m <= 0);

            

            int[] arr = new int[m];

            //Ham Input cua mang, da co random nen khong can nhap truc tiep
            Input(arr);

            //Ham xuat de kiem tra mang
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            //Tong cua cac so le trong mang
            Console.WriteLine(OddSum(arr));

            //Kiem tra mang co bao nhieu so nguyen to
            Console.WriteLine(CheckPrimeinArr(arr));

            //Ham in ra so chinh phuong nho nhat (Neu co)
            Console.WriteLine(CheckCP(arr));
            
        }
        static void Input(int[] myArr)
        {
            Random random = new Random();

            for (int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = random.Next();
            }
        }

        static Int64 OddSum(int[] myArr)
        {
            Int64 oddTotal = 0;
            foreach (int i in myArr)
            {
                if (i % 2 == 1)
                {
                    oddTotal += i;
                }
            }

            return oddTotal;
        }

        static bool CheckPrime(int num)
        {
            bool chek = true;

            for (int i = 2; i * i < num; i++)
            {
                if (num % i == 0)
                {
                   return chek = false;
                }
            }

            return chek;
        }

        static int CheckPrimeinArr(int[] myArr)
        {
            int times = 0;

            foreach (int i in myArr)
            {
                if (CheckPrime(i) == true)
                {
                    times++;
                }
            }

            return times;
        }

        static int CheckCP(int[] myArr)
        {
            int smallCP = -1;

            foreach(int i in myArr)
            {
                if(Convert.ToInt32(Math.Sqrt(i)) == Math.Sqrt(i))
                {
                    smallCP = i; break;
                }
            }
            if (smallCP == -1) return -1;

            foreach (int i in myArr)
            {
                if (Convert.ToInt32(Math.Sqrt(i)) == Math.Sqrt(i))
                {
                    if (i < smallCP)
                    {
                        smallCP = i;
                    }
                }
            }

            return smallCP;
        }
    }
}