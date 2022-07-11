/* Final Project - Price-Quote Application Assignment Submission
	Name: Jonathan Arce
	Create a console-based application for getting a shipping quote for a package.
*/

using System;


namespace PriceQuoteApplicationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n");

            //The user must then be prompted for the package weight.
            Console.WriteLine("Please enter the package weight:");
            double weight = Convert.ToDouble(Console.ReadLine());

            //If the weight is greater than 50, display the error message
            //and end program
            if (weight > 50)
            {
                Console.WriteLine("\nPackage too heavy to be shipped via Package Express. Have a good day.");
                //add to not close console automatically
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nPlease enter the package width:");
                double width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\nPlease enter the package height:");
                double height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\nPlease enter the package length:");
                double length = Convert.ToDouble(Console.ReadLine());
                double totalDimensions = width + height + length;

                // If the total of all dimensions is greater than 50, display the error message
                // and end program
                if (totalDimensions > 50)
                {
                    Console.WriteLine("\nPackage too big to be shipped via Package Express.");
                    //add to not close console automatically
                    Console.ReadLine();
                }
                else
                {
                    //Next, multiply the three dimensions (height, width, & length) together, and multiply the product by the weight. Finally, divide the outcome by 100.
                    //convert to decimal to be able to display price quote in dollar
                    decimal priceQuote = Convert.ToDecimal(((width * height * length) * weight) / 100);
                    
                    Console.WriteLine("\nYour estimated total for shipping this package is: " + priceQuote.ToString("C"));
                    Console.WriteLine("\nThank you.");
                    //add to not close console automatically
                    Console.ReadLine();
                }
            }
        }
    }
}
