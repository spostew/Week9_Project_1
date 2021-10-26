/*
 * Temperature.cs: This program uses various functions in order to set and alter a temperature
 * provided by the user. 
 * Name: Spencer Unitt
 * Module: Homework 9 Project 2
 * 
 * Algorithm:
 *  1. Create four constructors. One is default, two take in single parameters, the other takes both variables
 *  2. Create getters and setters for the variables
 *  3. Create a generic ToString and an equals function that compares temps
 *  4. In the main create four different temp objects and test each constructor
 *  5. ToString the results for each current constructor
 *  6. Use the setters to alter the objects and use the getters to display the changes
 *  7. Compare the objects with the equals function.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9_Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Class objects
            Temperature temp1 = new Temperature();
            Temperature temp2 = new Temperature(49);
            Temperature temp3 = new Temperature('F');
            Temperature temp4 = new Temperature(63, 'F');

            // Testing constructors and toStrings
            Console.WriteLine("Construtor testing\n");
            Console.WriteLine(temp1.ToString());
            Console.WriteLine(temp2.ToString());
            Console.WriteLine(temp3.ToString());
            Console.WriteLine(temp4.ToString() +"\n");

            // Setters
            temp1.setTemp(72);
            temp2.setScale('F');
            temp3.setBoth(46, 'C');
            temp4.setTemp(85);

            // Getter testers
            Console.WriteLine("Getter testers\n");
            Console.WriteLine("First temp in C: " + temp1.getC());
            Console.WriteLine("First temp in F: " + temp1.getF());

            Console.WriteLine("Second temp in C: " + temp2.getC());
            Console.WriteLine("Second temp in F: " + temp2.getF() +"\n");


            //ToString testers
            Console.WriteLine("ToString testers\n");

            Console.WriteLine(temp1.ToString());
            Console.WriteLine(temp2.ToString());
            Console.WriteLine(temp3.ToString());
            Console.WriteLine(temp4.ToString() + "\n");

            // Equals tester
            Console.WriteLine("Equals tester\n");
            temp3.setTemp(85);
            Console.WriteLine("Is temp 1 equal to temp 2? " + temp1.Equals(temp2));
            Console.WriteLine("Is temp 3 equal to temp 4? " + temp3.Equals(temp4));


            Console.ReadLine();
        }
    }
}
