/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/



int Digit(int number)
{

    while (number >= 1000)
    {
        number /= 10;
    }

    int result = number % 10;
    return result;
}

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

if(number >= 100)
{
    Console.WriteLine($"третья цифра числа {number} -> {Digit(number)}");
}
else
    Console.WriteLine("Третьей цифры нет");





// int n = 57;
// int d = GetSecondDigit(n);
// Console.WriteLine(d);
// Console.ReadKey();

// static int GetSecondDigit(int k)
// {
//     while (k >= 1000) k /= 10;
//     int d = k % 10;
//     return d;
// }





