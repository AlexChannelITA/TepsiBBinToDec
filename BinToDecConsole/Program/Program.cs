using System;

namespace BinToDecConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, lungh, pos=0, pes=0;

            Console.WriteLine("Inserisci il numero binario");
            string numBin = Console.ReadLine();

            lungh = numBin.Length;
            for (pos = lungh - 1; pos >= 0; pos--)
            {
                int cifra = Convert.ToInt32(numBin[pos]);
                Console.WriteLine($"La cifra letta è: {cifra}");
            }

        }
    }
}
