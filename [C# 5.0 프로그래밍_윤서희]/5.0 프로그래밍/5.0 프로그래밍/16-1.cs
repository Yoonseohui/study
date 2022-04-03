using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._0_프로그래밍
{
    class _16_1
    {
        private static object myObject;

        static void Main(string[] args)
        {
            Type t = myObject.GetType();

            Type t1 = typeof("int");

            Type t3 = Type.GetType(int);

            Type t4 = Type.GetType("System.Int32");
        }
    }
}

//답 2
//Type t1 = typeof(int);