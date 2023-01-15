class Program
{
    static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());

        int result = ThirdDigit(num);
        if (result == -1)
        {
            Console.WriteLine("третьей цифры нет");
        }
        else
        {
            Console.WriteLine(result);
        }
    }

    static int ThirdDigit(int number)
    {
        int result = -1;
        if (number >= 100)
        {
            while (number > 999)
            {
                number = number / 10;
            }
            result = number % 10;
        }
        return result;
    }
}
