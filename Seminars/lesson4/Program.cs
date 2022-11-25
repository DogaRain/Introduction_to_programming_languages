//Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

//7 -> 28
//4 -> 10
//8 -> 36

/*int FindSum (int a)
{
    int sum = 0;
    for(int i = 1; i <= a; i++)
    {
        sum = sum + i;
    }
    return sum;
}
Console.WriteLine ("Input number");
int number = Convert.ToInt32(Console.ReadLine());
int result = FindSum(number);
Console.WriteLine(result);*/

//Задача 2.Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

//456 -> 3
//78 -> 2
//89126 -> 5

/*int FindDigit (int N)
{
     int count = 0;
    while (N > 0)
    {
        N = N / 10;
        count++;
    }
    return count;
}
Console.WriteLine ("Input number");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindDigit (number));*/

//Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

//4 -> 24
//5 -> 120

/*int FindMult (int N)
{
    int result = 1;
    for (int i = 1; i <= N; i++)
    {
        result = i * result;
    }
    return result;
}
Console.WriteLine ("Input number");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindMult (N));*/

//Задача 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

/*void FillArray (int size)
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0,2);
        Console.Write($"{array[i] } ");
    }
}
Console.WriteLine ("Input array size");
int N = Convert.ToInt32(Console.ReadLine());
FillArray(N);*/

//Другой способ решения этой задачи
 
 int[] CreateRandArray (int size, int minValue, int maxValue)
{
    int [] newArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue+1);
        
    }
    return newArray;
}
void ShowArray (int[] array)
{
    Console.Write("Resulting array -> ");
        for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
}
Console.WriteLine ("Input array size");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input array min");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input array max");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandArray(a,min,max);
ShowArray(myArray);