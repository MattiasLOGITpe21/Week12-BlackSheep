using System;
using System.IO;

namespace Seasons
{
    class Program
    {
        static void Main(string[] args)
        {
            string autumnpath = @"C:\users\opilane\samples\autumn.txt";
            string winterpath = @"C:\users\opilane\samples\winter.txt";

            string[] autumndata = File.ReadAllLines(autumnpath);
            string[] winterdata = File.ReadAllLines(winterpath);

            File.WriteAllLines(autumnpath, winterdata);

            File.WriteAllLines(winterpath, autumndata);
        }

        
    }
}
