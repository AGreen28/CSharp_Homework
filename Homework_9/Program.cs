/*Задача 66: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30


Console.Write("Введите первое значение: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе значение: ");
int m = Convert.ToInt32(Console.ReadLine());

int sum = 0;
if(n < m)
{
    while(n <= m)
    {
    sum = sum + n;
    n++;
    }
}
else
    while(m <= n)
    {
    sum = sum + m;
    m++;
    }
Console.WriteLine(sum);
*/

/*Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int sum = 0;
while(num > 0)
{
    sum = sum + num % 10;
    num = num / 10;
}
Console.WriteLine(sum);