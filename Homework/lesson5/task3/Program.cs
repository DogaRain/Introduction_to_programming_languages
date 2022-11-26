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
void FindMinMax(int[] array)
{
    int diff = 0;
    int min = array[0];
    int max = array[0];


    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
        if (max < array[i]) max = array[i];
        i++;
    }
    diff = max - min;
    Console.WriteLine($"differance max({max}) of min({min}) is {diff}");
}
Console.WriteLine ("Input array size");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input array min");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input array max");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandArray(a,min,max);
ShowArray(myArray);
FindMinMax(myArray);