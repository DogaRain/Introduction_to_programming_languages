int A(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return A(n - 1, 1);
    else
      return A(n - 1, A(n, m - 1));
}

Console.WriteLine("Input first number");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number");
int second = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(A(first,second));