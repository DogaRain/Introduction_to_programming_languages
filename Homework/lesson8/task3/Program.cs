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
int[,] ProductOfTwoMatrices (int[,]array, int[,]array2)
{
    int[,] result = new int[array.GetLength(0), array2.GetLength(1)];
    if(array.GetLength(1) == array2.GetLength(0))
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                result[i,j] = 0;
                for (int n = 0; n < array.GetLength(1); n++)
                {
                    result[i, j] += array[i, n] * array2[n, j];
                }
            }
        }
    return result;
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
int[,] MyArray2 = Create2DRandArray(min,max,a,b);
Show2DArray(MyArray);
Console.WriteLine();
Show2DArray(MyArray2);
Console.WriteLine();
Show2DArray(ProductOfTwoMatrices(MyArray,MyArray2));

