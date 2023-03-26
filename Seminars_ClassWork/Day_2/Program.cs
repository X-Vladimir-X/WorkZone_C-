/*
Console.WriteLine("Введите первое число");
int number_1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
int number_2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число");
int number_3 = int.Parse(Console.ReadLine());

int max = number_1;

if (number_2 > max)
{
    max = number_2;
}

if (number_3 > max)
{
    max = number_3;
}

Console.WriteLine($"Найбольшее число = {max}");

*/

// Напишите порограмму которая выводит случайное число из отрезка ( 10, 99)
//  и показывает наибольшее цуфру числа.

/*
// случайное число из отрезка 
int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число: {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

if (firstDigit > secondDigit)
{
    Console.WriteLine(firstDigit);
}
else
{
    Console.WriteLine(secondDigit);
}

*/

// Выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

/*
int n = new Random().Next(100, 1000);
Console.WriteLine($"Сгенерированое число: {n}");

int result = (n / 100 * 10) + (n % 10);
Console.WriteLine(result);
*/

// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

/*
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());

if (a % b == 0)
{
    Console.WriteLine($"{a} кратно {b}");
}
else
{
    Console.WriteLine($"{a} не кратно {b}, остаток {a % b}");
}

*/


// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.

/*
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());

//if (a % 7 == 0 && a % 23 == 0)
//{
//    Console.WriteLine("Да");
//}
//else
//{
//Console.WriteLine("Нет");
//}

bool result = a % 7 == 0 && a % 23 == 0;

Console.WriteLine(resalt);
*/

