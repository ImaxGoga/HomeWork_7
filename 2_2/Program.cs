// Задача 50. Напишите программу, которая на вход принимает число, и возвращает индексы этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

void SearchNumInArray(double[,] matrix, int number)
{
    int flag = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j] == number) flag = 1;
        }
    }
    if(flag == 1)
    Console.WriteLine($"Число {number} есть в массиве!");
    else Console.WriteLine($"Числа {number} нет в массиве!");
}

void foo()
{
    double[,] mass = new double[3,4];
    mass = FillArray(mass);
    PrintArray(mass);
    Console.WriteLine();
    Console.Write("Введите число для поиска в массиве: ");
    int num = Convert.ToInt32(Console.ReadLine());
    SearchNumInArray(mass, num);
}

foo();