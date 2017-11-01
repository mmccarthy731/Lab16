using System;

namespace Lab16
{
    public class Hiker
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat)
            {
                int index = GetIndex("Which prime number would you like to look up? (Enter 1-100): ");
                string suffix = GetSuffix(index);
                int prime = GetPrime(index);
                Console.WriteLine($"\nThe {index}{suffix} prime number is {prime}.\n");
                repeat = DoAgain("Would you like to look up another prime number? (Y or N): ");
            }
        }

        //Method for getting and validating user input for index
        public static int GetIndex(string prompt)
        {
            int number = 0;
            bool valid = false;
            while (!valid)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                valid = int.TryParse(input, out number);
                if(number < 1 || number > 100)
                {
                    Console.Write("Invalid input. ");
                    valid = false;
                }
            }
            return number;
        }

        //assuredly over-complex method to obtain 'n'th prime number
        public static int GetPrime(int index)
        {
            int j = 1; //declare variable that will be used to test for prime numbers
            for (int i = 1; i <= index; i++) //'i' will be the indexer, for loop will stop when 'i' reaches the user-specified index
            {
                j++; //every time while loop is escaped, 'j' will increment
                bool isPrime = false;
                while (!isPrime)
                {
                    if (j > 1 && j < 4) //test for prime number
                    {
                        isPrime = true;
                    }
                    else if (j < 9 && j >= 4 && j % 2 != 0)
                    {
                        isPrime = true;
                    }
                    else if (j < 25 && j >= 9 && j % 3 != 0 && j % 2 != 0)
                    {
                        isPrime = true;
                    }
                    else if (j < 49 && j >= 25 && j % 5 != 0 && j % 3 != 0 && j % 2 != 0)
                    {
                        isPrime = true;
                    }
                    else if (j < 121 && j >= 49 && j % 7 != 0 && j % 5 != 0 && j % 3 != 0 && j % 2 != 0)
                    {
                        isPrime = true;
                    }
                    else if (j < 169 && j >= 121 && j % 11 != 0 && j % 7 != 0 && j % 5 != 0 && j % 3 != 0 && j % 2 != 0) //getting ridiculously complex, I know...
                    {
                        isPrime = true;
                    }
                    else if (j < 289 && j >= 169 && j % 13 != 0 && j % 11 != 0 && j % 7 != 0 && j % 5 != 0 && j % 3 != 0 && j % 2 != 0)
                    {
                        isPrime = true;
                    }
                    else if (j < 361 && j >= 289 && j % 17 != 0 && j % 13 != 0 && j % 11 != 0 && j % 7 != 0 && j % 5 != 0 && j % 3 != 0 && j % 2 != 0)
                    {
                        isPrime = true;
                    }
                    else if (j < 529 && j >= 361 && j % 19 != 0 && j % 17 != 0 && j % 13 != 0 && j % 11 != 0 && j % 7 != 0 && j % 5 != 0 && j % 3 != 0 && j % 2 != 0) 
                    {
                        isPrime = true;
                    }
                    else if (j <= 541 && j >= 529 && j % 23 != 0 && j % 19 != 0 && j % 17 != 0 && j % 13 != 0 && j % 11 != 0 && j % 7 != 0 && j % 5 != 0 && j % 3 != 0 && j % 2 != 0) //absurdly complex test for prime number
                    {
                        isPrime = true;
                    }
                    else //catch-all, if 'j' is not a prime number, increment and start the while loop over
                    {
                        j++;
                        isPrime = false;
                    }
                }
            }
            return j;
        }

        //Method for getting the proper suffix to add to the index number on the console window
        public static string GetSuffix(int number)
        {
            string numberString = number.ToString();
            int lastDigit = numberString.Length - 1;
            int secondToLast = numberString.Length - 2;
            if(numberString[lastDigit] == '1')
            {
                if(number > 10 && numberString[secondToLast] == '1') //in case of 11, "th"
                {
                    return "th";
                }
                return "st";
            }
            else if(numberString[lastDigit] == '2')
            {
                if (number > 10 && numberString[secondToLast] == '1') //in case of 12, "th"
                {
                    return "th";
                }
                return "nd";
            }
            else if(numberString[lastDigit] == '3')
            {
                if (number > 10 && numberString[secondToLast] == '1') //in case of 13, "th"
                {
                    return "th";
                }
                return "rd";
            }
            else
            {
                return "th";
            }
        }

        //Method to control the repeat loop in main method
        public static bool DoAgain(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine().ToLower();
            if(input == "y" || input == "yes")
            {
                return true;
            }
            else if(input == "n" || input == "no")
            {
                return false;
            }
            else
            {
                Console.Write("Invalid input. ");
                return DoAgain(prompt);
            }
        }
    }
}
