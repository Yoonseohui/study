using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class Object
    { 
    }

    internal class Class16
    {
        static void Main(string[] args)
        {
            Object myObject = new Object();

            // 1번 - 2, 3번
            Type t1 = myObject.GetType();
            Type t2 = typeof("int");
            Type t3 = Type.GetType(int);
            Type t4 = Type.GetType("System.Int32");


            // 2번
            // 애트리뷰트 : 사람이 쓰고 컴퓨터가 읽음
            // 주석 : 사람이 쓰고 사람이 읽음
        }
    }
}
