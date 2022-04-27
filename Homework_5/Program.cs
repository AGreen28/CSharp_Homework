/*Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16

void Exponent(int num1, int num2)
{
    int count = 1;
    int result = num1;
    while(count < num2)
    {
        result = result * num1;
        count++;
    }
    Console.WriteLine(num1 + " в степени " + num2 + " равно: " + result);
}

Console.Write("Ведите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Exponent(numberA, numberB);
*/

/*Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

void SumOfNumbers(int num)
{
    int sum = 0;
    while(num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    Console.WriteLine("Сумма цифр равна: " + sum);
}

Console.Write("Ведите число: ");
int number = Convert.ToInt32(Console.ReadLine());
SumOfNumbers(number);

/*Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/