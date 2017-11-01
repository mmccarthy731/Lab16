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

        public static int GetPrime(int index)
        {
            int[] primes = new int[index];
            int primeValue = index - 1;
            int j = 2;
            for (int i = 0; i < index; i++)
            {
                bool isPrime = false;
                while (!isPrime)
                {
                    if (j < 4)
                    {
                        primes[i] = j;
                        j++;
                        isPrime = true;
                    }
                    else if (j < 9 && j >= 4 && j % 2 != 0)
                    {
                        primes[i] = j;
                        j++;
                        isPrime = true;
                    }
                    else if (j < 25 && j >= 9 && j % 3 != 0 && j % 2 != 0)
                    {
                        primes[i] = j;
                        j++;
                        isPrime = true;
                    }
                    else if (j < 49 && j >= 25 && j % 5 != 0 && j % 3 != 0 && j % 2 != 0)
                    {
                        primes[i] = j;
                        j++;
                        isPrime = true;
                    }
                    else if (j < 121 && j >= 49 && j % 7 != 0 && j % 5 != 0 && j % 3 != 0 && j % 2 != 0)
                    {
                        primes[i] = j;
                        j++;
                        isPrime = true;
                    }
                    else if (j < 169 && j >= 121 && j % 11 != 0 && j % 7 != 0 && j % 5 != 0 && j % 3 != 0 && j % 2 != 0)
                    {
                        primes[i] = j;
                        j++;
                        isPrime = true;
                    }
                    else if (j < 289 && j >= 169 && j % 13 != 0 && j % 11 != 0 && j % 7 != 0 && j % 5 != 0 && j % 3 != 0 && j % 2 != 0)
                    {
                        primes[i] = j;
                        j++;
                        isPrime = true;
                    }
                    else if (j < 361 && j >= 289 && j % 17 != 0 && j % 13 != 0 && j % 11 != 0 && j % 7 != 0 && j % 5 != 0 && j % 3 != 0 && j % 2 != 0)
                    {
                        primes[i] = j;
                        j++;
                        isPrime = true;
                    }
                    else if (j < 529 && j >= 361 && j % 19 != 0 && j % 17 != 0 && j % 13 != 0 && j % 11 != 0 && j % 7 != 0 && j % 5 != 0 && j % 3 != 0 && j % 2 != 0)
                    {
                        primes[i] = j;
                        j++;
                        isPrime = true;
                    }
                    else if (j <= 541 && j >= 529 && j % 23 != 0 && j % 19 != 0 && j % 17 != 0 && j % 13 != 0 && j % 11 != 0 && j % 7 != 0 && j % 5 != 0 && j % 3 != 0 && j % 2 != 0)
                    {
                        primes[i] = j;
                        j++;
                        isPrime = true;
                    }
                    else
                    {
                        j++;
                        isPrime = false;
                    }
                }
            }
            return primes[primeValue];
        }

        public static string GetSuffix(int number)
        {
            string numberString = number.ToString();
            int lastDigit = numberString.Length - 1;
            int secondToLast = numberString.Length - 2;
            if(numberString[lastDigit] == '1')
            {
                if(number > 10 && numberString[secondToLast] == '1')
                {
                    return "th";
                }
                return "st";
            }
            else if(numberString[lastDigit] == '2')
            {
                if (number > 10 && numberString[secondToLast] == '1')
                {
                    return "th";
                }
                return "nd";
            }
            else if(numberString[lastDigit] == '3')
            {
                if (number > 10 && numberString[secondToLast] == '1')
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
