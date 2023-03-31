// Палиндром
/*
bool isPalindrome(int number)
{
    int revNumber = 0;
    int sourseNumber = number;

    while (sourseNumber != 0)
    {
        int pop = sourseNumber % 10;
        sourseNumber = sourseNumber / 10;

        // формирование нового числа (обратрое от исходного)
        revNumber = (revNumber * 10) + pop;
    }

    bool isResult = revNumber == number;

    return isResult;

}


bool result = isPalindrome(134431);
Console.WriteLine(result);
*/

// Задача 24 Задача 24: Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.
/*
int GetSumRange(int startNumber, int endNumber)
{
    int sum = 0;
    for (int i = startNumber; i <= endNumber; i++)
    {
        sum += i;
    }

    return sum;
}

// Запрос исходного числа от пользователя
Console.WriteLine("Введите число А: ");
int a = int.Parse(Console.ReadLine());

int sum = GetSumRange(1, a);
Console.WriteLine(sum);
*/

// Задача 26: Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе.
/*
int GetCountDigit(int number)
{
    int count = 0;
    int numberA = number;
    while (numberA != 0)
    {
        numberA = numberA / 10;
        count++;
    }

    return count;
}


Console.Write("Введите число : ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine($"Количество цифр {GetCountDigit(a)}");
*/

// Задача 28: Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
/*
int GetMultiplay(int startNumber, int endNumber)
{
    int mlt = 1;
    for (int i = startNumber; i <= endNumber; i++)
    {
        mlt = mlt * i;
    }

    return mlt;
}

// Запрос исходного числа от пользователя
Console.WriteLine("Введите число : ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine($"Произведение чисел от 1 до {a} равна {GetMultiplay(1, a)}");
*/

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
/*
int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 2);
}

void PrintArray(int[] num)
{
    int count = 0;
    while (count < num.Length)
    {
        if (count == num.Length - 1)
        {
            Console.WriteLine($"{num[count]}");
            break;
        }
        Console.Write($"{num[count]}, ");
        count++;
    }
}

PrintArray(array);
*/