using System;
using System.Collections.Generic;
using CoreConsoleExample;
using CoreConsoleExample.Model;

namespace automatApp
{
    class Program
    {
        static int tableWidth = 73;
        static void Main(string[] args)
        {


            SeedData _seedData = new SeedData();

            Console.Clear();
            PrintLine();
            PrintRow("Id", "Name", "Price");
            PrintLine();
            foreach (var product in _seedData.Products)
            {
                PrintRow(product.Id.ToString(), product.Name.ToString(), product.Price.ToString());
            }
            PrintLine();
            Console.ReadLine();
        }

        static void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }

        static void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }

        static string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }


    }
}
