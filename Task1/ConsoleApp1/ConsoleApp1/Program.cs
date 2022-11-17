namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sum(Readlinefirst(), Readlinesecond());

        }

        static int Readlinefirst()
        {
            int firstNumber = 0;
            bool validInput = false;
            while (!validInput)
            {
                Console.Write("Please enter your first number: ");
                var firstNumberInput = Console.ReadLine();

                validInput = int.TryParse(firstNumberInput, out firstNumber);

                if (!validInput)
                {
                    Console.WriteLine("Invalid input!");

                }
            }
            return firstNumber;
        }
        static int Readlinesecond()
        {
            int secondNumber = 0;
            bool validInput = false;
            while (!validInput)
            {
                Console.Write("Please enter your second number: ");
                var secondNumberInput = Console.ReadLine();


                validInput = int.TryParse(secondNumberInput, out secondNumber);

                if (!validInput)
                {
                    Console.WriteLine("Invalid input!");

                }
            }
            return secondNumber;
        }



        static int Sum(int num1, int num2)
        {
            int sum = 0;
            sum = num1 + num2;
            Console.WriteLine("The sum of these two numbers is=" + sum);
            return sum;
        }




    }

}