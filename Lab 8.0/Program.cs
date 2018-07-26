using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab_8._0
{
    class Program
    {
        public static object MessageBox { get; private set; }

        static void Main(string[] args)

        {
            string userChoice;

            while (true)
                
            {

                string[] students = new string[16] { "Jesse", "Kamel", "Chris", "Jacob", "Zac", "Demarko", "Samantha", "Christopher", "William", "Akeem", "William", "Kristen", "Bj", "Patrick", "Terrell", "Terri" };

                string[] food = new string[16] { "Pizza", "Pad Thai", "Chinese", "Jimmy Johns", "Subway", "Pizza", "Pizza", "Meatloaf", "Cheese sticks", "Cupcakes", "Pasta", "Italian", "Tacos", "Apples", "Pizza", "Pizza" };

                string[] hometown = new string[16] { "Royal Oak", "Dearborn", "Detroit", "Chicago", "New York", "Madison Heights", "Livonia", "Dearborn", "Charlevoix", "Rochester", "Troy", "West Bloomfield", "Warren", "Grand Blanc", "Beverly Hills", "Grand Haven" };
          

                Console.WriteLine("Welcome to our C# class, which student would you like to learn about?");


                string studentSelect = GetValidInput(@"^([A-Z]{1})([a-z]{2,})$", "",
               "Please enter a name in the proper format; example \"Name\" ");                                            
                
                int x = (Array.IndexOf(students, studentSelect));
             
                Console.WriteLine(studentSelect + " is from " + hometown[x] + " and likes to eat " + food[x]);
              


                ////:::::::::::::prints array of students
                //foreach (string s in students)
                //{
                //    Console.WriteLine(s + " ");
                //}

                Console.WriteLine("do you want to learn about another student \"(y/n)\"?");
                userChoice = Console.ReadLine();

                if (userChoice.ToLower() == "n")
                {
                    Console.WriteLine("Thanks for playing!");
                    break; // exit the while loop
                }
            }

        }
        public static string GetValidInput(string pattern, string userMessage = "Please enter a valid input:", string errorMessage = "Error in input!")
        {
            Console.WriteLine(userMessage);
            string userInput = Console.ReadLine();


            while (!Regex.IsMatch(userInput, pattern))
            //escape sequence; so that you can do and "@" or print "quotes" ( \n \t \'' \\ )
            //the @ first turns off all escape sequences
            {
                Console.WriteLine(errorMessage);
                userInput = Console.ReadLine(); //loops back through the original prompt until valid input
            }

            return userInput;
        }



    }

}




