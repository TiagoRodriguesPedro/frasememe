using System;

namespace frasememe
{
    class Program
    {
        static void Main(string[] args)
        {
            string frasedigitada, frasememetonervoso;
            Console.WriteLine("O que voce acha de mim ?");
             frasedigitada = Console.ReadLine();

          frasememetonervoso = $"{frasedigitada.Remove(10)}...Náo Náo pera, To Nervoso";

            Console.WriteLine(frasememetonervoso);

        }
    }
}
