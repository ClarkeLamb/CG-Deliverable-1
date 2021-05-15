using System;

namespace GC_Deliverable_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;

            do
            {
                Console.WriteLine("Please select your unit of measurement. (i.e.: inch, fidget spinners, foot, or memes)");
                string measurement = Console.ReadLine().ToLower();

                Console.WriteLine("Enter the amount/number you want converted.");
                var amount = double.Parse(Console.ReadLine());
                            
                if (measurement == "inch")
                {
                    amount = amount * 3.5;

                    Console.WriteLine("That converts to: " + amount + " fidgets spinners");


                }
                else if (measurement == "fidget spinners")
                {
                    amount = amount / 3.5;

                    Console.WriteLine("Thatconverts to: " + amount + " inch");

                }
                else if (measurement == "foot")
                {
                    amount = amount * 5;

                    Console.WriteLine("That converts to: " + amount + " memes");

                }
                else if (measurement == "memes")
                {
                    amount = amount / 5;

                    Console.WriteLine("That converts to: " + amount +  " foot");

                }
                else
                {
                    Console.WriteLine("Invalid unit of measurement selected.");
                }

                Console.WriteLine("Would you like to convert another number? Yes/ No");
                answer = Console.ReadLine();




            } while (answer.ToLower() == "yes");

            Console.WriteLine("Thank you for using Deliverable 1. Goodbye.");


            





        }
    }
}
