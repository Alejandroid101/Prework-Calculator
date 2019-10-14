using System;

namespace CalCulator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu == true)
            {
                displayMenu = MainMenu();
            }
        }
        //Calculator main menu. It prompts the user for th type of calculation
        private static bool MainMenu()
        {
            Console.WriteLine("Welcome to SuperCalculator. What do you need to calculate?");
            Console.WriteLine("1)Add 2)Substract 3)Multiply 4)Divide");
            Console.WriteLine("5)Exit");
            Console.Write("What's it gonna be?");
            string result = Console.ReadLine();
            // depending on the option, it will run a method
            if (result == "1")
            {
                Add();
                return true;
            }
            else if (result == "2")
            {
                Substract();
                return true;
            }
            else if (result == "3")
            {
                Multiply();
                return true;
            }
            else if (result == "4")
            {
                Divide();
                return true;
            }
            else if (result == "5")
            {
                return false;
            }
            else
            {
                return false;
            }

        }
        //All the available methods are here
        private static void Add()
        {
            Console.Write("First number");
            decimal a = Decimal.Parse(Console.ReadLine());
            Console.Write("Second number");
            decimal b = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", a, b, a+b);

        }
        private static void Substract()
        {
            Console.Write("First number");
            decimal a = Decimal.Parse(Console.ReadLine());
            Console.Write("Second number");
            decimal b = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("{0} - {1} = {2}", a, b, a-b);

        }
        private static void Multiply()
        {
            Console.Write("First number");
            decimal a = Decimal.Parse(Console.ReadLine());
            Console.Write("Second number");
            decimal b = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("{0} * {1} = {2}", a, b, a*b);

        }
        private static void Divide()
        {
            Console.Write("First number");
            decimal a = Decimal.Parse(Console.ReadLine());
            Console.Write("Second number");
            decimal b = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("{0} / {1} = {2}", a, b, a/b);

        }
    }
}
    