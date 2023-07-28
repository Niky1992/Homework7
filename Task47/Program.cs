//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

void PrintDoubleMassive(double[,] massive)
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

double[,] DoDoubleMassive (int rows, int colums, int minValue, int maxValue)

{
    double [,] result = new double[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            result [i,j] = new Random().Next(minValue, maxValue) / 10.0;
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
double[,] massive = DoDoubleMassive(rows, columns, -100, 100);
PrintDoubleMassive (massive);
