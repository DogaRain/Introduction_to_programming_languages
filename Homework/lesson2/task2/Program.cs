void FindThirdNum (int num)
{
    if (num > 99)
    {
        while (num > 999)
        {
            num = num / 10;  
        }
        num = num % 10;
        Console.Write($"the third digit -> {num}, ");
    }
    else
    {
       Console.WriteLine("not a three-digit number");
    }
}
int random = new Random().Next(1, 100000);

FindThirdNum (random);

Console.Write($"Your number -> {random}");