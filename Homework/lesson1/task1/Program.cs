Console.WriteLine("Imput first number");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Imput second number");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.Write($"max = {num1}");
}
else
{
   Console.Write($"max = {num2}"); 
}