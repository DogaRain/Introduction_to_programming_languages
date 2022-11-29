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
void PositiveNumbers (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        { 
        count++;
        }
    }
    Console.WriteLine($"in array {count} positive numbers");
}
Console.WriteLine ("Input array size");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input array min");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input array max");
int c = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandArray(a,b,c);
ShowArray(myArray);
PositiveNumbers(myArray);