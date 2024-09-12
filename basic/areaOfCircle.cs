using System;

class Area
{
    static void Main()
    {
        // Reading the radius value as a double
        double R = double.Parse(Console.ReadLine());

        // Defining the value of π as given in the problem statement
        double pi = 3.14159;

        // Calculating the area using the formula A = π * R^2
        double area = pi * Math.Pow(R, 2);

        // Printing the result in the required format with four decimal places
        Console.WriteLine($"A={area:F4}");
    }
}
