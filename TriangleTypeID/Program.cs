using System;

class TriangleTypeID
{
    static void Main()
    {
        double sideA, sideB, sideC;
        while (true)
        {
            Console.WriteLine("Please input the sizes of each side of your triangle \nSide A:");
            string inputA = Console.ReadLine();
            Console.WriteLine("Side B:");
            string inputB = Console.ReadLine();
            Console.WriteLine("Side C:");
            string inputC = Console.ReadLine();
            if (double.TryParse(inputA, out sideA) && double.TryParse(inputB, out sideB) && double.TryParse(inputC, out sideC))
            {
                if (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA)
                {
                    if (sideA == sideB && sideA == sideC)
                    {
                        Console.WriteLine("Equilateral");
                    }
                    else if (sideA == sideB || sideA == sideC || sideB == sideC)
                    {
                        Console.WriteLine("Isosceles");
                    }
                    else
                    {
                        Console.WriteLine("Scalene");
                    }
                    break;
                }
            }
                else
                {
                    Console.WriteLine("Invalid input. Please enter valid numbers.");
                }
        }
    }
}