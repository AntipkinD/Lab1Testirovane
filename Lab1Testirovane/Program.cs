internal class Program
{
    static void MinMax(ref int minA, ref int maxB)
    {
        int m = minA;
        if (minA > maxB)
        {
            minA = maxB;
            maxB = m;
        }
    }
    private static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        MinMax(ref a, ref b);
        Console.WriteLine($"A(min) = {a}, B(max) = {b}");
    }
}