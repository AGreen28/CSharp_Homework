/*Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

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

/*Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/


/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/