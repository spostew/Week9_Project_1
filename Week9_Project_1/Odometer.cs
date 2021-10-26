using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9_Project1
{
    class Odometer
    {
        // Variables
        private int miles;
        private double fuel;

        // Constructors
        public Odometer()
        {
            miles = 0;
            fuel = 0;
        }

        public Odometer(int miles, double fuel)
        {
            this.miles = miles;
            this.fuel = fuel;
        }

        // Getters and Setters
        public int Miles { get => miles; set => miles = value; }

        public double Fuel { get => fuel; set => fuel = value; }

        // Methods
        public void reset()
        {
            this.miles = 0; // resets the miles and fuel to 0
            this.fuel = 0;
        }

        public void add(int m, double f) // adds to the miles and fuel variables
        {
            miles += m; // Miles = miles + m
            fuel += f; // Fuel = fuel + f
        }

        public double MPG() // returns the total miles per gallon 
        {
           return miles / fuel;
        }

        public override String ToString() // returns a string of the total miles and fuel
        {
            return "Miles drivin: " + miles + " Fuel Used: " + fuel;
        }


    }
}
