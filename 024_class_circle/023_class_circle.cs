/*
Circle 클래스
- 반지름(double radius)과 색깔(string color)
- 생성자 메소드
  Circle c = new Circle(3.5, "빨간색");
- 메소드
  GetArea() // 원의 면적 계싼
  PrintInfo() // 원의 반지름과 색깔 출력
- Main()
  반지름 10인 빨간색 원을 만들어서 면적을 출력하고 정보를 출력하시오
*/

namespace _024_class_circle
{
    class Circle
    {
        private double radius;
        private string color;

        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"반지름: {radius}\n색깔: {color}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(10, "빨간색");

            double area = c.GetArea();

            Console.WriteLine($"원의 면적: {area:F2}");

            c.PrintInfo();
        }
    }
}