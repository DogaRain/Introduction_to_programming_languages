int [,,] Create2DRandArray (int row, int row2, int colums)
{
    int[,,] newArray = new int[row,row2,colums];
    for (int i = 0; i < row; i++)
    for (int p = 0; p < row; p++)
        for (int j = 0; j < colums; j++)
        {
            newArray[i,p,j] = new Random().Next(10, 100);
        }    
        return newArray;
}

void Show3DArray (int [,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int p = 0; p < array.GetLength(1); p++)
        {   
            for (int j = 0; j < array.GetLength(2); j++)
            {
                Console.Write(array[i,p,j]+$" [{i},{p},{j}]"+" ");
            } 
        Console.WriteLine();
        }    
}



Console.WriteLine ("Input array first rows");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input array second rows");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input array colums");
int c = Convert.ToInt32(Console.ReadLine());
int[,,] MyArray = Create2DRandArray(a,b,c);
Show3DArray(MyArray);