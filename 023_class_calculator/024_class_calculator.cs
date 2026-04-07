namespace _024_class_calculator
{
    class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("0으로 나눌 수 없습니다.");
            }

            return (double)a / b;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 5;

            int sum = Calculator.Add(num1, num2);
            int difference = Calculator.Subtract(num1, num2);
            int product = Calculator.Multiply(num1, num2);
            double quotient = Calculator.Divide(num1, num2);

            Console.WriteLine($"덧셈: {sum}");
            Console.WriteLine($"뺄셈: {difference}");
            Console.WriteLine($"곱셈: {product}");
            Console.WriteLine($"나눗셈: {quotient}");
        }
    }
}
