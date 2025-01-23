using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Podaj zdanie do analizy: ");
            
            string sentence=Console.ReadLine();

            string[] words= sentence.Split(' ');
            int wordsCounter = words.Length;
            int palindromCount = 0;

            string buildString ="";

            for (int i = 0; i <= wordsCounter - 1; i++)
            {
                int lenght = words[i].Length;
                words[i] = words[i].ToUpper();

                for (int j = lenght - 1; j >= 0; j--)
                {
                    buildString += words[i][j];
                }
                if (words[i] == buildString)
                {
                   palindromCount++;
                }
            }
            Console.WriteLine($"Ilosc palindromow w zdaniu wynosi {palindromCount}");
               
        }
    }
}
