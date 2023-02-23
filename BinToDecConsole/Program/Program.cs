using System;

namespace BinToDecConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=0, lungh, pos=0, pes=0;

            Console.WriteLine("Inserisci il numero binario");
            string numBin = Console.ReadLine();

            lungh = numBin.Length;
            for (pos = lungh - 1; pos >= 0; pos--)
            {
                //int cifra = Convert.ToInt32(numBin[pos]);
                int cifra = (int)Char.GetNumericValue(numBin[pos]);
                Console.WriteLine($"{pos} La cifra letta è: {cifra}");
                n += (int)(cifra * Math.Pow(2, pes));
                pes += 1;
            }
            Console.WriteLine($"Il numero {n} ");

        }
    }
}
