namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pricePerSmallRoom=25;
            int pricePerLargeRoom=35;
            Console.WriteLine("Estimate for carpet cleaning service");
            Console.Write("Number of small carpets: ");
            int numberOfSmallCarpets=int.Parse(Console.ReadLine());
            Console.Write("Number of large carpets: ");
            int numberOfLargeCarpets=int.Parse(Console.ReadLine());
            Console.WriteLine($"Price per Small room: ${pricePerSmallRoom}");
            Console.WriteLine($"Price per large room: ${pricePerLargeRoom}");
            int cost=(numberOfSmallCarpets * pricePerSmallRoom)+ (numberOfLargeCarpets* pricePerLargeRoom);
            Console.WriteLine($"Cost: ${cost}");
            Console.WriteLine($"Tax: ${cost * 0.06}");
            Console.WriteLine("================================");
            Console.WriteLine($"Total estimate: ${cost * 1.06}");
            Console.WriteLine($"This estimate is valid for 30 days");
        }
    }
}
