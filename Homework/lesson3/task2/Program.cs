﻿double FindLegth(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double Len = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    double Len2 = Math.Round(Len, 2);
    return Len2;
}
Console.WriteLine("Imput Coordinate number X1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput Coordinate number Y1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput Coordinate number Z1");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput Coordinate number X2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput Coordinate number Y2");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput Coordinate number z2");
int z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindLegth(x1, y1, z1, x2, y2, z2));