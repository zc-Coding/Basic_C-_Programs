using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConsoleAppPg204
{
    class Program
    {
        static void Main(string[] args)
        {
            // First part of assingment
            string[] names = { "Moe", "FizzBuzz", "Mariah", "walt", "Doctor" }; // Created Array
            Console.WriteLine("Hello! please insert a small amount of text");
            string input = Console.ReadLine(); // input from user
            int i = 0; // counter for first loop
            int j = 0; // counter for second loop
            foreach (string name in names) // iterates through the whole array
            {
                names.SetValue(name + input, i); // takes the variable name and adds the user's input,
                i++;
            } // ends this loop with same array with the users input added to the back of each element
            foreach (string name in names) // loop to print all the new elements line by line
            {
                Console.WriteLine(names[j]);
                j++;
            }

            // Second part 
            //for (int k = 1; k > 0; k++) This is is in a infinite loop because it will never break the statement k > 0
            //{
            //    Console.WriteLine("iteration: {0}", k);
            //}
            for (int k = 0; k < 5; k++)
            {
                Console.WriteLine("iteration: {0}", k);
            }

            // Third part 
            // a loop using < operand
            for (int x = 0; x < 55; x++)
            {
                Console.WriteLine("Counting to fifty-five" + x);
                Console.ReadLine();
            }
            // a loop using <= operand
            for (int t = 3; t <= 5; t++)
            {
                Console.WriteLine("couldn't think of anything creative" + t + 77);
            }

            // Fourth Part
            List<string> favColor = new List<string> { "Red", "Blue", "Green", "Yellow", "Purple", "Pink" };
            Console.WriteLine("What's your favorite color?\n(don't get it wrong)");
            string inputColor = Console.ReadLine();
            bool isGuessed = false;
            while (!isGuessed)
            {
                for (int g = 0; g < favColor.Count; g++)
                {
                    if (inputColor == favColor[g])
                    {
                        Console.WriteLine(g);
                        isGuessed = true;
                        break;
                    }
                }
                if (!isGuessed)
                {
                    Console.WriteLine("You guessed wrong friend\nPlease try again");
                    inputColor = Console.ReadLine();
                }
            }

            // PART 5
            List<string> householdPets = new List<string> { "Dog", "Cat", "Bunny", "Cat", "Fish", "Ferret", "Lizard" };
            Console.WriteLine("Whats your favorite household pet?");
            string inputPet = Console.ReadLine();
            bool matched = false;
            while (!matched)
            {
                for (int g = 0; g < householdPets.Count; g++)
                {
                    if (inputPet == householdPets[g])
                    {
                        Console.WriteLine(g);
                        matched = true;
                    }
                }
                if (!matched)
                {
                    Console.WriteLine("I don't think that is a household pet,\ntry something more \"normal\"");
                    inputPet = Console.ReadLine();
                }
            }

            //PART 6
            List<string> pets = new List<string>();
            foreach (string pet in householdPets)
            {                             
                if (pets.Contains(pet) == true)
                {
                    Console.WriteLine(pet + " is already on the list");
                }
                else
                {
                    Console.WriteLine(pet);
                }
                pets.Add(pet);
            }

        }
    }
}

