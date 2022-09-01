// Задайте двумерный массив из целых чисел. Найдите среднее
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write($"{array[m, n]} ");
        }
        Console.WriteLine();
    }
}
double[] Average(int[,] array)
{
    double[] avg = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
            sum += array[j, i];
        avg[i] = sum / array.GetLength(0);
    }
    return (avg);
}

Console.WriteLine("Введите число строк (m)");
if(!int.TryParse(Console.ReadLine()!, out var m)) {
    Console.WriteLine("Всё плохо");
}

Console.WriteLine("Введите число столбцов (n)");
if(!int.TryParse(Console.ReadLine()!, out var n)) {
    Console.WriteLine("Всё плохо");
}
int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое каждого столбца: ");
double[] avg = Average(array);
for (int i = 0; i < avg.Length; i++) Console.Write(avg[i] + " ");