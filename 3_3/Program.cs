// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintArray(double[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}

double[,] FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(0,10);
        }
    }
    return matr;
}

void ResultFoo(double[,] matr)
{
    double Res=0;
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        Res=0;
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            Res = Res + matr[j,i];
        }
        Console.WriteLine($"Среднее арифметическое элементов в столбце {i+1}: {Math.Round(Res/3,2)}");
    }
}

void foo()
{
    double[,] mass = new double[3,4];
    mass = FillArray(mass);
    PrintArray(mass);
    ResultFoo(mass);
}

foo();