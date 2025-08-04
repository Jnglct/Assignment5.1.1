using System.Security.Cryptography.X509Certificates;

namespace Assignment5._1
{
    internal class IsPalindromeInt
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter in a integer");

        input:
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Please enter a valid integer.");
                goto input;
            }
            int palNumb = 0;
            int checkNumb = number;
            if (number < 0) //if negative return false
            {
                Console.WriteLine("false");
            }
            else 
            {
                while (true)
                {
                    palNumb += number % 10;
                    number /= 10;
                    number = (int)number;
                    if (number < 1)
                    {
                        break;
                    }
                    palNumb *= 10;
                }
                if (palNumb == checkNumb)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}
