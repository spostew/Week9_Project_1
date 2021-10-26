using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9_Project2
{
    class Temperature
    {
        // variables used
        private float temp;
        private char scale;

        // default constructor that sets the scale to C and temp to 0
        public Temperature()
        {
            temp = 0;
            scale = 'C';
        }

        // Takes in a temperature and sets the scale to C
        public Temperature(float temp)
        {
            this.temp = temp;
            this.scale = 'C';
        }

        // Takes in a single char parameter and sets temp to 0
        public Temperature(char scale)
        {
            this.temp = 0;
            this.scale = scale;
        }

        // Constructor that takes in two parameters and sets the values to the variables
        public Temperature(float temp, char scale)
        {
            this.temp = temp;
            this.scale = scale;
        }

        // returns the temp in Fharenhieght
        public float getF()
        {
            float change = (float)((temp * 1.8) + 32);
            return change;
        }

        // returns the temp in Celsius
        public float getC()
        {
            return temp;
        }

        // sets the temp
        public void setTemp(float temp)
        {
            this.temp = temp;
        }

        // sets the scale
        public void setScale(char scale)
        {
            this.scale = scale;
        }

        // Sets both the temp and the scale
        public void setBoth(float temp, char scale)
        {
            this.temp = temp;
            this.scale = scale;
        }

        // Generic string that prints when function is called
        public override String ToString()
        {
            return "The tempurature you selected is: " + temp + " " + scale;
        }

        // Compares the temp of the objects and returns true or false
        public override bool Equals(Object obj)
        {
            return this.temp == ((Temperature)obj).temp; 
        }
    }
}
