//An integer number in base 10 which is divisible by the sum of its digits is said to be a Harshad Number. An n-Harshad number is an integer number divisible by the sum of its digit in base n.
//Below are the first few Harshad Numbers represented in base 10:
//		1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 18, 20...
namespace CleanCodeAssignments.NamingSolution.src.task3
{
    public class HarshadNumbersPrinter
    {
        private static void PrintHarshadNumbers()
        {
            long lim = 1000;

            for (int i = 1; i <= lim; i++)
            {
                if (i % GetSumOfDigitsFor(i) == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static int GetSumOfDigitsFor(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                sum += number % 10;
                number = number / 10;
            }

            return sum;
        }
    }
}
