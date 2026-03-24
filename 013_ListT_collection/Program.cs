using System;
// 컬렉션을 사용하려면 System.Collections.Generic using한다.
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ListT_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<T> 객체 a와 Random 객체 r을 생성한다.
            List<int> a = new List<int>();
            Random r = new Random();

            // PrintValues 메서드를 호출하여 a에 저장된 값을 출력한다.
            // 아직 값을 넣지 않았으므로 Count와 Capacity 속성의 값은 0으로 출력된다.
            PrintValues(a);

            // 10번 반복하여 a에 0~100까지의 랜덤 숫자를 저장한다.
            for (int i = 0; i < 10; i++)
                a.Add(r.Next(100));

            // 정렬하기 전, PrintValues() 메서드를 호출하여 a에 저장된 값을 출력한다.
            // Count 속성의 값은 10, Capacity 속성의 값은 16으로 출력된다.
            PrintValues(a);

            // a의 값을 정렬하고 PrintValues() 메서드를 호출하여 a에 저장된 값을 출력한다.
            a.Sort();
            PrintValues(a);

            // 3번 인덱스의 값을 제거하고 PrintValues() 메서드를 호출하여 a에 저장된 값을 출력한다.
            // Count = 9가 되고 3번 인덱스의 값이 제거된 것을 확인할 수 있다.
            // Capacity 속성의 값은 변화가 없다.
            a.RemoveAt(3);
            PrintValues(a);
        }

        // List<int>의 요소들을 출력하는 메소드
        // Count와 Capacity 속성의 값을 출력한다.
        // foreach문을 사용하여 a의 각 요소들을 출력한다.
        private static void PrintValues(List<int> a)
        {
            Console.WriteLine("Print Values in List<int>");
            Console.WriteLine(" Count = {0}", a.Count);
            Console.WriteLine(" Capacity = {0}", a.Capacity);
            foreach (var i in a)
                Console.Write(" {0}", i);
            Console.WriteLine();
        }
    }
}