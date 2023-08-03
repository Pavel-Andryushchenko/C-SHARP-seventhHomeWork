// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

string SearchElementArray(int[,] mas, int rws, int clm)
{
    string result = string.Empty;
    if ((rws < 1) | (rws > 3) | (clm < 1) | (clm > 4))
    {
        result = "такого числа в массиве нет";
    }
    else
    {
        result = Convert.ToString(mas[rws - 1, clm - 1]);
    }
    return result;
}

void Print2DMassive(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0,4:f0} ", matrix[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] Create2DMassive(int rows, int columns, int startValue, int finishValue)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(startValue, finishValue + 1);
        }
    }
    return matrix;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = 3, columns = 4, startValue = -99, finishValue = 99;
int[,] massive = Create2DMassive(rows, columns, startValue, finishValue);
Console.WriteLine("Исходный массив: ");
Print2DMassive(massive);
int rws = GetInput("Введите номер строки: ");
int clm = GetInput("Введите номер столбца: ");
Console.WriteLine($"{rws}{clm} -> {SearchElementArray(massive, rws, clm)}");