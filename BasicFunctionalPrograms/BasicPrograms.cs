using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionalPrograms
{
    class BasicPrograms
    {
        public void FlipCoin()
        {
            // Declaring and initializing the required variables
            int headCount = 0, tailCount = 0, head = 1;
            float headPercent, tailPercent;
            Console.Write("How many times do you want to perform the flip coin experiment?: ");
            int total = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            for (int i = 1; i <= total; i++)
            {
                int tossCheck = random.Next(0, 2);
                if (tossCheck == head)
                {
                    headCount++;
                }
                else
                {
                    tailCount++;
                }
            }
            headPercent = ((float)headCount / (float)total) * 100;
            tailPercent = ((float)tailCount / (float)total) * 100;
            Console.WriteLine("The total head count = " + headCount);
            Console.WriteLine("The total tail count = " + tailCount);
            Console.Write("The percentage of heads and tails is {0} and {1} respectively out of the total {2} trials", headPercent, tailPercent, total);
            Console.ReadLine();
        }
        public void LeapYear()
        {
            // Taking an input from the user and storing it as a year
            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            // Checking for leap year condition
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.Write(year + " is a leap year");
                Console.ReadLine();
            }
            else
            {
                Console.Write(year + " is not a leap year");
                Console.ReadLine();
            }
        }
        public void PowerOf2()
        {
            // Taking input from the user as a power of 2
            Console.Write("Enter the power of 2: ");
            int power = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            Console.WriteLine("The table in the form of power of 2 is:");
            // Checking for condition
            for (int i = 1; i <= power; i++)
            {
                result = result * 2;
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
        public float HarmonicMean()
        {
            // Taking a number as an input whose harmonic mean is to be found
            Console.Write("Enter a number whose harmonic mean is to be found: ");
            int num = Convert.ToInt32(Console.ReadLine());
            float harmonicMean = 0;
            for (int i = 1; i <= num; i++)
            {
                harmonicMean = harmonicMean + (1 / (float)i);
            }
            return harmonicMean;
        }
        public void PrimeFactors()
        {
            // Taking input from the user
            Console.Write("Enter a number whose factors are to be found: ");
            int number = Convert.ToInt32(Console.ReadLine());
            // Checking for factors
            Console.Write("The factors are: ");
            for (int i = 2; number >= 1; i++)
            {
                while (number % i == 0)
                {
                    Console.Write(i + " ");
                    //Console.ReadLine();
                    number = number / i;
                }

            }
            //Console.ReadLine();
        }
        public void QuotientRemainder()
        {
            // Taking a number as an input from the user
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            // Calculating the quotient and remainder assuming the divisor to be 2
            int quotient = num / 2;
            int remainder = num % 2;
            Console.WriteLine("After dividing by 2, the quotient of " + num + " is " + quotient + " and it's remainder is " + remainder);
            Console.ReadLine();
        }

        public void SwapTwoNumbers()
        {
            // Taking input from the user
            int temp; // Creating a temp variable for value storage
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            temp = num1;
            num1 = num2;
            Console.WriteLine("The first number = {0} and the second number = {1}", num1, temp);
            Console.ReadLine();
        }
        public void EvenOdd()
        {
            // Taking an input from the user
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int remainder = num % 2;
            // Checking the number to be even or odd
            if (remainder == 0)
            {
                Console.WriteLine(num + " is an even number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(num + " is an odd number");
                Console.ReadLine();
            }
        }
        public void AlphabetCheck()
        {
            // Taking alphabet as an input and storing it in a variable named alpha
            Console.Write("Enter any alpahet in small or capital: ");
            char alpha = Console.ReadLine()[0];
            // Checking for vowel or consonant
            if (alpha == 'a' || alpha == 'e' || alpha == 'i' || alpha == 'o' || alpha == 'u' || alpha == 'A' || alpha == 'E' || alpha == 'I' || alpha == 'O' || alpha == 'U')
            {
                Console.WriteLine(alpha + " is a vowel");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(alpha + " is a consonant");
                Console.ReadLine();
            }
        }
        public void LargestOfThreeNumbers()
        {
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine(num1 + " is the largest number.");
                Console.ReadLine();
            }
            else if (num2 > num3 && num2 > num1)
            {
                Console.WriteLine(num2 + " is the largest number.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(num3 + " is the largest number.");
                Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number out of the below mentioned numbers to execute the program of your choice: ");
            Console.WriteLine("1: To simulate a flip coin experiment and find out the percentage of heads and tails");
            Console.WriteLine("2: To check whether a year is a leap year or not");
            Console.WriteLine("3: To print a table of powers of 2 less than or equal to the power");
            Console.WriteLine("4: To find out the harmonic mean of a given number");
            Console.WriteLine("5: To compute the prime factors of a number");
            Console.WriteLine("6: To compute the quotient and remainder");
            Console.WriteLine("7: To swap two numbers");
            Console.WriteLine("8: To check whether a number is even or odd");
            Console.WriteLine("9: To check whether an alphabet is a vowel or a consonant");
            Console.WriteLine("10: To find out the largest among the three numbers");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    BasicPrograms flip = new BasicPrograms();
                    flip.FlipCoin();
                    break;
                case 2:
                    BasicPrograms leapYear = new BasicPrograms();
                    leapYear.LeapYear();
                    break;
                case 3:
                    BasicPrograms powerOf2 = new BasicPrograms();
                    powerOf2.PowerOf2();
                    break;
                case 4:
                    float resultOfHarmonicMean;
                    BasicPrograms harmonic = new BasicPrograms();
                    resultOfHarmonicMean = harmonic.HarmonicMean();
                    Console.WriteLine("The harmonic mean is " + resultOfHarmonicMean);
                    Console.ReadLine();
                    break;
                case 5:
                    BasicPrograms primeFactors = new BasicPrograms();
                    primeFactors.PrimeFactors();
                    break;
                case 6:
                    BasicPrograms quotRem = new BasicPrograms();
                    quotRem.QuotientRemainder();
                    break;
                case 7:
                    BasicPrograms swap = new BasicPrograms();
                    swap.SwapTwoNumbers();
                    break;
                case 8:
                    BasicPrograms evenOdd = new BasicPrograms();
                    evenOdd.EvenOdd();
                    break;
                case 9:
                    BasicPrograms alphabet = new BasicPrograms();
                    alphabet.AlphabetCheck();
                    break;
                case 10:
                    BasicPrograms largest = new BasicPrograms();
                    largest.LargestOfThreeNumbers();
                    break;
                default:
                    Console.WriteLine("Please enter a valid input!!!");
                    Console.ReadLine();
                    break;
            }
        }
    }
}

