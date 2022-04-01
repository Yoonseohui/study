using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    // delegate는 C/C++의 함수 포인터와 비슷한 개념으로 메소드 파라미터와 리턴 타임에 대한 정의를 한 후,
    // 동일한 파라미터와 리턴 타입을 가진 메소드를 서로 호환해서 불러 쓸 수 있는 기능
    // C++ 함수 포인터와 달리 멤버 함수에 대해 완전히 개체지향적임.
    // delegate는 개체 인스턴스 및 메소드를 모두 캡슐화함

    // 익명 함수를 사용하여 메소드를 일회용으로 사용가능함
    // 익명 함수를 만들기 위해 delegate 키워드와 함께 실행 문장 블록을 작성하면 됨
    
    delegate int MyDelegate(int a, int b);

    class Class13_1
    {
        public static void Main(string[] args)
        {
            MyDelegate Callback;

            // 익명 함수 작성
            Callback = delegate (int a, int b) { return a + b; };

            Console.WriteLine(Callback(3, 4));

            // 익명 함수 작성 - 람다식 작성
            // 람다식을 사용하여 익명 함수를 생성할 수 있음
            // 람다식은 식이 본문으로 포함된 '식 람다' 혹은 문 블록이 본문으로 포함된 '문 람다'로 구분됨
            // 식 람다 : (input-parameters) => expression
            // 문 람다 : (input-parameters) => { <sequence-of-statements> }
            Callback = (a, b) => { return a - b; };

            Console.WriteLine(Callback(7, 5));
        }
    }
}

// 참고 사이트
// https://www.csharpstudy.com/CSharp/CSharp-delegate.aspx
// https://docs.microsoft.com/ko-kr/dotnet/csharp/programming-guide/delegates/
// https://www.csharpstudy.com/CSharp/CSharp-anonymous-method.aspx
// https://debuglog.tistory.com/147