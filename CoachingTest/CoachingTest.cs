using System;

namespace CoachingTest
{
    class CoachingTest
    {
        static void Main(string[] args)
        {
            //Exercise 4.12: The Coaching class

            //Create a class called Coaching that includes four (4) pieces of information
            ////as auto-implemented properties - the coaching type (sport) (type string), 
            //the number of players (type int), class timings (type string) and charges (type double). 
            //Your class should have a constructor that initializes the four automatic properties 
            //and assumes that the values are provided.
            //Provide a method DisplayDetails that displays all the information.
            //The charges should be represented as $.
            //Write a test app named CoachingTest that demonstrates the class.


            //Create the objeect
            Coaching coaching1 = new Coaching("Tennis", "Morning", 10.0, 4);

            //Accessing Object Properties
            Console.WriteLine($"The Coaching Type is: {coaching1.CoachingType}");
            Console.WriteLine($"The Class time is: {coaching1.ClassTiming}");

            //Accessing the methods
            coaching1.Details();
            Console.ReadLine();
            
        }
    }
}
