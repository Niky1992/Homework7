//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

string PositionInMassive (int[,] massive, int rows, int columns)
{
    if (massive.GetLength(0) > rows && massive.GetLength(1) > columns)
    return $"такая позиция есть в массиве: {massive[rows, columns]}";
    else return "такой позиции нет в массиве";
}

string NumberInMassive (int[,] massive, int number)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            if (number == massive[i, j]) return "такое число есть в массиве";
        }
    }
    return "такого числа нет в массиве";
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
PrintDoubleMassive (massive);
int number = GetInfo("Введите число, которое надо найти: ");
Console.WriteLine($"Число {number} -> {NumberInMassive(massive, number)}");
int findRows = GetInfo("Введите номер строки: ") - 1;
int findColums = GetInfo("Введите номер столбца: ") - 1;
Console.WriteLine($"{PositionInMassive(massive, findRows, findColums)}");
