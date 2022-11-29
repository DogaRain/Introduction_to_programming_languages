int[] CreateRandArray (int size)
{
    int [] newArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine ($"Input array number {i+1}");
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
int[] myArray = CreateRandArray(a);
ShowArray(myArray);
PositiveNumbers(myArray);