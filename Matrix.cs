using System;

class Matrix
{
    static void Main(string[] args)
    {
        int i, j, k;
        int[,] a = new int[2, 2]; // Создание массива a размером 2x2
        int[,] b = new int[2, 2]; // Создание массива b размером 2x2
        int[,] result = new int[2, 2]; // Создание массива result размером 2x2
        Console.WriteLine("MATRIX MULTIPLICATION"); // Вывод названия программы
        Console.WriteLine("ENTER ELEMENTS OF MATRIX A: "); // Вывод предложения ввести значения в массив a
        for (i = 0; i < 2; i++) // Цикл ввода значений в массив a
        {
            for (j = 0; j < 2; j++)
            {
                a[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("ENTER ELEMENTS OF MATRIX B: "); //Вывод предложения ввести значения в массив b
        for (i = 0; i < 2; i++) // Цикл ввода значений в массив b
        {
            for (j = 0; j < 2; j++)
            {
                b[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        for (i = 0; i < 2; i++) // Цикл, совершающий умножение матриц a и b и сохраняющий результат в массив result
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
        Console.WriteLine("RESULT: ");
        for (i = 0; i < 2; i++)
        {
            for (j = 0; j < 2; j++) // Цикл вывод результата умножения
            {
                Console.Write(result[i, j] + " ");
            }
        }
    }
}