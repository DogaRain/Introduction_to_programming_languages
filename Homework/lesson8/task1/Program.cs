int [,] Create2DRandArray (int minValue, int maxValue, int rows, int colums)
{
    int[,] newArray = new int[rows,colums];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue+1);
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

int[,] OrderingArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int row = array.GetLength(0); row > 0 ; row--)
            for (int j = 1; j < array.GetLength(1); j++)
                if (array[i,j-1] < array[i,j])
                {
                int temp = array[i,j-1];
                array[i,j-1] = array[i,j];
                array[i,j] = temp;
                }

    return array;
}

Console.WriteLine ("Input array rows");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input array colums");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input array min");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input array max");
int max = Convert.ToInt32(Console.ReadLine());
int[,] MyArray = Create2DRandArray(min,max,a,b);
Show2DArray(MyArray);
MyArray = OrderingArray(MyArray);
Console.WriteLine();
Show2DArray(MyArray);