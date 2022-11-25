int  NumDegree (int A, int B)
{
    int count = 1;
    int prod = 1;
    while (count <= B)
    {
        prod = prod * A;
        count++;
    }
    Console.Write($"{A} in {B} degree =");
    return prod;
}
Console.WriteLine ("Input number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input Degree");
int num2 = Convert.ToInt32(Console.ReadLine());
int result = NumDegree(num1, num2);
Console.Write($" {result}");