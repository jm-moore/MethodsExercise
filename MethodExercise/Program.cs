// See https://aka.ms/new-console-template for more information
using System;
namespace MethodsExercise
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Are you male or female?");
            string genderInput = Console.ReadLine().ToLower();
            string gender;
            if (genderInput == "male")
            {
                gender = "he";
            }
            else
            {
                gender = "she";
            }
            string genderPossess;
            if (genderInput == "male")
            {
                genderPossess = "his";
            }
            else
            {
                genderPossess = "her";
            }

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine().ToLower();

            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine().ToLower();

            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();

            Console.WriteLine($"\nOnce upon a time, there was a brave " +
                $"warrior named {name}.\nIn battle, {gender} moved so quickly " +
                $"you'd only see a flash of {color} - the color of {genderPossess} " +
                $"armor.\nNext to {name}, was {genderPossess} sidekick named Chiji, " +
                $"a ferocious {animal}.\nAfter the battles are won, Chiji and {name} " +
                $"listen to their favorite band - {band}.");

            static int Add(int a, int b)
            {
                return a + b;
            }

            static int Subtract(int a, int b)
            {
                return a - b;
            }

            static int Multiply(int a, int b)
            {
                return a * b;
            }

            static int Divide(int a, int b)
            {
                return a / b;
            }

            static int Modulus(int a, int b)
            {
                return a % b;
            }

            Console.WriteLine("Give me a number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me another number:");
            int num2 = int.Parse(Console.ReadLine());
            int addSum = Add(num1, num2);
            Console.WriteLine($"The sum of {num1} and {num2} is {addSum}");

            Console.WriteLine("Give me a number:");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me another number:");
            int num4 = int.Parse(Console.ReadLine());
            int subtractSum = Subtract(num3, num4);
            Console.WriteLine($"If you subtract {num3} from {num4} you get {subtractSum}");

            Console.WriteLine("Give me a number:");
            int num5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me another number:");
            int num6 = int.Parse(Console.ReadLine());
            int multiplySum = Multiply(num5, num6);
            Console.WriteLine($"If you multiply {num5} and {num6} you get {multiplySum}");

            Console.WriteLine("Give me a number:");
            int num7 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me another number:");
            int num8 = int.Parse(Console.ReadLine());
            int divideSum = Divide(num7, num8);
            Console.WriteLine($"If you divide {num7} by {num8} you get {divideSum}");

            Console.WriteLine("Give me a number:");
            int num9 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me another number:");
            int num10 = int.Parse(Console.ReadLine());
            int modulusSum = Modulus(num9, num10);
            Console.WriteLine($"If you divide {num9} by {num10} you get a remainder of {modulusSum}");
        }

    }

}
