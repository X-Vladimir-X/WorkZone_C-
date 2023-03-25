// Задача 2
/* Console.Write("Введите первое число: ");
int x = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int y = int.Parse(Console.ReadLine());

int max = 0;

if (x > y)
{
    max = x;
    Console.WriteLine($"{max} Больше");
}
else
{
    max = y;
    Console.WriteLine($"{max} Больше");
}
*/

// Задача 4
/*
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine());

int max = 0;

if (a > b)
{
    if (a > c)
    {
        max = a;
        Console.WriteLine($"max = {max}");
    }
    else
    {
    max = c;
    Console.WriteLine($"max = {max}"); 
    }
    
}
else
{
    if (b > c)
{
    max = b;
    Console.WriteLine($"max = {max}");
}
else
{
max = c;
Console.WriteLine($"max = {max}");
}
}
*/
/* 
if (a > b & a > c)
{
    max = a;
    Console.WriteLine($"max = {max}");
}
else
{
    if (b > c)
    {
        max = b;
        Console.WriteLine($"max = {max}");
    }
    else
    {
        max = c;
        Console.WriteLine($"max = {max}");
    }
}
*/

// Задача 6

/* Console.Write("Введите число и получите ответ , делится ли оно на два: ");
int N = int.Parse(Console.ReadLine());

if (N % 2 == 0)
{
    Console.WriteLine("Число делится на два , оно четное");
}
else
{
    Console.WriteLine("Число не делится на два , оно Не четное");
}
*/

// Задача 8
/*
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

int count = 0;

if (N < 0)
{
    while (count > N+1)
   {
    count -= 2;    
    Console.Write($" {count}");
   }
}
else
{
    while (count < N-1)
   {
    count += 2;    
    Console.Write($" {count}");
   }
}
*/