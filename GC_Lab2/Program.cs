using System;

namespace GC_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            string continuePrompt = "y";

            Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!");
            Console.WriteLine("Now with Volume!");

            while (continuePrompt == "y" || continuePrompt == "Y") //enters loop if prompt is "y" or "Y" otherwise ends program
            {
                Console.Write("Please enter the length of the room: ");
                double length = double.Parse(Console.ReadLine());
                Console.Write("Please enter the width of the room: ");
                double width = double.Parse(Console.ReadLine());
                Console.Write("Please enter the height of the room: ");
                double height = double.Parse(Console.ReadLine());

                double area = length * width;
                double perimeter = (2 * length) + (2 * width);
                double volume = length * width * height;

                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter: " + perimeter);
                Console.WriteLine("Volume: " + volume);

                Console.Write("Would you like to continue? (y/n): ");
                continuePrompt = Console.ReadLine();

                //while (continuePrompt != "y" && continuePrompt != "Y" && continuePrompt != "n" && continuePrompt != "N")
                //{
                //    Console.Write("Please enter a valid response. (y/n): ");
                //    continuePrompt = Console.ReadLine();
                //}
            }

        }
    }
}
