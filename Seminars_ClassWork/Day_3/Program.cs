/* while 
// не знаем сколько раз  надо сделать
int count = 0;

while (count < 100)
{
    Console.WriteLine($"{count}. Hello World");
    count++;
}

Console.WriteLine("Выход из цикла while");

// for

for (int i = 10; i < 100; i++)
{
    Console.WriteLine($"{i}.Hello World");
}

Console.WriteLine("Выход из цикла For");

*/

// Задача 18. Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).
/*
Console.WriteLine("Введите координаты x");
int x = int.Parse(Console.ReadLine());

switch (x)
{
    case 1:
        Console.WriteLine("x > 0; y > 0");
        break;

    case 2:
        Console.WriteLine("x < 0; y > 0");
        break;

    case 3:
        Console.WriteLine("x > 0; y < 0");
        break;

    case 4:
        Console.WriteLine("x < 0; y < 0");
        break;

    default:
        Console.WriteLine("Неправильное число");
        break;
}
*/


// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояниемежду ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
/*
Console.WriteLine("Введите координаты xa");
double xa = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты ya");
double ya = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты xb");
double xb = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты yb");
double yb = double.Parse(Console.ReadLine());

double x = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));

Console.WriteLine(Math.Round(x, 2, MidpointRounding.ToNegativeInfinity));
*/

//  Задача 22. Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.


Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine());

for (int i = 1; i <= x; i++)
{
    if (i == x)
    {
        Console.WriteLine(i * i);
        break;
    }
    Console.Write(i * i + ", ");
}