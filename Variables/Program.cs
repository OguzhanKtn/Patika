using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable Transformations
            string str20 = "20";
            int int20 = 20;
            string newValue = str20 + int20.ToString();
            Console.WriteLine(newValue); // Output is 2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); // Output is 40

            int int22 = int20 + int.Parse(str20); // Output is 40

            // Using of Datetime
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            var hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
        }
    }
}
