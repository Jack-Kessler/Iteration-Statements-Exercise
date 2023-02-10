namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void NumPrint ()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

    //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void NumPrintByThree()
        {
            for (int i = 3; i <= 999; i++)
            {
                Console.WriteLine(i);
            }
        }

    //Write a method to accept two integers as parameterss and check whether they are equal or not

        public static bool NumIsEqual(int a, int b) 
        {
            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    //Write a method to check whether a given number is even or odd
        public static void NumIsEven(int a)
        {
            if (a % 2 == 0)
            {
                //Number is even
                Console.WriteLine($"{a} is even.");
            }
            else
            {
                //Number is odd
                Console.WriteLine($"{a} is odd.");
            }
        }

    //Write a method to check whether a given number is positive or negative

        public static void NumIsPos(int a)
        {
            if (a > 0)
            {
                Console.WriteLine($"{a} is positive.");
            }
            else if (a < 0)
            {
                Console.WriteLine($"{a} is negative.");
            }
            else
            {
                Console.WriteLine($"{a} is zero.");
            }
        }

    //Write a method to read the age of a candidate and determine whether they can vote.
    //Hint: Use Parse or the safer TryParse() for an extra challenge
    //Parse()
    //TryParse()

        public static void oldEnoughToVote(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("Congrats! You can vote.");
            }
            else
            {
                Console.WriteLine("Sorry. You can't vote yet.");
            }
        }

    //public static void oldEnoughToVote2()
    //{
    //    Console.WriteLine("What is your age?");

    //    string ageStr = Console.ReadLine();
    //    int age = Int32.Parse(ageStr);

    //    //OR

    //    //int age = Convert.ToInt32(Console.ReadLine());

    //    if (age >= 18)
    //    {
    //        Console.WriteLine("Congrats! You can vote.");
    //    }
    //    else
    //    {
    //        Console.WriteLine("Sorry. You can't vote yet.");
    //    }
    //}

    //Heatin Up Section:
    //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void InRange(int a)
        {
        if (a >= -10 && a <= 10)
        {
            Console.WriteLine($"{a} is between -10 and 10.");
        }
        else
        {
            Console.WriteLine($"{a} is NOT between -10 and 10.");
        }
        }

        //public static void InRange2()
        //{
        //    Console.WriteLine("What number would you like to check?");
        //    string aStr = Console.ReadLine();
        //    int a = Int32.Parse(aStr);

        //    if (a >= -10 && a <= 10)
        //    {
        //        Console.WriteLine($"{a} is between -10 and 10.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{a} is NOT between -10 and 10.");
        //    }
        //}


    //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void MultTable(int a)
        {
        var multList = new List<int>();

            for (int i = 0; i <= 12;i++)
            {
                multList.Add(a * i);
            Console.WriteLine($"{a} multiplied by {i} = {multList[i]}.");
            }
        }

    //Call the methods to test them in the Main method below
    static void Main(string[] args)
        {
        NumPrint();
        NumPrintByThree();
        NumIsEqual(100, 202);
        NumIsEven(3);
        NumIsPos(52);
        oldEnoughToVote(18);
        InRange(22);
        MultTable(5);
        }
    }
}
