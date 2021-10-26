/*
 * Odometer.cs: This program uses functions to alter objects and displays how to use a Class
 * Name: Spencer Unitt
 * Module: Homework 2 Project 1
 * 
 * Algorithm:
 * 1. Create two constructors, one default and the other that takes in both variables
 * 2. Create getters and setters for both variables 
 * 3. Create a reset function that sets the values to 0
 * 4. Create an add function that increments the values by 1
 * 5. Create a function that return the MPG used by dividing miles by fuel used
 * 6. Create a ToString function that returns a generic string
 * 7. In the main, create two new default Odometer objects and add values to both
 * 8. Display the results, reset the values and add to the second object. Display the results of second object
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9_Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates new objects of the Odometer class
            Odometer trip1 = new Odometer();
            Odometer trip2 = new Odometer();

            // Addes miles and fuel to both objects
            trip1.add(50, 10); 
            Console.WriteLine("Fuel used for trip 1 is: " + trip1.MPG() + " MPG."); // uses the MPG function
            trip2.add(100, 20);
            Console.WriteLine("Fuel used for trip 2 is: " + trip2.MPG() + " MPG."); // uses the MPG function

            // reset object 1 
            trip1.reset();

            // Print the total for obejct 2, add value to it, then print the MPG again
            Console.WriteLine("Current status of trip 2 is: " + trip2.ToString());
            trip2.add(150, 0);
            Console.WriteLine("Fuel used for trip 2 is: " + trip2.MPG() + " MPG");

            Console.ReadLine();
        }

    }
}
