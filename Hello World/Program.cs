using System;
namespace Alphabet
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Alphabet());
            Console.WriteLine(AlphabetZA());
            Console.Write("How many letters would you like to skip: ");
            string UserInput = Console.ReadLine();
            if(int.TryParse(UserInput, out int value))
            {
                if(int.Parse(UserInput) >= 26 || int.Parse(UserInput) < 0)
                {
                    Console.WriteLine("Haha! Very Funny");
                }
                else
                {
                    int numbertostring = int.Parse(UserInput);
                    Console.WriteLine(AlphabetSkip(numbertostring));
                }
            }
            else
            {
                Console.WriteLine("Entry is Invalid!");
            }
        }
        static string Alphabet()
        {
            string Alphabet = "";
            for (char alpha = 'A'; alpha <= 'Z'; alpha++)
            {
                Alphabet += alpha;
            }
            return Alphabet;
        }
        static string AlphabetZA()
        {
            string AlphabetZA = "";
            for (char alpha = 'Z'; alpha >= 'A'; alpha--)
            {
                AlphabetZA += alpha;
            }
            return AlphabetZA;
        }
        static string AlphabetSkip(int skip)
        {
            string AlphabetSkip = "";
            for (char alpha = 'A'; alpha <= 'Z';)
            {
                AlphabetSkip += alpha;
                for(int i = 0; i <= skip; i++)
                {
                    alpha++;
                }
            }
            return AlphabetSkip;
        }
    }
}