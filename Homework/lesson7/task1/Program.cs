double [,] Create2DRandArray (int rows, int colums)
{
    double[,] newArray = new double[rows,colums];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
        {
            newArray[i,j] = new Random().NextDouble() * 10;
            newArray[i,j] = Math.Round(newArray[i,j], 2);
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

Show2DArray(Create2DRandArray(a,b));