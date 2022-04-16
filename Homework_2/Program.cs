/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1


void SecondNumber(int num)
{
    Console.Write(num + " -> ");
    int n1 = num%100;
    int n2 = n1/10;
    
    Console.Write(n2);
}

Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
SecondNumber(num);
*/

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

void ThirdNumber(int num)
{
    int length = 0;
    int num2 = num;
    while(num > 0)
    {
        num = num / 10;
        length++;
    }

    int stepen = length - 3;
    if(stepen < 0)
    {
        Console.Write("Третьей цифры нет!");
    }
    else
    {
        int thirdnum = (num2 / Convert.ToInt32(Math.Pow(10, stepen))) % 10;
        Console.Write(thirdnum);
    }
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
ThirdNumber(num);

/*
Задача 15: Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
