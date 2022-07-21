using System;

namespace Constants
{
    internal class Program
    {
        const double PI = 3.14159265359; // i insert contants before "static void"
        const int weeks = 52, months = 12;

        //a constant of string type with my bday as its value
        const string myBday1 = "25.08.1987";
        const string myBday2 = "08.25.1987";
        const string myBday3 = "1987.08.25"; //3 variants for diff formats


        static void Main(string[] args)
        {
            Console.WriteLine($"My birthday is always goin to be {myBday1}");
            Console.ReadKey();

        }
    }
}
