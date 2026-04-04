using System.Drawing;

namespace _021_class_rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5, 3);

            double area = rect.GetArea();
            double perimeter = rect.GetPerimeter();

            Console.WriteLine("넓이: " + area);
            Console.WriteLine("둘레: " + perimeter);
        }
    }
}

/*
using System.Drawing;

namespace _021_class_rectangle
{
    internal class Rectangle
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int GetArea()
        {
            return width * height;
        }

        public int GetPerimeter()
        {
            return 2 * (width + height);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5, 3);

            int area = rect.GetArea();
            int perimeter = rect.GetPerimeter();

            Console.WriteLine("면적 : {0}\n둘레 : {1}\n", area, perimeter);
            Console.WriteLine($"면적 : {area}\n둘레 : {perimeter}\n");
        }
    }
}
*/