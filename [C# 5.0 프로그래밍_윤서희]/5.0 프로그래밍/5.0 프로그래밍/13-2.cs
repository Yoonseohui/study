using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._0_프로그래밍
{
    delegate void MyDelegate(int a);

    class Market
    {
        public event MyDelegate CustomerEvent;

        public void BuySomdthing(int CustomerNo)
        {
            if (CustomerNo == 30)
                CustomerEvent(CustomerNo);
        }
    }

    class _13_2
    {
        static void Main(string[] args)
        {
            Market market = new Market();
            market.CustomerEvent += new MyDelegate(msg);

            for (int customerNo = 0; customerNo < 100; customerNo += 10)
                market.BuySomdthing(customerNo);
        }

        static public void msg(int a)
        {
            Console.WriteLine("축하합니다! " + a + "번째 고객 이벤트에 당첨되셨습니다.");
        }
    }
}

// https://afsdzvcx123.tistory.com/entry/C-C-%EB%AC%B8%EB%B2%95-%EC%9D%B4%EB%B2%A4%ED%8A%B8Event-%EC%84%A0%EC%96%B8-%EB%B0%8F-%EC%82%AC%EC%9A%A9-%EB%B0%A9%EB%B2%95