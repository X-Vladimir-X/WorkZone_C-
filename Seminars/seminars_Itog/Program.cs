// Задача 1: Задайте значение N. Напишите программу, 
//которая выведет все четные натуральные числа в промежутке от m до N .
// Выполнить с помощью рекурсии.
/*
Console.Write("Введите значение M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine());
void che(int m, int n)
{
    if (m > n)
        return;
    if (m % 2 == 0)
    {
        Console.WriteLine($"{m}, ");
    }
    che(m + 1, n);

}
che(m, n);
*/

// Задача 2: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
Console.Write("Введите значение M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine());
int summa(int m, int n)
{
    if (m == n)
        return n;
    else return m + summa(m + 1, n);
}
Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N равно {summa(m, n)}");
*/

// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
/*
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

AkkermanFunction(m, n);


// вызов функции Аккермана
void AkkermanFunction(int m, int n)
{
    Console.WriteLine(Akkerman(m, n));
}

// функция Аккермана
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}
*/

// Задача со звездочкой Найти второй максимум в массиве. 