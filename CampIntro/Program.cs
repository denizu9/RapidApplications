﻿internal class Program
{
    private static void Main(string[] args)
    {
        string categoryTag = "Category";

        double dolarPriceToday = 32.05;

        double dolarPriceYesterday = 31.84;

        if (dolarPriceToday > dolarPriceYesterday)
        {
            Console.WriteLine("Dolar Incresead!");
        }
        else if (dolarPriceToday == dolarPriceYesterday)
        {
            Console.WriteLine("Price does not change!");
          
        }
        else
        {
            Console.WriteLine("Dolar Decreased!");
        }

        Console.WriteLine(categoryTag);
    }
}