using System;
using System.IO;

namespace VeggieAndFruit
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruitpath = @"C:\Users\opilane\samples\fruit.txt";
            string[] VeggieData = File.ReadAllLines(fruitpath);

            string veggiePath = @"C:\Users\opilane\samples\veggie.txt";
            string[] FruitData = File.ReadAllLines(veggiePath);

            File.WriteAllLines(fruitpath, FruitData);
            File.WriteAllLines(veggiePath, VeggieData);


        }
    }
}
