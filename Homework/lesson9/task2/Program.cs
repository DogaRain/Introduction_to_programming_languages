int NaturalNumbers (int M, int N)
{
    if(M != N)
    {
        if(M >= N)
        {
            return N + NaturalNumbers(M, N+1);
        }
        else
        {
            return M + NaturalNumbers(M+1, N);
        }
    }
    else return N;
}
Console.WriteLine("Input first number");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number");
int second = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NaturalNumbers(first,second));