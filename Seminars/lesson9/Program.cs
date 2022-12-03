//Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"

/*void ShowNumbers(int n)
{
    if(n >= 1)
    {
        ShowNumbers(n-1);
        Console.Write(n+" ");
    }
}
Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());
ShowNumbers(num);*/

//Задание 2. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

//453 -> 12
//45 -> 9

/*int FindSum (int num)
{
    if(num > 0)
    {
        return FindSum(num/10) + num%10;

    }
    return num;
}

Console.WriteLine("Input number");
int n = Convert.ToInt32(Console.ReadLine());
int sum = FindSum(n);
Console.WriteLine($"{sum}");*/

//Задача 3. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 5, 6, 7, 8"

/*void NaturalNumbers (int M, int N)
{
    if(M != N)
    {
        if(M >= N)
        {
            Console.WriteLine(N+" ");
            NaturalNumbers(M, N+1);
        }
        else
        {
            Console.Write(M+" ");
            NaturalNumbers(M+1, N); 
        }
    }
    else Console.Write (M + " ");
}
Console.WriteLine("Input first number");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number");
int second = Convert.ToInt32(Console.ReadLine());
NaturalNumbers(first,second);*/
//Задача 4.Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

//A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8

/*int powNumber (int a, int b)
{
    if (b > 1)
    {
        return a * powNumber (a, b - 1);
    }
    return a;
}
Console.WriteLine("Input number");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input degree");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{A} in {B} degree is {powNumber(A,B)}");*/