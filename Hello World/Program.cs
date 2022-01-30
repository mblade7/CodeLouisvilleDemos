using System;
namespace Alphabet
{
    class program
    {
        static void Main(string[] args)
        {
            string Alphabet = "";
            for (char alpha = 'A'; alpha <= 'Z'; alpha++)
            {
                Alphabet += alpha.ToString();
            }
            Console.WriteLine(Alphabet);

            string AlphabetZA = "";
            for (char alpha = 'Z'; alpha >= +'A'; alpha--)
            {
                AlphabetZA += alpha.ToString();
            }
            Console.WriteLine(AlphabetZA);

            string AlphabetEveryother = "";
            for (char alpha = 'A'; alpha <= 'Z'; alpha = (char)(alpha + 2))
            {
                AlphabetEveryother += alpha.ToString();
            }
            Console.WriteLine(AlphabetEveryother);
        }
    }
}
