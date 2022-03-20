using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class NameCard
    {
        private int _age;
        private string _name;

        // GetAge(), SetAge(), GetName(), SetName() 메소드를 프로퍼티로 변경
        /*
        public int GetAge()
        { return age; }

        public void SetAge(int value)
        { age = value; }

        public string GetName()
        { return name; }

        public void SetName(string value)
        { name = value; }
        */

        // 프로퍼티 추가
        public int Age
        {
            get => _age;
            set => _age = value;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
    }
    class Class9_1
    {
        public static void Main(string[] args)
        {
            NameCard MyCard = new NameCard();

            //MyCard.SetAge(24);
            //MyCard.SetName("상현");

            // 프로퍼티 set
            MyCard.Age = 24;
            MyCard.Name = "상현";

            // 프로퍼티 get
            Console.WriteLine("나이 : {0}", MyCard.Age);
            Console.WriteLine("이름 : {0}", MyCard.Name);
        }
    }
}
