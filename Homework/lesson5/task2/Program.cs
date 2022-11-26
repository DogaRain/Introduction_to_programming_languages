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
int SumOddIndx(int[] array)
{
    sum = 0;
    for (int i = 1; i < length; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
}
Console.WriteLine ("Input array size");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input array min");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input array max");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandArray(a,min,max);
ShowArray(myArray);
ShowArray(InvertArray(myArray));
