int [,] CreateArray(int size)
{
int[,] newArray = new int[size,size];
int num = 1;
int i = 0;
int j = 0;

    while (num <= size * size)
    {
        newArray[i, j] = num;
        if (i <= j + 1 && i + j < size - 1)
            ++j;
        else if (i < j && i + j >= size - 1)
            ++i;
        else if (i >= j && i + j > size - 1)
            --j;
        else
            --i;
        ++num;
        }
        return newArray;
}
void Show2DArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] +" ");
        } 
        Console.WriteLine();
    }    
}
Console.WriteLine ("Input array size");
int a = Convert.ToInt32(Console.ReadLine());
Show2DArray(CreateArray(a));