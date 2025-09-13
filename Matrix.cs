using System;

class Matrix
{
    static void Main(string[] args)
    {
        int i, j, k;
        int[,] a = new int[2, 2];
        int[,] b = new int[2, 2];
        int[,] result = new int[2, 2];
        Console.WriteLine("ENTER ELEMENTS OF MATRIX A: ");
        for (i = 0; i < 2; i++)
        {
            for (j = 0; j < 2; j++)
            {
                a[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("ENTER ELEMENTS OF MATRIX B: ");
        for (i = 0; i < 2; i++)
        {
            for (j = 0; j < 2; j++)
            {
                b[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        for (i = 0; i < 2; i++)
        {
            for (j = 0; j < 2; j++)
            {
                result[i, j] = 0;
                for (k = 0; k < 2; k++)
                {
                result[i, j] += a[i, k] * b[k, j];
                }
            }
        }
                for (i = 0; i < 2; i++)
        {
        for (j = 0; j < 2; j++)
        {
                Console.Write(result[i, j] + " ");
        }
        }
    }
}