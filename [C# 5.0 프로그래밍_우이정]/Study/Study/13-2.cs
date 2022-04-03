using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    delegate void MyDelegate(int a);

    class Market
    {
        // 모든 이벤트는 특수한 형태의 delegate임
        public event MyDelegate CustomerEvent;

        public void Buysomething(int CustomerNo)
        {
            if (CustomerNo == 30)
                CustomerEvent(CustomerNo);
        }
    }

    class Class13_2
    {
        public static void EventResult(int a)
        {
            Console.WriteLine("축하합니다. {0}번째 고객 이벤트에 당첨되셨습니다.", a);
        }

        static void Main(string[] args)
        {

            // 기대 출력값 : 축하합니다. 30번째 고객 이벤트에 당첨되셨습니다.
            Market market = new Market();
            market.CustomerEvent += new MyDelegate(EventResult);

            for (int customerNo = 0; customerNo < 100; customerNo += 10)
                market.Buysomething(customerNo);
        }
    }
}

// 참고 사이트
// https://www.csharpstudy.com/CSharp/CSharp-delegate3.aspx