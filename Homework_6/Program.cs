/*Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3


int[] CreateArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write("Введите "+ i + " элемент: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return array;
}

void PositiveElements(int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
            count++;
    }
    Console.WriteLine("Количество положительных чисел: " + count);
}

Console.Write("Сколько чисел желаете ввести? ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(size);
PositiveElements(myArray);
*/

/*Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10


string binnum = "";
Console.Write("Введите десятичное число: ");
int tennum = Convert.ToInt32(Console.ReadLine());
while (tennum > 0)
{
    binnum = tennum % 2 + binnum;
    tennum /= 2;
}
if (binnum == "")
    binnum = "0";
Console.WriteLine(binnum);
*/

/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/

Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine("x = " + x + " y = " + y);