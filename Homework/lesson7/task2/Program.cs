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
void FindNum(int [,] array, int p, int k)
{
    int i = array.GetLength(0);
    int j = array.GetLength(1);

    if (p >= i || k >= j) Console.WriteLine("this row ot colums does not exist");
    else Console.WriteLine(array[p,k]);
}

Console.WriteLine ("Input array rows");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input array colums");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input array min");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input array max");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input rows you need");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input colums you need");
int d = Convert.ToInt32(Console.ReadLine());
int[,] myArray = Create2DRandArray(min,max,a,b);
Show2DArray(myArray);
FindNum(myArray, c, d);
