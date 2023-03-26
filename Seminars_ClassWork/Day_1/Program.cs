/*
Console.WriteLine("Введите целое число");
int number = int.Parse(Console.ReadLine());

int result = number * number;

Console.WriteLine($"Квадрат введеного числа = {result}");
*/

// Задача 1:
/*
Console.WriteLine("Введите первое число");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
int numberB = int.Parse(Console.ReadLine());

int numbersqr = numberA * numberA;


if (numbersqr == numberB)
{
    Console.WriteLine("Квадрат первого числа равен второму числу");
}
else
{
    Console.WriteLine("Квадрат второго числа не равен второму числу");
}
*/


// Залача 3:
/*
Console.WriteLine("Введите день недели");
int day = int.Parse(Console.ReadLine());

switch (day)
{
    case 1:
        Console.WriteLine("Понедельник");
        break;
    case 2:
        Console.WriteLine("Вторник");
        break;
    case 3:
        Console.WriteLine("Среда");
        break;
    case 4:
        Console.WriteLine("Четверг");
        break;
    case 5:
        Console.WriteLine("Пятница");
        break;
    case 6:
        Console.WriteLine("Суббота");
        break;
    case 7:
        Console.WriteLine("Воскресенье");
        break;
    default:
        Console.WriteLine("Наши дни недели  идут по порядку от 1 до 7");
        break;
}
*/


// Задача 7
/*
Console.WriteLine("Введите трёхзначное число");
int num = int.Parse(Console.ReadLine());

int res = num % 10;

if (res > 100 & res < 1000)
{
    Console.WriteLine($"Последняя чифра = {res}");
}
else
{
    Console.WriteLine("Нужно вводить трёхзначное число");
}

Console.WriteLine(res);
*/