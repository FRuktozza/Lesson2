int num = Convert.ToInt32(Console.ReadLine());

if (num < 100 || num > 999) 
{
    Console.WriteLine("некорректный ввод");
}
else
{
    Console.WriteLine(num / 10 % 10);
}
