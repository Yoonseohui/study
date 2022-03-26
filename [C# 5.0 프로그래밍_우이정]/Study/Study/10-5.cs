using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    internal class Class10_5
    {
        public static void Main()
        {
            Hashtable ht = new Hashtable();

            // 1)
            ht["Company"] = "Micorsoft";
            // 2)
            ht["URL"] = "www.microsoft.com";

            // 3)
            Console.WriteLine("회사 : {0}", ht["Company"]);
            // 4)
            Console.WriteLine("회사 : {0}", ht["URL"]);
        }
    }
}
