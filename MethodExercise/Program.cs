using System;

namespace MethodExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            String Name = Console.ReadLine();

            Console.WriteLine("Please enter a color");
            String Color = Console.ReadLine();

            Console.WriteLine("Please enter an animal");
            String Animal = Console.ReadLine();

            Console.WriteLine("Please enter the name of a Band");
            String Band = Console.ReadLine();

            Console.WriteLine($"One day a person named {Name} set off on a quest to find the {Color} gem, the richest treasure in the entire land.");
            Console.WriteLine($"Along the way {Name} encountered a dancing {Animal} who was listening to music from the music band {Band}. They both started dancing together and became best friends.");
            Console.WriteLine("");
            Console.WriteLine("THE END");
            Console.WriteLine("");

            Console.WriteLine("-Addition Problem-");
            Console.WriteLine("");
            Console.WriteLine("Please enter a number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a second number");
            int num2 = int.Parse(Console.ReadLine());
            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum of both numbers is {sum}");
            Console.WriteLine("");

            Console.WriteLine("-Multiplication Problem-");
            Console.WriteLine("");
            Console.WriteLine("Please enter a number");
            int numx = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a second number");
            int numy = int.Parse(Console.ReadLine());
            int multiply = Multiply(numx, numy);
            Console.WriteLine($"Multiplying both numbers gives us a total of {multiply}");
            Console.WriteLine("");

            Console.WriteLine("-Subtraction Problem-");
            Console.WriteLine("");
            Console.WriteLine("Please enter a number");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a second number");
            int num4 = int.Parse(Console.ReadLine());
            int subtract = Subtract(num3, num4);
            Console.WriteLine($"When we subtract both numbers we get {subtract}");
            Console.WriteLine("");

            Console.WriteLine("-Divide Problem-");
            Console.WriteLine("");
            Console.WriteLine("Please enter a number");
            int num5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a second number");
            int num6 = int.Parse(Console.ReadLine());
            int divide = Divide(num5, num6);
            Console.WriteLine($"When we apply division we get a number of {divide}");
            Console.WriteLine("");

            Console.WriteLine("-Modulus Method-");
            Console.WriteLine("");
            Console.WriteLine("Please enter a number");
            int num7 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a second number");
            int num8 = int.Parse(Console.ReadLine());
            int modulus = Modulus(num5, num6);
            Console.WriteLine($"When we apply modulus to both numbers we get a number of {modulus}");
            Console.WriteLine("");
        }
        
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Multiply(int numx, int numy)
        {
            return numx * numy;
        }
        public static int Subtract(int num3, int num4)
        {
            return num3 - num4;
        }
        public static int Divide(int num5, int num6)
        {
            return num5 / num6;
        }
        public static int Modulus(int num7, int num8)
        {
            return num7 / num8;
        }




    }
}
