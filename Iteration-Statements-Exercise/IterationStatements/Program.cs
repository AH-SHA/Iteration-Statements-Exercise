namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()
        public static void PrintNumbers()
        {



            for (int i = 1000; i > -1001; i--)
            {
                Console.WriteLine(i);
            }



        }
        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()


        public static void PrintEveryThirdNumber()
        {



            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }



        }





        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.


        public static void AreNumbersEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }


        }

        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.

        public static void IsEven(int numb)
        {
            Console.WriteLine("Enter a number:");
            var numby = int.TryParse(Console.ReadLine(), out int useNum);

            if (useNum % 2 == 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.
        public static void IsPositive(int input)
        {
            bool numbEntry;
            int userInput;
            Console.WriteLine("Enter a number:");
            numbEntry = int.TryParse(Console.ReadLine(), out userInput);

            if (userInput > 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }


        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.
        // int.Parse - returns only returns the 'int' variable type
        //int.TryParse - returns a 'boolean'
        public static void CanVote(int age)
        {
            Console.WriteLine("What is your age?");

            var enteredAge = int.TryParse(Console.ReadLine(), out int voteAge);

            while (enteredAge == false)
            {
                Console.WriteLine("Re-enter a number");
                enteredAge = int.TryParse(Console.ReadLine(), out voteAge);
            }

            if (voteAge >= 18)
            {
                Console.WriteLine("Yes, you can register to vote.");
            }
            else
            {
                Console.WriteLine("False");

            }



        }


        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.

        public static void IsInRange(int _number)
        {
            Console.WriteLine("Enter a number.");

            int userNumber = int.Parse(Console.ReadLine());

            if (_number <= 10 & _number >= -10)
            {
                Console.WriteLine("True");
                
            }
            else
            {
                Console.WriteLine("False");
                
            }
            
        }




        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"

        public static void DisplayMultiplicationTable(int userDigit)
        {
            Console.WriteLine("Enter an integer.");
            userDigit = int.Parse(Console.ReadLine());
            for (int i = 1; i < 13; i++)
            {
                var result = i * userDigit;
                Console.WriteLine($"{i} * {userDigit} = {result}");

            }
        }



        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {

            //METHOD Calls below:


            Console.WriteLine("Numbers -1000 to 1000");
            Console.WriteLine();
            PrintNumbers();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Print Every 3rd Number");
            PrintEveryThirdNumber();
            Console.WriteLine();

            Console.WriteLine("Are these numbers Equal?");
            AreNumbersEqual(4, 18);
            Console.WriteLine();

            var num1 = 18;
            var num2 = 18;
            Console.WriteLine("Are these numbers Equal?");
            AreNumbersEqual(num1, num2);
            Console.WriteLine();

            Console.WriteLine("Is the Number Even?");
            IsEven(32);
            Console.WriteLine();

            Console.WriteLine("Is the Number Positive?");
            IsPositive(8);
            Console.WriteLine();

            Console.WriteLine("Elgible Age to Vote?");
            CanVote(19);
            Console.WriteLine();

            Console.WriteLine("Is Range between -10 and 10?");
            IsInRange(6);
            Console.WriteLine();

            Console.WriteLine("Multiplication Table");
            DisplayMultiplicationTable(14);




        }
    }
}
