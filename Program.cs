/* Project and Programmer: Tech Project 3 -- Sumbitted by Marisa Momper
 * Date: 9/19/2021
 * Description: Create a conversion table that recieves a KM incremement value between 10 and 25 as an input
 * from the user, outputs a table that starts at 0, doesn't exceed 200, and that has values that increment
 * by the value inputted, and also convert each incremented value to miles */
using System;

namespace Tech_Project_3___Marisa_Momper
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for an integer input increment value
            Console.WriteLine("Please enter an integer value between 10 and 25 to be used as a KM increment value");

            //Start of try block that validates the input
            try
            {
                //Assign integer value inputted by user to a variable
                int incrementValue = int.Parse(Console.ReadLine());

                //Create a CONSTANT for the conversion metric for converting KM to MI
                const double CONVERSIONMETRIC = 0.621371;

                //Create a variable to hold the value for miles once converted
                double miles;

                //Create a variable to hold the value for kilometers
                int kilometers;

                //Check that the input is valid
                if(incrementValue >= 10 && incrementValue <=25)
                {
                    //Format the header line for the two columns
                    Console.WriteLine("Kilometers | Equivalent Miles");

                    //Format the first line underneath the header that outputs the 0 KM line and formats string output for when there is one character in length
                    Console.WriteLine("  0 KM | 0 MI");

                    //Declare starting value of while loop as the increment value
                    int i = incrementValue;
                    //establish while loop that continues iterating until the value of i is greater than 200
                    while(i <= 200)
                    {
                        //assigns value of i to the kilometers variable
                        kilometers = i;

                        //converts current value of kilometers to miles using the converting constant and rounds the output to two decimal places
                        miles = Math.Round(i * CONVERSIONMETRIC,2);

                        //Formats string outputs that have KM values between 10 and 99 (Two characters in length)
                        if(i < 100)
                        {
                            //Adds a new line in the table which has the value for KM set to the current iteration for KM, and the value for MI as the rounded converted value 
                            Console.WriteLine(" " + kilometers.ToString() + " KM" + " | " + miles.ToString() + " MI");
                        }

                        //Formats string outputs that have KM values between 100 and 200 (Three characters in length)
                        if (i >= 100)
                        {
                            //Adds a new line in the table which has the value for KM set to the current iteration for KM, and the value for MI as the converted value
                            Console.WriteLine(kilometers.ToString() + " KM" + " | " + miles.ToString() + " MI");
                        }
                        
                        //increments the value of i that is used in the while loop by the increment value
                        i += incrementValue;
                    }
                }//end of if block

                //if the input does not meet the above integer input requirements then a new input is requested
                else
                {
                    Console.WriteLine("Please run again and enter an integer value value between 10 and 25");
                    Console.ReadKey(true);
                }//end of else block

            }//end of try block

            //start of catch block to handle all other inputs
            catch
            {
                Console.WriteLine("Please run again and enter an integer value value between 10 and 25");
                Console.ReadKey(true);
            }//end of catch block
        }
    }//end of class
}//end of namespace
