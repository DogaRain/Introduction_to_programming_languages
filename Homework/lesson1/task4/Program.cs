Console.WriteLine("Imput number");
int num = Convert.ToInt32(Console.ReadLine());
int count = 2;
if (num > 0)
{
   
    while (count <= num)
        {
        Console.WriteLine($"{count}");
        count = count + 2;
        }
}

else
{
    num = num - 1;
        while (count <= num)
        {
        Console.WriteLine($"{count}");
        count = count + 2;
        }
}