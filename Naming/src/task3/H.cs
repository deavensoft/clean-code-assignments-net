


//An integer number in base 10 which is divisible by the sum of its digits is said to be a Harshad Number. An n-Harshad number is an integer number divisible by the sum of its digit in base n.
//Below are the first few Harshad Numbers represented in base 10:
//		1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 18, 20...
namespace CleanCodeAssignments.Naming.src.task3
{
    public class H
    {
        // Print some Harshad numbers
        public static void Print()
        {
            long L = 1000; // limit the seq of Harshad numbers
            for (int i = 1; i <= L; i++)
            {
                if (i % Loop(i) == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static int Loop(int N)
        {
            int S = 0;
            while (N != 0)
            {
                S += N % 10;
                N = N / 10;
            }
            return S;
        }
    }
}
