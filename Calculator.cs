using System;
namespace Calculator
{
    class Calculator
    {
        public static double Add()
        {
            Console.Write("Hello, Enter your first Number: ");
            try
            {
                double Num1 = Int32.Parse(Console.ReadLine());
                Console.Write("Hello, Enter your second Number: ");
                try
                {
                    double Num2 = Int32.Parse(Console.ReadLine());
                    double sum = Num1 + Num2;
                    return sum;
                    Console.WriteLine("The sum of your numbers is: " + Calculator.Add());

                }
                catch
                {
                    Console.WriteLine("Enter a valid number");
                }
            }
            catch {
                Console.WriteLine("Enter a valid Number");
            }
            return 0;
        }
        public static double Subtract() 
        {
            Console.Write("Hello, Enter the from which you want to subtract from: ");
            double Num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Hello, Enter the number to subtract: ");
            double Num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            double Answer = Num1 - Num2;

            return Answer;
        }
        public static double Multiply()
        {
            Console.Write("Hello, Enter your first Number: ");
            double Num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Hello, Enter your second Number: ");
            double Num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            double Answer = Num1 * Num2;
            return Answer;
        }
        public static double Divide()
        {
            Console.Write("Hello, Enter your first Number: ");
            double Num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Hello, Enter your second Number: ");
            double Num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            double quotient = Num1 / Num2;
            return quotient;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Welcome!! choose one operation from the following options");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine(" ");

                try
                {
                    int choice = Int32.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        Console.WriteLine("The sum of your numbers is: " + Calculator.Add());
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("The difference of your numbers is: " + Calculator.Subtract());
                    }
                    else if (choice == 3)
                        
                    {
                        Console.WriteLine("The product of your numbers is: " + Calculator.Multiply());
                    }
                    else if (choice == 4)
                    {
                        Console.WriteLine("The quotient of your numbers is: " + Calculator.Divide());  
                    }
                }
                catch 
                {
                    Console.WriteLine("Try entering a valid number between 1 - 4!!");
                }
                
            }
        }
    }
}