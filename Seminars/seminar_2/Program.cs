// Задача 10
/*
System.Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

if (number < 0)
{
    number = number * (-1);
}

if (number < 100 | number > 1000)
{
    System.Console.WriteLine("Это не трехзначное число!");
    return;
}
Console.WriteLine($"Введенное число `{number}`");
int SecondNumber = number / 10 % 10;

Console.WriteLine($"Вторая чифра `{secondNumber}`");
*/

// Задача 13
/*
System.Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int count = 0;

if (number < 0)
{
    number = number * (-1);
}

if (number < 100)
{
    System.Console.WriteLine("Третьей цифры нет!");
}

if (number > 99)
{
while (number > 999)
{
    number = number / 10;
}
number %= 10;
System.Console.WriteLine(number);
}
*/

// Задача 15
/*
System.Console.Write("Введите номер дня недели : ");
int number = int.Parse(Console.ReadLine());

if (number < 1 | number > 7)
{
    System.Console.WriteLine("Неделя с нумероваными днями , диапазон от 1 - 7");
}

if (number == 6 | number == 7)
{
    System.Console.WriteLine("Выходной день!");
}

if (number > 0 & number < 6)
{
    System.Console.WriteLine("Это рабочий день ");
}
*/