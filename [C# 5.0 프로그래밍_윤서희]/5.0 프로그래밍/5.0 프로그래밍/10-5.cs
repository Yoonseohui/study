using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._0_프로그래밍
{
    class _10_5
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht["회사"] = "Microsoft";
            ht["URL"] = "www.microsoft.com";

            Console.WriteLine("회사 : {0}", ht["회사"]);
            Console.WriteLine("URL: {0}", ht["URL"]);
        }
    }
}
