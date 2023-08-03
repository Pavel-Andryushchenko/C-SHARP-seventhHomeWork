// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[] ArithmeticMeanColumns(int[,] matrix)
{
    double[] sumColumn = new double[matrix.GetLength(1)];
      for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumColumn[j] = sumColumn[j] + Convert.ToDouble(matrix[i, j]) / matrix.GetLength(0); 
            sumColumn[j] = Math.Round(sumColumn[j], 1);
        }
    }
    return sumColumn;
}

void Print2DMassive(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0, 3:f0}\t", matrix[i, j]);
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

int m = GetInput("Введите колличество строк: ");
int n = GetInput("Введите колличество столбцов: ");
int[,] massive = Create2DMassive(m, n, -99, 99);
Print2DMassive(massive);
Console.WriteLine($"Среднее арифметическое каждого столбца: {string.Join("; ", ArithmeticMeanColumns(massive))}");
