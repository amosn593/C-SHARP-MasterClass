namespace InterviewQuestions.Questions
{
    public class PrimeNumbers
    {
        public static void MainMethod()
        {
            Console.WriteLine("Enter a Number");

            var InputNumber = Console.ReadLine();

            if (!int.TryParse(InputNumber, out int number))
            {
                Console.WriteLine("Wrong input. try again.");
            }


            bool isPrime = IsPrimeNumber(number);

            if (isPrime)
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.");
            }
        }
        private static bool IsPrimeNumber(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            int boundary = (int)Math.Floor(Math.Sqrt(number));

            Console.WriteLine($"{boundary} is the boundary.");

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }


}