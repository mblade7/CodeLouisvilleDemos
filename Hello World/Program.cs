using System;
namespace Alpahbet
{
    class program
    {
        static void Main(string[] args)
        {
            Alphabet();
            AlphabetZA();
            AlphabetEveryother();
        }
        static void Alphabet()
        {
            string Alphabet = "";
            for (char alpha = 'A'; alpha <= 'Z'; alpha++)
            {
                Alphabet += alpha.ToString();
            }
            Console.WriteLine(Alphabet);
        }
        static void AlphabetZA()
        {
            string AlphabetZA = "";
            for (char alpha = 'Z'; alpha >= 'A'; alpha--)
            {
                AlphabetZA += alpha.ToString();
            }
            Console.WriteLine(AlphabetZA);
        }
        static void AlphabetEveryother()
        {
            string AlphabetEveryother = "";
            for (char alpha = 'A'; alpha <= 'Z'; alpha = (char)(alpha + 2))
            {
                AlphabetEveryother += alpha.ToString();
            }
            Console.WriteLine(AlphabetEveryother);
        }
    }
}