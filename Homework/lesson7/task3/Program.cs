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
void ArithmeticMean (int [,] array)
{  
    for (int j = 0; j < array.GetLength(1); j++) 
    {
    double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i,j];
        }
        double ArtM = sum / array.GetLength(0);
        ArtM = Math.Round(ArtM,2);
        Console.Write(ArtM+" ");    
    }
    Console.Write($" <-- ArithmeticMean");
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
ArithmeticMean(MyArray);
