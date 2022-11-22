int FindSecondNum (int num)
{
    int num1 = num / 10;
    int num2 = num1 % 10;
    return num2;
}
int random = new Random().Next(100, 1000);

int result = FindSecondNum(random);
Console.WriteLine($"full num = {random} second in it {result}");