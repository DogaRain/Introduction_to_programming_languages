
/*Console.WriteLine("Imput number");
int num = Convert.ToInt32(Console.ReadLine());
int quad = num * num;
Console.Write($"quad of {num} -> {quad}");*/

//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.//

/*a = 25; b = 5 -> да
a = 2 b = 10 -> нет
a = 9; b = -3 -> да
a = -3 b = 9 -> нет*/

/*Console.WriteLine("Imput number 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput number 2");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad = num2 * num2;

if (quad == num1)
{
Console.WriteLine($"{num1} is quad of {num2}");
}
else
{
Console.WriteLine($"{num1} is not quad of {num2}");
}*/

//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.//

/*4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"*/

/*Console.WriteLine("Imput number");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
{
    int num2 = num * -1;

    while (num2 < num)
        {
        Console.WriteLine($"{num2}");
        num2++;
        }
    Console.WriteLine($"{num}");
}

else
Console.WriteLine("Wrong number");*/

//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает **последнюю** цифру этого числа.//

/*456 -> 6

782 -> 2

918 -> 8*/

/*Console.WriteLine("Imput number");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (Math.Abs(num) % 10);*/