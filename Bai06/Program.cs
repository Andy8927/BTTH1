using System;

namespace Bai06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter the number of rows: ");
            int n = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the number of columms: ");
            int m = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the row that needs to be deleted: ");
            int k = Convert.ToInt32(Console.ReadLine());

            int[,]Mar = new int[n, m];

            Input(Mar);

            //Console.WriteLine("The matrix:");
            Output(Mar);
            Console.WriteLine();

            FindMaxMin(Mar);

            Console.WriteLine(FindMaxRow(Mar));
            Console.WriteLine();

            Console.WriteLine(SumNonPrime(Mar));
            Console.WriteLine();

            
            Mar = DeleteRow(Mar, k - 1);
            //Console.WriteLine("The matrix after deleting said row:");
            Output(Mar);
            Console.WriteLine();

            Mar = DeleteColwithBigNum(Mar);
            //Console.WriteLine("The matrix after deleting the columm containing the largest number:");
            Output(Mar);
            Console.WriteLine();

            Console.Beep();
        }

        static void Input(int[,] myMar)
        {
            Random random = new Random();

            for (int i = 0; i < myMar.GetLength(0); i++)
            {
                for (int j = 0; j < myMar.GetLength(1); j++)
                {
                    myMar[i, j] = random.Next();
                }
            }
        }

        static void Output(int[,] myMar)
        {
            Random random = new Random();

            for (int i = 0; i < myMar.GetLength(0); i++)
            {
                for (int j = 0; j < myMar.GetLength(1); j++)
                {
                    Console.Write(myMar[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        //Ham tim so lon nhat, nho nhat trong ma tran
        static void FindMaxMin(int[,] myMar)
        {
            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < myMar.GetLength(0); i++)
            {
                for (int j = 0; j < myMar.GetLength(1); j++)
                {
                    if (myMar[i, j] < min)
                    {
                        min = myMar[i, j];
                    }

                    if (myMar[i, j] > max)
                    {
                        max = myMar[i, j];
                    }
                }
            }

            Console.WriteLine($"The maximum value is: {max}\nThe minimum value is: {min}");
        }

        //Ham tra ve vi tri dong co tong lon nhat
        static int FindMaxRow(int[,] myMar)
        {
            int rowNum = 0;
            int max = 0;

            for (int i = 0; i < myMar.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < myMar.GetLength(1); j++)
                {
                    sum += myMar[i, j];
                }
                if (sum > max)
                {
                    max = sum;
                    rowNum = i;
                }
            }

            return rowNum + 1;
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

        //Ham tinh tong tat ca cac so khong phai la so nguyen to trong ma tran
        static Int64 SumNonPrime(int[,] myMar)
        {
            Int64 sum = 0;

            for (int i = 0; i < myMar.GetLength(0); i++)
            {
                for (int j = 0; j < myMar.GetLength(1); j++)
                {
                    if (!CheckPrime(myMar[i, j]))
                    {
                        sum += myMar[i, j];
                    }
                }
            }

            return sum;
        }

        //Ham xoa dong
        static int[,] DeleteRow(int[,] myMar, int k)
        {
            int rows = myMar.GetLength(0);
            int cols = myMar.GetLength(1);

            if (k < 0 || k >= rows)
            {
                Console.WriteLine("Invaid");
                return myMar;
            }

            int[,] newMar = new int[rows - 1, cols];

            int newRow = 0;
            for (int i = 0; i < rows; i++)
            {
                if (i == k) continue;

                for (int j = 0; j < cols; j++)
                {
                    newMar[newRow, j] = myMar[i, j];
                }
                newRow++;
            }

            return newMar;
        }

        //Ham xoa cot
        static int[,] DeleteCol(int[,] myMar, int k)
        {
            int rows = myMar.GetLength(0);
            int cols = myMar.GetLength(1);

            if (k < 0 || k >= cols)
            {
                Console.WriteLine("Invaid");
                return myMar;
            }

            int[,] newMar = new int[rows, cols - 1];

            for (int i = 0; i < rows; i++)
            {
                int newCol = 0;
                for (int j = 0; j < cols; j++)
                {
                    if (j == k) continue;
                    newMar[i, newCol] = myMar[i, j];
                    newCol++;
                }
            }

            return newMar;
        }

        //Ham xoa cot chua phan tu lon nhat ma tran
        static int[,] DeleteColwithBigNum(int[,] myMar)
        {
            int indexCol = 0;
            int max = 0;

            for (int i = 0; i < myMar.GetLength(0); i++)
            {
                for (int j = 0; j < myMar.GetLength(1); j++)
                {
                    if (myMar[i, j] > max)
                    {
                        max = myMar[i, j];
                        indexCol = j;
                    }
                }
            }

            //Console.WriteLine("The largest number in the Matrix is: " + max);

            return DeleteCol(myMar, indexCol);
        }
    }
}
