int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(0,10);
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}

void PrintArray(int[,] matrix)
{
    Console.WriteLine();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
    Console.WriteLine();
    }
}

/*Задача 54: Задайте двумерный массив. Напишите программу,
которая упорядочит по возрастанию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8
*/

int[,] SortNumsInString(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, j] > array[i, k])
                {
                int tmp = array[i, j];
                array[i, j] = array[i, k];
                array[i, k] = tmp;
                }
            }
        }
    }
    return array;
}

Console.Write("Введите количество строк: ");
int height = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int length = Convert.ToInt32(Console.ReadLine());

PrintArray(SortNumsInString(CreateArray(height, length)));

/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

/*Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7
*/