bool main (int num)
{
    if (num > 5)
    {
        return true;
    }
    else 
    {
        return false;
    }

}
int random = new Random().Next(1, 7);
main (random);
Console.WriteLine($"{random} - {main(random)}");