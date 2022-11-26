// Найдите сумму отрицательных и положительных элементов массива.

//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
 
/*int[] CreateRandArray (int size, int minValue, int maxValue)
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

int[] InvertArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= (-1);

    }
    return array;
}
Console.WriteLine ("Input array size");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input array min");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input array max");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandArray(a,min,max);
ShowArray(myArray);
ShowArray(InvertArray(myArray));*/

//Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

//Задача 3.Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

/*int[] CreateArray (int size)
{
    int [] newArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine ($"Input array num {i}");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
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
bool Findnumber(int[] array)
{
    Console.WriteLine($"Input number");
    int number = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) return true;
    }
    return false;
}

    Console.WriteLine ("Input array size");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] myArray = CreateArray(size);
    ShowArray(myArray);
    Console.Write(Findnumber(myArray));*/

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
void FindNumber (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99) count++;
    }
    Console.WriteLine(count);
}
Console.WriteLine ("Input array size");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input array min");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input array max");
int max = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateRandArray(a,min,max);
ShowArray(newArray);
FindNumber(newArray);