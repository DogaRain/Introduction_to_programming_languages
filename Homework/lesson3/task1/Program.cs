bool Numbers (int N)
{
    if (N > 9999 && N < 100000)
    {
        int num1 = N / 10000;
        int num = N % 10000;
        int num2 = num / 1000;
        int num3 = N % 10;
        int num0 = N / 10;
        int num4 = num0 % 10;
        if (num1 == num3 && num2 == num4)
        {
            Console.Write($"{N} is palindrome");
            return true;
        }
        else
        {
            Console.Write($"{N} is not palindrome");
            return false; 
        }
    }
    else
    {
        Console.Write($"{N} is not five-digit");
        return false;
    }
}
Console.WriteLine("Imput five-digit number");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($" - {Numbers (number)}");