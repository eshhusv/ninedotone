using ninedotone;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите количество купюр номиналом 1: ");
        int oneBillCount = int.Parse(Console.ReadLine());
        Console.Write("Введите количество купюр номиналом 2: ");
        int twoBillCount = int.Parse(Console.ReadLine());
        Console.Write("Введите количество купюр номиналом 5: ");
        int fiveBillCount = int.Parse(Console.ReadLine());
        Console.Write("Введите количество купюр номиналом 10: ");
        int tenBillCount = int.Parse(Console.ReadLine());
        Console.Write("Введите количество купюр номиналом 50: ");
        int fiftyBillCount = int.Parse(Console.ReadLine());
        Console.Write("Введите количество купюр номиналом 100: ");
        int hundredBillCount = int.Parse(Console.ReadLine());
        Console.Write("Введите количество купюр номиналом 500: ");
        int fiveHundredBillCount = int.Parse(Console.ReadLine());
        Console.Write("Введите количество купюр номиналом 1000: ");
        int thousandBillCount = int.Parse(Console.ReadLine());
        Console.Write("Введите количество купюр номиналом 5000: ");
        int fiveThousandBillCount = int.Parse(Console.ReadLine());

        BillCounter billCounter = new BillCounter(oneBillCount, twoBillCount, fiveBillCount, tenBillCount, fiftyBillCount, hundredBillCount, fiveHundredBillCount, thousandBillCount, fiveThousandBillCount);
        Console.WriteLine(billCounter.getSum());
    }
}