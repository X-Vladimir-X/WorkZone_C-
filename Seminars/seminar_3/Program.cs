// Задача 19
/*
bool isPalindrome(int number)
{
    int revers = 0;
    int sourceNumber = number;

    while (sourceNumber != 0)
    {
        int pop = sourceNumber % 10;
        sourceNumber = sourceNumber / 10;

        revers = (revers * 10) + pop;
    }
    bool isResult = revers == number;
    return isResult;
}
bool result = isPalindrome(12821);
System.Console.WriteLine(result);
*/

// Задача 21

// Формула вычисления расстояния между двумя точками A(xa, ya) и B(xb, yb) на плоскости: AB = √((xb - xa)2 + (yb - ya)2).

/*
System.Console.WriteLine("Ввести xa");
double xa = double.Parse(Console.ReadLine());

System.Console.WriteLine("Ввести ya");
double ya = double.Parse(Console.ReadLine());

System.Console.WriteLine("Ввести xb");
double xb = double.Parse(Console.ReadLine());

System.Console.WriteLine("Ввести yb");
double yb = double.Parse(Console.ReadLine());

double x = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));
System.Console.WriteLine(Math.Round(x, 2, MidpointRounding.ToNegativeInfinity));
*/

// Задача 23
/*
double cubo(double arg)
{
    arg = Math.Abs(arg);

    double count = 0;
    double x = 1;

    while (x <= arg)
    {

        if (x == arg)
        {
            count = Math.Pow(x, 3);

            System.Console.Write(count);

            break;
        }

        count = Math.Pow(x, 3);

        System.Console.Write($"{count}, ");

        x++;
    }
    return count;
}

System.Console.Write("Введите число N: ");
double n = double.Parse(Console.ReadLine());

cubo(n);
*/