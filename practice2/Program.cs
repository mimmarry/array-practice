class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите сумму вклада: ");
        decimal sum = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Введите срок вклада в месяцах:");
        int mounth = Convert.ToInt32(Console.ReadLine());
        int i = mounth;
        while (i > 0)
        {
            sum += sum * 0.07m;
            i--;
        }
        Console.WriteLine($"Спустя {mounth} месяцев сумма вклада составит {sum }");
        Console.ReadKey();
    }
}