using System;

namespace generator
{
    class Program
    {
        static void Main(string[] args)
        {
            BigramGenerator bg = new BigramGenerator();
            string bigramText = bg.GenerateText(1000, 10);
            Console.WriteLine(bigramText + "\n");
            TextSaver.Save(bigramText, "BigramText.txt");

            WordGenerator wg = new WordGenerator();
            string wordText = wg.GenerateText(1000, 10);
            Console.WriteLine(wordText + "\n");
            TextSaver.Save(wordText, "WordText.txt");

            PairGenerator pg = new PairGenerator();
            string pairText = pg.GenerateText(1000, 10);
            Console.WriteLine(pairText + "\n");
            TextSaver.Save(pairText, "PairText.txt");
        }
    }
}

