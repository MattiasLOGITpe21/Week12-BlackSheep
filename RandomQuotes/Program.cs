using System;
using System.IO;

namespace RandomQuotes
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\opilane\samples\quotes.txt";

            string[] dataFromFile = File.ReadAllLines(filepath);

            Console.WriteLine(dataFromFile[0]);

            Random rnd = new Random();
            int randomIndex = rnd.Next(1, dataFromFile.Length);
            Console.WriteLine(dataFromFile[randomIndex]);


        }
    }
}
