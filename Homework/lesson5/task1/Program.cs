int[] CreateRandArray (int size)
{
    int [] newArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(100, 1000);
        
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
int[] EvenNumbers (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        { 
        count++;
        }
    }
    Console.WriteLine($"in array {count} even numbers");
    return array;
}
Console.WriteLine ("Input array size");
int a = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandArray(a);
ShowArray(myArray);
Console.WriteLine(EvenNumbers(myArray));