/*Задача 66: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

int SumNums(int a, int b)
{
    int sum = 0;
    if(a < b - 1)
        sum = a + SumNums(a + 1, b);
    else if(a -1 > b)
        sum = b + SumNums(b + 1, a);
    else sum = a + b;
    return sum;
}

Console.Write("Введите первое значение: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе значение: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumNums(n, m));
*/

/*Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

int SumOfNums(int num)
{
    if(num == 0)
        return 0;
    else
        return num % 10 + SumOfNums(num / 10);
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumOfNums(num));
