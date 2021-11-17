using System;
using System.IO;

namespace BlackSheep
{
    class Program
    {
        static void Main(string[] args)
        {
            string FilePath = @"C:\users\opilane\samples\blacksheep.txt";
            string[] dataFromFile = File.ReadAllLines(FilePath);

            for (int i = 0; i < dataFromFile.Length; i++)
            {
                dataFromFile[i] = dataFromFile[i].Replace('4', 'a');
                dataFromFile[i] = dataFromFile[i].Replace('3', 'e');
                dataFromFile[i] = dataFromFile[i].Replace('0', 'o');
                dataFromFile[i] = dataFromFile[i].Replace('1', 'i');
            }
            foreach(string line in dataFromFile)
            {
                Console.WriteLine(line);
            }
            File.WriteAllLines(FilePath, dataFromFile);
        }

    }
}
