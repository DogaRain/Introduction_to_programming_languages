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
void FindMinSum (int [,] array)
{

int count = 0;
int minSum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minSum = minSum + array[0,i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        
            
        }
        if (sum < minSum)
        { 
        minSum = sum; 
        count = i;
        }
    }
    Console.WriteLine($"Row with minimum amount is {count}");
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
Console.WriteLine();
FindMinSum(MyArray);
