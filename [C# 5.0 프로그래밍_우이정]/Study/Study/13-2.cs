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
        // 모든 이벤트는 특수한 형태의 delegatedla
        public event MyDelegate CustomerEvent;

        public void Buysomething(int CustomerNo)
        {
            if (CustomerNo == 30)
                CustomerEvent(CustomerNo);
        }
    }

    class Class13_2
    {
        static void Main(string[] args)
        {
            Market market = new Market();
            market.CustomerEvent += new MyDelegate (/*이벤트 처리기를 구현하세요.*/);

            for (int customerNo = 0; customerNo < 100; customerNo += 10)
                market.Buysomething(customerNo);
        }
    }
}

// 참고 사이트
// https://www.csharpstudy.com/CSharp/CSharp-delegate3.aspx