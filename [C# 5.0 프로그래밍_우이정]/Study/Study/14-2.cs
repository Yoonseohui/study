using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    internal class Class14_2
    {
        static void Main(string[] args)
        {
            int[] array = { 11, 22, 33, 44, 55 };

            foreach (int a in array)
            {
                //Action action = new Action
                //(
                //    delegate()
                //    {
                //        Console.WriteLine(a * a);
                //    }
                //);

                Action action = new Action( () => { Console.WriteLine(a * a); } );

                action.Invoke();
            }
        }
    }
}
