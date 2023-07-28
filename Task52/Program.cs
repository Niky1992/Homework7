//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintArithmeticMeanColumns(int[,] massive)
{
    Console.Write("Среднее арифмитическое каждого столбца: ");
    double result = 0;
    for (int i = 0; i < massive.GetLength(1) - 1; i++)
    {
        for (int j = 0; j < massive.GetLength(0); j++)
        {
            result = massive[j, i] + result;
        }
        Console.Write($"{Math.Round((result / massive.GetLength(0)), 2)}; ");
    }

    double resultLast = 0;

    for (int i = 0; i < massive.GetLength(0); i++)
    {
        resultLast = massive[i, massive.GetLength(1) - 1] + resultLast;
    }
    Console.Write($"{Math.Round((resultLast / massive.GetLength(0)), 2)}");
}

void PrintDoubleMassive(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] DoDoubleMassive (int rows, int colums, int minValue, int maxValue)
{
    int [,] result = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    } 
    return result;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = GetInfo("Введите число строк: ");
int columns  = GetInfo("Введите число столбцов: ");
int[,] massive = DoDoubleMassive(rows, columns, 0, 9);
PrintDoubleMassive(massive);
Console.WriteLine("");
PrintArithmeticMeanColumns(massive);
