// Задача 25
/*
double step(double a, double b)
{
    double result = Math.Pow(a, b);
    return result;
}

System.Console.Write("Введите число A: ");
double a = double.Parse(Console.ReadLine());

System.Console.Write("Введите число B: ");
double b = double.Parse(Console.ReadLine());

double number = step(a, b);
System.Console.WriteLine($"{a} v stepeni {b} = {number}");
*/

//Задача 27
/* 
int sumnumbers(int x)
{
    int result = 0;
    int y = 0;

    while (x != 0)
    {
        y = x % 10;
        x = x / 10;
        result = result + y;
    }

    return result;
}

System.Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

int answer = sumnumbers(n);
System.Console.WriteLine($"Сумма цифер в числе: {answer}");
*/

// Задача 29
/*
int[] arr = new int[8];

void fillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($" {array[i]}");
    }
}

System.Console.WriteLine("Просто нажмите ENTER, программа создаст массив из случайных 8ми цифр в диапазоне 0-99!");
Console.ReadLine();

fillArray(arr);
printArray(arr);

*/