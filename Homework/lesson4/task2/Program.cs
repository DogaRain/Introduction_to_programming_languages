int Sum (int N)
{
    int sum = 0;
    while (N > 0)
    {
    int ed = N % 10;
    N = N / 10;
    sum = sum + ed; 
    } 
    return sum;
}
Console.WriteLine("Input number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"numbers sum of {a} = {Sum(a)}");
