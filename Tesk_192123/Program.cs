// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - НЕ палиндром");
    }
}



// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N..

Console.WriteLine("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

void GetCubeNamber(int num)
{
    int count = 1;
    while (count <= Math.Abs(num))
    {
        Console.WriteLine($"куб числа {count} = {Math.Pow(count,3)}");
        count++;
    }
}

GetCubeNamber(numberN);

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int x1 = ReadInt("Введите координату X первой точки: ");
int y1 = ReadInt("Введите координату Y первой точки: ");
int z1 = ReadInt("Введите координату Z первой точки: ");
int x2 = ReadInt("Введите координату X второй точки: ");
int y2 = ReadInt("Введите координату Y второй точки: ");
int z2 = ReadInt("Введите координату Z второй точки: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длинна отрезка {length}");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
