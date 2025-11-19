using System.Security;

namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isCurrency)
        {
            var sum = num1 + num2;

            if (isCurrency == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isCurrency && sum == 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }
        
        
        static void Main(string[] args)
        {
            Console.WriteLine(Add(38, 58, true));
            Console.WriteLine(Add(38, 58, false));
            Console.WriteLine(Add(38m, 58m));
            Console.WriteLine(Add(5, 5));
        }
    }
}
