/*int FindQuart (double x, double y)
{
    if (x > 0 && y > 0)
    return 1;
    if (x < 0 && y > 0)
    return 2;
    if (x < 0 && y < 0)
    return 3;
    if (x > 0 && y < 0)
    return 4;

    return 0;
}
Console.WriteLine("Imput coordinate X");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Imput coordinate Y");
double y = Convert.ToDouble(Console.ReadLine());
int result = FindQuart(x,y);
Console.WriteLine($"Quart number of our point is {result}");*/

//Задача 2.Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

/*void FindCoordinats (int quart)
{
    if (quart < 1 || quart > 4)
    Console.WriteLine("такой четверти не существует!");
    if (quart == 1)
    Console.WriteLine("Диапозон координат в I четверти (x>0, y>0)");
    if (quart == 2)
    Console.WriteLine("Диапозон координат в II четверти (x<0, y>0)");
    if (quart == 3)
    Console.WriteLine("Диапозон координат в IV четверти (x<0, y<0)");
    if (quart == 4)
    Console.WriteLine("Диапозон координат в V четверти (x>0, y<0)");
}
Console.WriteLine("Введите номер координат");
int quart = Convert.ToInt32(Console.ReadLine());
FindCoordinats (quart);*/

//Задача 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21
//√ (x 2 - x 1) 2 + (y 2 - y 1) 2

/*double FindLegth(double x1, double y1, double x2, double y2)
{
    double Len = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
    return Len;
}
Console.WriteLine("Введите номер координат X1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер координат Y1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер координат X2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер координат Y2");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindLegth(x1, y1, x2, y2));*/



//Задача 4. Напишите программу которая принимает на вход число (N) и выдает на консоль квадраты чисел от 1 до N

/*void SqrAll (int N)
{
    for (int i = 1; i <= N; i++)
    {
        Console.WriteLine($"{i} -> {i * i}");
    }
}
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
SqrAll(N);*/

