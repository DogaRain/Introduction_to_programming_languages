Console.WriteLine("Imput number");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 1)
{
    Console.Write($"{num} odd number");
}
else
{
    Console.Write($"{num} even number");
}