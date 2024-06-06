namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        
        //Write a method to check whether a given number is even or odd
        
        //Write a method to check whether a given number is positive or negative
        
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintPosToNeg();
            CountByThree();
            CheckEquality(8,8);
            PositiveOrNegative(-5);
            CanVote();
            InTenRange();
            MultiTable(3);
        }

        public static void PrintPosToNeg()
        {
            for(int i = 1000; i >= -1000; i--)
            {
                Console.Write($"{i} ");
            }
        }

        public static void CountByThree()
        {
            int i = 3;
            while(i <= 999)
            {
                Console.Write($"{i} ");
                i+=3;
            }
        }

        public static void CheckEquality(int num1, int num2)
        {
            if(num1 == num2)
            {
                Console.WriteLine($"{num1} and {num2} are equal.");
            }
            else
            {
                Console.WriteLine($"{num1} and {num2} are not equal.");
            }
        }

        public static void PositiveOrNegative(int num)
        {
            if(num > 0)
            {
                Console.WriteLine($"{num} is a positive number.");
            }
            else if(num < 0)
            {
                Console.WriteLine($"{num} is a negative number.");
            }
            else
            {
                Console.WriteLine($"{num} is neither negative or positive.");
            }
        }

        public static void CanVote()
        {
            Console.WriteLine("What is the candadite's age?");
            int age = int.Parse(Console.ReadLine());

            if(age >=18)
            {
                Console.WriteLine("This person can vote.");
            }
            else
            {
                Console.WriteLine("This person cannot vote.");
            }
        }

        public static void InTenRange()
        {
            Console.WriteLine("Give us a number");
            int userInput = int.Parse(Console.ReadLine());

            if(userInput <= 10 && userInput >= -10)
            {
                Console.WriteLine($"{userInput} falls within the range of -10 to 10");
            }
            else
            {
                Console.WriteLine($"{userInput} does not falls within the range of -10 to 10");
            }
        }

        public static void MultiTable(int num)
        {
            for(int i = 1; i <=12; i++)
            {
                Console.WriteLine($"{i}\t{num*i}");
            }
        }
    }
}
