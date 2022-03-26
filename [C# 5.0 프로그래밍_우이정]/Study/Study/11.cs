using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    internal class Class11
    {
        public static void Main()
        {
            // 1 번 - 타입 지정 시, 해당 타입의 값만 할당되어야 함
            //Queue queue = new Queue();
            //queue.Enqueue(10);
            //queue.Enqueue("한글");
            //queue.Enqueue(3.14);

            //Queue<int> queue2 = new Queue<int>();
            //queue2.Enqueue(10);
            //queue2.Enqueue("한글");   int 형이 아닌 string 이 들어감
            //queue2.Enqueue(3.14);   int 형이 아닌 double 이 들어감


            // 2 번
            // 1)
            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic["하나"] = "one";
            dic["둘"] = "two";
            dic["셋"] = "three";
            dic["넷"] = "four";
            dic["다섯"] = "five";

            Console.WriteLine(dic["하나"]);
            Console.WriteLine(dic["둘"]);
            Console.WriteLine(dic["셋"]);
            Console.WriteLine(dic["넷"]);
            Console.WriteLine(dic["다섯"]);
        }
    }
}
