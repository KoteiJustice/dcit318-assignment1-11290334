using System;

class TicketPriceCalc
{
    static void Main()
    {
        int customerAge;
        double ticketPrice = 10.00; // Base ticket price
        double finalPrice;

        while (true)
        {
            Console.WriteLine("Please enter your age");
            string ageInput = Console.ReadLine();

            if (int.TryParse(ageInput, out customerAge) && customerAge >= 0)
            {
                if (customerAge <= 12 || customerAge >= 65)
                {
                    finalPrice = 7;
                }
                else
                {
                    finalPrice= ticketPrice;
                }
                Console.WriteLine("The ticket price for a customer age " + customerAge + " is GH₵" + finalPrice);
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        }
    }
}