namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            x = int.Parse(Console.ReadLine());
            Console.WriteLine(comp(x));
        }

        private static string comp(int x)
        {
            int y = x % 10;
            if ((x >= 11) && (x <= 20))
            {
                return(x + " компьютеров");
            }
            switch (y)
            {
                case 1:
                    return (x + " компьютер");
                case 2 or 3 or 4:
                    return (x + " компьютера");
                case 0 or 5 or 6 or 7 or 8 or 9:
                    return (x + " компьютеров");
            }
            throw new Exception("Ашибка");
        }
    }
}
