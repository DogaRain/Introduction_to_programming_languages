//Задача 1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//78 -> 8
//12-> 2
//85 -> 8
/*
int FindBiggestDigit (int num)
{
    int ed = num % 10;
    int dec = num / 10;
    if (ed > dec)
    {
        return ed;
    }
    else
    {
        return dec;
    }
}

int random = new Random().Next(10, 100);

int result = FindBiggestDigit(random);

Console.WriteLine($"your number -> {random}");
Console.WriteLine($"The biggest digit -> {result}");*/

//2 Задача.Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

//456 -> 46
//782 -> 72
//918 -> 98

/*int CutNumber (int num)
{
    int ed = num % 10;
    int sot = num / 100;
    int res = sot * 10 + ed;
    return res; 
}

int random = new Random().Next(100,1000);
int newNumber = CutNumber(random);
Console.WriteLine($"New version of {random} is {newNumber}");*/

//Задача 3.Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.

//34, 5 -> не кратно, остаток 4
//16, 4 -> кратно

void main (int num1, int num2)
{
    if (num1 % num2 == 0)
    {
        Console.WriteLine($"{num1}, {num2} -> Кратно");
    }
    else
    {
        int num3 = num1 % num2;
        Console.WriteLine($"{num1}, {num2} некратно, остаток {num3}");
    }
    
}
int random1 = new Random().Next(1,100);
int random2 = new Random().Next(1,100);
main(random1, random2);