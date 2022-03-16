using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class NameCard
    {
        private int age;
        private string name;

        // GetAge(), SetAge(), GetName(), SetName() 메소드를 프로퍼티로 변경
        public int GetAge()
        { return age; }

        public void SetAge(int value)
        { age = value; }

        public string GetName()
        { return name; }

        public void SetName(string value)
        { name = value; }
    }
    class Class9_1
    {
        public static void Main(string[] args)
        {
            NameCard MyCard = new NameCard();

            MyCard.SetAge(24);
            MyCard.SetName("상현");

            Console.WriteLine("나이 : {0}", MyCard.GetAge());
            Console.WriteLine("이름 : {0}", MyCard.GetName());
        }
    }
}
