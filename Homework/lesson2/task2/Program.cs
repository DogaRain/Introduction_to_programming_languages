void FindThirdNum (int num)
{
    if (num > 99 && num < 1000)
    {
        int num2 = num % 10;
        Console.WriteLine($"third num -> {num2}");  
    }
    else
    {
       Console.WriteLine("not a three-digit number");
    }
}
int random = new Random().Next(1, 1000);

FindThirdNum (random);

Console.WriteLine($"Your number -> {random}");