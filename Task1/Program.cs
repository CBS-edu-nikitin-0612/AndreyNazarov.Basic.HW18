using System;
using System.Collections.Generic;
using Task3;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary = new()
            {
                { "Нулевой", 0 },
                { "Первый", 1 },
                { "Второй", 2 },
                { "Третий", 3 },
                { "Четвертый", 4 }
            };

            foreach (Task3.KeyValuePair<string, int> item in myDictionary)
            {
                Console.WriteLine($"Key => {item.Key}, Value => {item.Value}");
            }

            Console.WriteLine(new String('-', 40));
            try
            {
                Console.WriteLine(myDictionary["Нулевой"]);
                Console.WriteLine(myDictionary["Десятый"]);
            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(new String('-', 40));
            try
            {
                myDictionary["Первый"] = 10;
                myDictionary["Шестой"] = 10;
            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(new String('-', 40));
            foreach (Task3.KeyValuePair<string, int> item in myDictionary)
            {
                Console.WriteLine($"Key => {item.Key}, Value => {item.Value}");
            }
        }
    }
}
