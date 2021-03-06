/*Задача 47. Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9


Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[m,n];
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        matrix[i,j] = new Random().NextDouble();
        Console.Write(Math.Round(matrix[i,j], 1) + " ");
    }
    Console.WriteLine();
}
*/

/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет


int[,] matrix = new int[3,4];
for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0,10);
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите номер строки: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int n = Convert.ToInt32(Console.ReadLine());

if(m <= matrix.GetLength(0) && n <= matrix.GetLength(1))
    Console.WriteLine(matrix[m-1,n-1]);
else
    Console.WriteLine("Такого числа в массиве нет.");
*/

/*Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

void ColumnsArithmeticMean(int[,] column)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for(int j = 0; j < column.GetLength(1); j++)
    {
        int sum = 0;
        for(int i = 0; i < column.GetLength(0); i++)
        { 
            sum += column[i,j];
        }
        double middle = Convert.ToDouble(sum) / Convert.ToDouble(column.GetLength(0));
        Console.Write(Math.Round(middle, 1) + "; ");
    }
}    

int[,] matrix = new int[3,4];
for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0,10);
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}

ColumnsArithmeticMean(matrix);