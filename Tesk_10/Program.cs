// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

Console.WriteLine("Введите трехзначное число");
int randomNum = Convert.ToInt32(Console.ReadLine());

FindSecondDigit(randomNum);

void FindSecondDigit(int nam)
{
    if (nam < 1000)
    {
        Console.WriteLine(nam % 100 / 10);
    }
}   



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
int randomNum = Convert.ToInt32(Console.ReadLine());

FindThirdDigital(randomNum);

void FindThirdDigital(int nam1)
{
    if (nam1 < 100)
    {
        Console.WriteLine("третьей цифры нет");
    }
    else
    {
        while (nam1 >= 1000)
        {
            nam1 = nam1 / 10;
        }
        Console.WriteLine(nam1 % 10);
    }
}


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели от 1 до 7");
int numDay = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int namDay)
{
   if (namDay == 6 || namDay == 7)
   {
    Console.WriteLine("этот день выходной");
   }
   else
   Console.WriteLine("этот день не выходной");
}   
CheckingTheDayOfTheWeek (numDay);