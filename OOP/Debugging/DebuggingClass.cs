

using System.Security.Cryptography;

namespace OOP.Debugging
{
    public class DebuggingClass
    {

        public void ExMethod()
        {

            try
            {
                Console.WriteLine("Starting application...");

                // Example 1: Divide by zero
                int a = 10;
                int b = 0;
                int result = Divide(a, b);
                //Console.WriteLine($"Result: {result}");
                if (b == 2 && a == 9) { }
                ;
                // Example 2: Null reference
                string text = null;
                int length = text.Length;

                // Example 3: Index out of range
                List<int> numbers = new List<int> { 1, 2, 3 };
                int outOfBounds = numbers[5];

                Console.WriteLine("End of program.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception caught: {ex.Message}");
                Console.WriteLine("Stack Trace:");
                Console.WriteLine(ex.StackTrace);
            }
        }

        static int Divide(int x, int y)
        {
            return x / y;
        }


    }
}
