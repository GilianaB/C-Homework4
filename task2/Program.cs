int SumNumerals(int number)
{
    int sum = 0;
    for (int i=0; i<10; i++)
    {
    sum=sum+number%10;
    number=number/10;
    }
    return sum+number;
}

Console.WriteLine("input number");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNumerals(number));


