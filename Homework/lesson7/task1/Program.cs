double [,] Create2DRandArray (double minValue, double maxValue, int rows, int colums)
{
    double[,] newArray = new double[rows,colums];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
        {
            newArray[i,j] = new Convert.ToDouble(Random.Next(-100, 100)/10.0);
        }    
        return newArray;
}
void Show2DArray (double [,] array)
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
Console.WriteLine ("Input array rows");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input array colums");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input array min");
double min = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("Input array max");
double max = Convert.ToDouble(Console.ReadLine());
Show2DArray(Create2DRandArray(min,max,a,b));