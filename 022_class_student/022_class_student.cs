namespace _022_class_student
{
    internal class Program
    {
        class Student
        {
            private string name;
            private int age;
            private string major;

            public Student(string name, int age, string major)
            {
                this.name = name;
                this.age = age;
                this.major = major;
            }

            public void DisplayInfo()
            {
                Console.WriteLine("이름: {0}\n나이: {1}\n전공: {2}\n", this.name, this.age, this.major);

                Console.WriteLine($"이름: {this.name}\n" + $"나이: {this.age}\n" + $"전공: {this.major}\n");

                string s = string.Format("이름: {0}\n나이: {1}\n전공: {2}\n", this.name, this.age, this.major);
                Console.WriteLine(s);

                string t = $"이름: {name}\n" + $"나이: {this.age}\n" + $"전공: {this.major}\n";
                Console.WriteLine(t);

                Console.WriteLine("======= 학생 정보 =======");
                Console.WriteLine($"이름: {name}");
                Console.WriteLine($"나이: {age}");
                Console.WriteLine($"전공: {major}");
                Console.WriteLine("========================");
            }
        }

        static void Main(string[] args)
        {
            Student student1 = new Student("홍길동", 20, "의료IT공학");
            student1.DisplayInfo();
        }
    }
}