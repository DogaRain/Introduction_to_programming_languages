void FindIntersection (double k1, double b1, double k2, double b2)

{
    double x = (b2 - b1 ) / (k1 - k2);
    double y = k1 * (b2 - b1) / ( k1 - k2) + b1;

    Console.Write($"the point of intersection of two straight lines is {(x, y)}");
}

Console.WriteLine("Input k1");
double a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input b1");
double b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input k2");
double c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input b2");
double d = Convert.ToInt32(Console.ReadLine());

FindIntersection(a,b,c,d);