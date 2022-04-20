/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да 

void Palindrome(int number)
{
    if(number < 10000 || number > 99999)
        Console.WriteLine("Это не пятизначное число!");
        
    else
    {
        if(number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10)
            Console.WriteLine("Это число является палиндромом.");
        else
            Console.WriteLine("Это число не является палиндромом.");
    }
}

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Palindrome(number);
*/

/* Задача 21 
Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

double FindLength(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double length = Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA) + (zB - zA) * (zB - zA));
    return length;
}

Console.Write("Ведите xA: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите yA: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите zA: ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите xB: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите yB: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите zB: ");
double zB = Convert.ToDouble(Console.ReadLine());
double result = FindLength(xA, yA, zA, xB, yB, zB);
Console.WriteLine("Расстояние равно: " + result);

/* Задача 23
Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */
