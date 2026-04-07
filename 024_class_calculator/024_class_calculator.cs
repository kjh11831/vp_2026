namespace _024_class_calculator
{
    class Calculator
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("0으로 나눌 수 없습니다.");

                return 0;
            }

            else
            {
                return a / b;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 10;
            double num2 = 5;

            double sum = Calculator.Add(num1, num2);
            double difference = Calculator.Subtract(num1, num2);
            double product = Calculator.Multiply(num1, num2);
            double quotient = Calculator.Divide(num1, num2);

            Console.WriteLine($"덧셈: {sum}");
            Console.WriteLine($"뺄셈: {difference}");
            Console.WriteLine($"곱셈: {product}");
            Console.WriteLine($"나눗셈: {quotient:F4}");
        }
    }
}
