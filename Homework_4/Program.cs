/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2


int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

void CountEven(int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
            count++;
    }
    Console.WriteLine("Чётных чисел: " + count);
}

int[] myArray = CreateRandomArray(4, 100, 999);
ShowArray(myArray);
CountEven(myArray);
*/

/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0


int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

void EvenPositionSum(int[] array)
{
    int evenPosition = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 > 0)
            evenPosition += array[i];
    }
    Console.WriteLine("Сумма элементов: " + evenPosition);
}

int[] myArray = CreateRandomArray(4, -100, 100);
ShowArray(myArray);
EvenPositionSum(myArray);
*/

/*Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

/*double[] CreateRandomArray(int size, int min, int max)
{
    double[] array = new double[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }

    return array;
}*/

double[] CreateArray(int size)
{
    double[] array = new double[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write("Введите " + i + " элемент: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }

    return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

void MinMaxDifference(double[] array)
{
    double maxNumber = array[0];
    double minNumber = array[0];

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > maxNumber)
            maxNumber = array[i];
        if(array[i] < minNumber)
            minNumber = array[i];
    }
    Console.WriteLine("Разница между max и  min: " + (maxNumber - minNumber));
}

//double[] myArray = CreateRandomArray(5, 0, 100);
double[] myArray = CreateArray(5);
ShowArray(myArray);
MinMaxDifference(myArray);