void ShowNumbers(int n)
{
    if(n >= 1)
    {
        Console.Write(n+" ");
        ShowNumbers(n-1);
    }
}
Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());
ShowNumbers(num);