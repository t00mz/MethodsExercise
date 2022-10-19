using System.Reflection.Metadata;

namespace MethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1

            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            var favColor = Console.ReadLine();

            Console.WriteLine("What is your favorite animal");
            var favAnimal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            var favBand = Console.ReadLine();

            Console.WriteLine();

            Story(userName, favColor, favAnimal, favBand);

            Console.WriteLine();

            //Exercise 2

            Console.WriteLine($"5+8={Add(5, 8)}");
            Console.WriteLine($"5-8={Substract(5, 8)}");
            Console.WriteLine($"3x3={Multiply(3, 3)}");
            Console.WriteLine($"15/5={Divide(15, 5)}");
            Console.WriteLine($"The remainder of 12/5 is {Remainder(12, 5)}");

            //Exercise 3

            Console.WriteLine($"1+7+8+10={Add(1, 7, 8, 10)}");
            Console.WriteLine($"5-8-3={Substract(5, 8, 3)}");
            Console.WriteLine($"3x3x3={Multiply(3, 3, 3)}");
            Console.WriteLine($"15/5/2={Divide(15, 5, 2)}");
        }

        //Excercise 1

        static void Story(string userName, string favColor, string favAnimal, string favBand)
        {
            Console.WriteLine($"Hi, my name is {userName}, and my favorite color is {favColor}. I love {favAnimal}s and {favBand}!");
        }

        //Exercise 2

        static int Add(int num1, int num2)
        {
            var sum = num1 + num2;
            return sum;
        }

        static int Substract(int num1, int num2)
        {
            var diff = num1 - num2;
            return diff;
        }

        static int Multiply(int num1, int num2)
        {
            var times = num1 * num2;
            return times;
        }

        static int Divide(int num1, int num2)
        {
            var divided = num1 / num2;
            return divided;
        }

        static int Remainder(int num1, int num2)
        {
            var modulus = num1 % num2;
            return modulus;
        }

        //Exercise 3

        static int Add(params int[] nums)
        {
            var add = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                add += nums[i];
            }
            return add;
        }

        static int Substract(params int[] nums)
        {
            var diff = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                diff += nums[i];
            }
            return diff;
        }

        static int Multiply(params int[] nums)
        {
            var times = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                times += nums[i];
            }
            return times;
        }

        static int Divide(params int[] nums)
        {
            var divide = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                divide += nums[i];
            }
            return divide;
        }

    }
}