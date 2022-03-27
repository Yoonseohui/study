using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._0_프로그래밍
{
    class _11_1
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue("한글");
            queue.Enqueue(3.14);

            Queue<int> queue2 = new Queue<int>();
            queue2.Enqueue(10);
            queue2.Enqueue("한글");
            queue2.Enqueue(3.14);

        }
    }
}

//queue2.Enqueue("한글");
//queue2.Enqueue(3.14);
//int로 받았는데 string과 double은 사용할 수 없음