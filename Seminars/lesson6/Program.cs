//Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте,
//а первый - на последнем и т.д.)

//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

/*int[] CreateRandArray (int size, int minValue, int maxValue)
{
    int [] newArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue+1);
        
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

int[] ReverseArray (int[] array)
{
    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int  temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    return array;
}
Console.WriteLine ("Input array size");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input array min");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input array max");
int max = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateRandArray(a,min,max);
ShowArray(newArray);
ShowArray(ReverseArray(newArray));*/

//Задача 2.Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

/*bool CheckTriangle (int a, int b, int c)
{
    if (a+b>c && b+c>a && a+c>b)
    return true;
    return false;
}

int CheckNumber ()
{
    int x = Convert.ToInt32(Console.ReadLine());
    if(x<-0) return CheckNumber();
    else return x;
}

Console.WriteLine("Input Length A:");
int a = CheckNumber();
Console.WriteLine("Input Length B:");
int b = CheckNumber();
Console.WriteLine("Input Length C:");
int c = CheckNumber();

Console.WriteLine(CheckTriangle(a,b,c));*/

//Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.



//числа фибоначчи последовательность чисел в которой первые 2 числа это 0 и 1, а последубщие это сумма двух передыдущих
//[0, 1,2, 3, 5, 8, 13, ... ]

/*int[] Fibinachi(int a, int b, int n)
{
    int [] NewArray = new int [n];
    NewArray[0] = a;
    NewArray[1] = b;
    for (int i = 2; i < n; i++)
    {
        NewArray[i] = NewArray[i-1] + NewArray[i-2];
    }
    return NewArray;
}
void ShowArray (int[] array)
{
    Console.Write("Resulting array -> ");
        for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
}
Console.WriteLine("Input number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number C: ");
int c = Convert.ToInt32(Console.ReadLine());
ShowArray(Fibinachi(a,b,c));*/

//Задача 4. ****Напишите программу, которая будет преобразовывать десятичное число в двоичное.

//45 -> 101101
//3 -> 11
//2 -> 10

string TransformToBinary(int num)
{
    string result = String.Empty;
    int BinaryNumber;
    while (num > 0)
    {
        BinaryNumber = num % 2;
        result = BinaryNumber + result;
        num = num / 2;
    }
    return result;
}
Console.WriteLine("Input number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(TransformToBinary(a));

