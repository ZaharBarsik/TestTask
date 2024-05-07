using System.Threading.Channels;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {







            //uint[] inputNumb = { 42, 12, 18};
            //uint[] outputNumb;
            //outputNumb = FindCoopDels(inputNumb);
            //for (int i = 0; i < FindCoopDels(inputNumb).Length; i++)
            //{
            //    Console.WriteLine(outputNumb[i]);
            //}



            ////int x = 0;
            ////int y = 0;
            ////x = int.Parse(Console.ReadLine());
            ////Console.WriteLine(comp(x));
            ///

            //////int x = 1;
            //////int y = 20;
            //////int[] outputNumb;
            //////Console.WriteLine(Prosto(x, y));
            //////outputNumb = Prosto(x, y);
            //////for (int i = 0; i < Prosto(x, y).Length; i++)
            //////{
            //////    Console.WriteLine(outputNumb[i]);
            //////}


            int x = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Pifagorka(x);

        }

        private static void Pifagorka(int x)
        {
            for (int i = 1; i < x + 2; i++)
            {
                Console.Write($"{i - 1,4}" + "|");
                for (int j = 1; j < x + 1; j++)
                {
                    if (i == 1)
                        Console.Write($"{j * i,4}" + " ");
                    else
                    {

                        int v = j * (i - 1);
                        Console.Write($"{v,4}" + " ");
                    }

                }
                Console.WriteLine("");
            }
        }

        private static int[] Prosto(int x, int y)
        {
            List<int> outL = new List<int> { };

            for (int j = x; j < y + 1; j++)
            {
                bool prost = true;
                for (int i = 2; i <= j / 2; i++)
                {
                    if (j % i == 0)
                    {
                        prost = false;
                        break;
                    }
                }
                if (prost)
                {
                    outL.Add(j);
                    continue;
                }
            }
            return outL.ToArray();
        }

        private static uint[] FindCoopDels(uint[] inputNumb)
        {
            List<uint> _dels = new List<uint>();
            uint firstNubmer = inputNumb[0];
            _dels.Add(firstNubmer);
            for (uint i = 2; i * i < firstNubmer; i++)
            {
                if (firstNubmer % i == 0)
                {
                    _dels.Add(i);
                    if (i * i != firstNubmer)
                        _dels.Add(firstNubmer / i);
                }
            }
            for (uint i = 1; i < inputNumb.Length; i++)
            {
                for (int j = 0; j < _dels.Count; j++)
                {
                    if ((inputNumb[i] % _dels[j] != 0))
                    {
                        _dels.RemoveAt(j);
                        j--;
                    }
                }
            }
            return _dels.ToArray();
        }

        private static string comp(int x)
        {
            int y = x % 10;
            if ((x >= 11) && (x <= 20))
            {
                return (x + " компьютеров");
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
